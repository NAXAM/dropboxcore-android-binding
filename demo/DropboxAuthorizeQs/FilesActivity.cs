
using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Support.V7.Widget;
using Com.Dropbox.Core.V2.Files;
using Android.Widget;
using Android.Util;
using Android.Webkit;
using System.Threading.Tasks;
using Android.Provider;
using Android.Database;

namespace DropboxAuthorizeQs
{
    [Activity(Label = "Files", Theme = "@style/AppTheme")]
    public class FilesActivity : DropboxActivity
    {
        static readonly String TAG = nameof(FilesActivity);

        public readonly static String EXTRA_PATH = "FilesActivity_Path";

        static readonly int PICKFILE_REQUEST_CODE = 1;

        const int RES_REQUEST_CODE = 101;
        const int WES_REQUEST_CODE = 102;

        string mPath;
        FilesAdapter mFilesAdapter;
        FileMetadata mSelectedFile;

        public static Intent GetIntent(Context context, String path)
        {
            Intent filesIntent = new Intent(context, typeof(FilesActivity));
            filesIntent.PutExtra(EXTRA_PATH, path);
            return filesIntent;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var path = Intent.GetStringExtra(EXTRA_PATH);
            mPath = string.IsNullOrWhiteSpace(path) ? "" : path;

            SetContentView(Resource.Layout.activity_files);

            var toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.app_bar);
            SetSupportActionBar(toolbar);

            var fab = (FloatingActionButton)FindViewById(Resource.Id.fab);
            fab.Click += (s, e) =>
            {
                PerformWithPermissions(RES_REQUEST_CODE);
            };

            var recyclerView = (RecyclerView)FindViewById(Resource.Id.files_list);

            mFilesAdapter = new FilesAdapter(PicassoClient.GetPicasso());
            mFilesAdapter.MetadataSelected += (sender, metadata) =>
            {
                if (metadata is FolderMetadata folderMetadata)
                {
                    StartActivity(GetIntent(this, folderMetadata.PathLower));
                }

                else if (metadata is FileMetadata fileMetadata)
                {
                    mSelectedFile = fileMetadata;
                    PerformWithPermissions(WES_REQUEST_CODE);
                }
            };

            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.SetAdapter(mFilesAdapter);

            mSelectedFile = null;
        }

        void LaunchFilePicker()
        {
            // Launch intent to pick file for upload
            Intent intent = new Intent(Intent.ActionGetContent);
            intent.AddCategory(Intent.CategoryOpenable);
            intent.SetType("*/*");
            StartActivityForResult(intent, PICKFILE_REQUEST_CODE);
        }


        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == PICKFILE_REQUEST_CODE)
            {
                if (resultCode == Result.Ok)
                {
                    // This is the result of a call to launchFilePicker
                    UploadFile(data.Data.ToString());
                }
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            bool granted = grantResults.All(x => x == Permission.Granted);

            if (granted)
            {
                PerformAction(requestCode);
            }
            else
            {
                switch (requestCode)
                {
                    case RES_REQUEST_CODE:
                        Toast.MakeText(this,
                                "Can't upload file: read access denied. " +
                                        "Please grant storage permissions to use this functionality.",
                                       ToastLength.Long)
                            .Show();
                        break;
                    case WES_REQUEST_CODE:
                        Toast.MakeText(this,
                                "Can't download file: write access denied. " +
                                        "Please grant storage permissions to use this functionality.",
                                ToastLength.Long)
                            .Show();
                        break;
                }
            }
        }

        void RerformAction(int action)
        {
            switch (action)
            {
                case RES_REQUEST_CODE:
                    LaunchFilePicker();
                    break;
                case WES_REQUEST_CODE:
                    if (mSelectedFile != null)
                    {
                        DownloadFile(mSelectedFile);
                    }
                    else
                    {
                        Log.Error(TAG, "No file selected to download.");
                    }
                    break;
                default:
                    Log.Error(TAG, "Can't perform unhandled file action: " + action);
                    break;
            }
        }

        protected async override void LoadData()
        {
            ProgressDialog dialog = new ProgressDialog(this);
            dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            dialog.SetCancelable(false);
            dialog.SetMessage("Loading");
            dialog.Show();

            var result = await Task.Run(() =>
            {
                var client = DropboxClientFactory.GetClient();

                return client.Files().ListFolder(mPath);
            });

            dialog.Dismiss();
            mFilesAdapter.SetFiles(result.Entries);
        }

        async void DownloadFile(FileMetadata metadata)
        {
            ProgressDialog dialog = new ProgressDialog(this);
            dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            dialog.SetCancelable(false);
            dialog.SetMessage("Downloading");
            dialog.Show();

            var result = await Task.Run(() =>
            {
                var directory = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads);

                //// Make sure the Downloads directory exists.
                if (!directory.Exists())
                {
                    if (!directory.Mkdirs())
                    {
                        return null;
                    }

                    directory.Mkdir();
                }
                else if (!directory.IsDirectory)
                {
                    return null;
                }

                var filePath = System.IO.Path.Combine(directory.Path, metadata.Name);

                using (var stream = System.IO.File.OpenWrite(filePath))
                {
                    DropboxClientFactory
                        .GetClient()
                        .Files()
                        .Download(metadata.PathLower, metadata.Rev)
                        .Download(stream);
                }

                //// Tell android about the file
                var fileUri = Android.Net.Uri.Parse(filePath);
                Intent intent = new Intent(Intent.ActionMediaScannerScanFile);
                intent.SetData(fileUri);
                SendBroadcast(intent);

                return fileUri;
            });

            dialog.Dismiss();
            ViewFileInExternalApp(metadata, result);

        }

        void ViewFileInExternalApp(FileMetadata metadata, Android.Net.Uri result)
        {
            Intent intent = new Intent(Intent.ActionView);
            MimeTypeMap mime = MimeTypeMap.Singleton;
            String ext = metadata.Name.Substring(metadata.Name.IndexOf('.') + 1);
            String type = mime.GetMimeTypeFromExtension(ext);

            intent.SetDataAndType(result, type);

            // Check for a handler first to avoid a crash
            PackageManager manager = PackageManager;
            IList<ResolveInfo> resolveInfo = manager.QueryIntentActivities(intent, 0);
            if (resolveInfo.Count() > 0)
            {
                StartActivity(intent);
            }
        }

        async void UploadFile(string filePath)
        {
            ProgressDialog dialog = new ProgressDialog(this);
            dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            dialog.SetCancelable(false);
            dialog.SetMessage("Uploading");
            dialog.Show();

            await Task.Run(() =>
            {
                var client = DropboxClientFactory.GetClient();

                filePath = UriHelpers.GetFileForUri(this, filePath);
                var fileInfo = new System.IO.FileInfo(filePath);

                using (var stream = System.IO.File.OpenRead(filePath))
                {
                    var folderPath = string.IsNullOrWhiteSpace(mPath) ? "/" : mPath;
                    var remoteFilePath = System.IO.Path.Combine(folderPath, fileInfo.Name);

                    client
                        .Files()
                        .UploadBuilder(remoteFilePath)
                        .WithMode(WriteMode.Overwrite)
                        .UploadAndFinish(stream);
                }
            });

            dialog.Dismiss();
            LoadData();
        }

        void PerformWithPermissions(int action)
        {
            if (HasPermissionsForAction(action))
            {
                PerformAction(action);
                return;
            }

            if (ShouldDisplayRationaleForAction(action))
            {
                var snackbar = Snackbar.Make(
                    FindViewById(Resource.Id.files_list),
                    "This app requires storage access to download and upload files.",
                    3000
                );
                snackbar.SetAction("Ok", (obj) =>
                {
                    RequestPermissionsForAction(action);
                });
                snackbar.Show();
            }
            else
            {
                RequestPermissionsForAction(action);
            }
        }

        bool HasPermissionsForAction(int action)
        {
            string permission;

            switch (action)
            {
                case RES_REQUEST_CODE:
                    permission = Android.Manifest.Permission.ReadExternalStorage;
                    break;
                case WES_REQUEST_CODE:
                    permission = Android.Manifest.Permission.WriteExternalStorage;
                    break;

                default:
                    return false;
            }

            var result = ContextCompat.CheckSelfPermission(this, permission);

            return result == Permission.Granted;
        }

        bool ShouldDisplayRationaleForAction(int action)
        {
            string permission;

            switch (action)
            {
                case RES_REQUEST_CODE:
                    permission = Android.Manifest.Permission.ReadExternalStorage;
                    break;
                case WES_REQUEST_CODE:
                    permission = Android.Manifest.Permission.WriteExternalStorage;
                    break;

                default:
                    return false;
            }

            if (!ActivityCompat.ShouldShowRequestPermissionRationale(this, permission))
            {
                return true;
            }

            return false;
        }

        void RequestPermissionsForAction(int action)
        {
            string[] permissions;

            switch (action)
            {
                case RES_REQUEST_CODE:
                    permissions = new[] { Android.Manifest.Permission.ReadExternalStorage };
                    break;
                case WES_REQUEST_CODE:
                    permissions = new[] { Android.Manifest.Permission.WriteExternalStorage };
                    break;

                default:
                    return;
            }


            ActivityCompat.RequestPermissions(
                    this,
                    permissions,
                    action
            );
        }

        void PerformAction(int action)
        {
            switch (action)
            {
                case RES_REQUEST_CODE:
                    LaunchFilePicker();
                    break;
                case WES_REQUEST_CODE:
                    if (mSelectedFile != null)
                    {
                        DownloadFile(mSelectedFile);
                    }
                    else
                    {
                        Log.Error(TAG, "No file selected to download.");
                    }
                    break;
                default:
                    Log.Error(TAG, "Can't perform unhandled file action: " + action);
                    break;
            }
        }
    }

    public static class UriHelpers
    {
        /**
         * Get the file path for a uri. This is a convoluted way to get the path for an Uri created using the
         * StorageAccessFramework. This in no way is the official way to do this but there does not seem to be a better
         * way to do this at this point. It is taken from https://github.com/iPaulPro/aFileChooser.
         *
         * @param context The context of the application
         * @param uri The uri of the saved file
         * @return The file with path pointing to the saved file. It can return null if we can't resolve the uri properly.
         */
        public static string GetFileForUri(Context context, string filePath)
        {
            var uri = Android.Net.Uri.Parse(filePath);
            var csuri = new Uri(uri.ToString());

            String path = null;
            // DocumentProvider
            if (DocumentsContract.IsDocumentUri(context, uri))
            {
                // ExternalStorageProvider
                if (IsExternalStorageDocument(csuri))
                {
                    var docId = DocumentsContract.GetDocumentId(uri);
                    var split = docId.Split(':');
                    var type = split[0];

                    if ("primary".Equals(type, StringComparison.OrdinalIgnoreCase))
                    {
                        path = Android.OS.Environment.ExternalStorageState + "/" + split[1];
                    }
                }
                else if (IsDownloadsDocument(csuri))
                {
                    // DownloadsProvider
                    var id = DocumentsContract.GetDocumentId(uri);
                    var contentUri = ContentUris
                        .WithAppendedId(
                            Android.Net.Uri.Parse("content://downloads/public_downloads"),
                            long.Parse(id));

                    path = GetDataColumn(context, contentUri, null, null);
                }
                else if (IsMediaDocument(csuri))
                {
                    // MediaProvider
                    var docId = DocumentsContract.GetDocumentId(uri);
                    var split = docId.Split(':');
                    var type = split[0];

                    Android.Net.Uri contentUri = null;
                    if ("image".Equals(type))
                    {
                        contentUri = MediaStore.Images.Media.ExternalContentUri;
                    }
                    else if ("video".Equals(type))
                    {
                        contentUri = MediaStore.Video.Media.ExternalContentUri;
                    }
                    else if ("audio".Equals(type))
                    {
                        contentUri = MediaStore.Audio.Media.ExternalContentUri;
                    }

                    var selection = "_id=?";
                    var selectionArgs = new[] {
                        split[1]
                    };

                    path = GetDataColumn(context, contentUri, selection, selectionArgs);
                }
            }
            else if ("content".Equals(uri.Scheme, StringComparison.OrdinalIgnoreCase))
            {
                // MediaStore (and general)
                path = GetDataColumn(context, uri, null, null);
            }
            else if ("file".Equals(uri.Scheme, StringComparison.OrdinalIgnoreCase))
            {
                // File
                path = uri.Path;
            }

            return path;
        }

        private static String GetDataColumn(Context context, Android.Net.Uri uri, String selection,
                                            String[] selectionArgs)
        {
            ICursor cursor = null;
            var column = "_data";
            var projection = new[] {
                column
            };

            try
            {
                cursor = context.ContentResolver.Query(uri, projection, selection, selectionArgs, null);
                if (cursor != null && cursor.MoveToFirst())
                {
                    int column_index = cursor.GetColumnIndex(column);
                    return cursor.GetString(column_index);
                }
            }
            finally
            {
                cursor?.Close();
            }
            return null;
        }


        static bool IsExternalStorageDocument(Uri uri)
        {
            return "com.android.externalstorage.documents".Equals(uri.Authority);
        }

        static bool IsDownloadsDocument(Uri uri)
        {
            return "com.android.providers.downloads.documents".Equals(uri.Authority);
        }

        static bool IsMediaDocument(Uri uri)
        {
            return "com.android.providers.media.documents".Equals(uri.Authority);
        }
    }
}
