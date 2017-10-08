
using System;
using Android.Content;
using Android.Support.V7.App;
using Com.Dropbox.Core.Android;
using Com.Dropbox.Core.V2;
using Com.Dropbox.Core;
using Com.Dropbox.Core.Http;
using Square.Picasso;
using Com.Dropbox.Core.V2.Files;
using System.IO;

namespace DropboxAuthorizeQs
{
    public abstract class DropboxActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();

            ISharedPreferences prefs = GetSharedPreferences("naxam-dropbox-sample", FileCreationMode.Private);
            String accessToken = prefs.GetString("access-token", null);
            if (accessToken == null)
            {
                accessToken = Auth.OAuth2Token;
                if (accessToken != null)
                {
                    prefs.Edit().PutString("access-token", accessToken).Apply();
                    InitAndLoadData(accessToken);
                }
            }
            else
            {
                InitAndLoadData(accessToken);
            }

            String uid = Auth.Uid;
            String storedUid = prefs.GetString("user-id", null);
            if (uid != null && !uid.Equals(storedUid))
            {
                prefs.Edit().PutString("user-id", uid).Apply();
            }
        }

        void InitAndLoadData(String accessToken)
        {
            DropboxClientFactory.Init(accessToken);
            PicassoClient.Init(ApplicationContext, DropboxClientFactory.GetClient());
            LoadData();
        }

        protected abstract void LoadData();

        protected bool HasToken()
        {
            ISharedPreferences prefs = GetSharedPreferences("naxam-dropbox-sample", FileCreationMode.Private);
            String accessToken = prefs.GetString("access-token", null);
            return accessToken != null;
        }
    }

    public class DropboxClientFactory
    {
        static DbxClientV2 sDbxClient;

        public static void Init(String accessToken)
        {
            if (sDbxClient == null)
            {
                DbxRequestConfig requestConfig = DbxRequestConfig
                    .NewBuilder("naxam-examples-v2-demo")
                    .WithHttpRequestor(new OkHttp3Requestor(OkHttp3Requestor.DefaultOkHttpClient()))
                    .Build();

                sDbxClient = new DbxClientV2(requestConfig, accessToken);
            }
        }

        public static DbxClientV2 GetClient()
        {
            if (sDbxClient == null)
            {
                throw new InvalidOperationException("Client not initialized.");
            }
            return sDbxClient;
        }
    }

    public class PicassoClient
    {
        private static Picasso sPicasso;

        public static void Init(Context context, DbxClientV2 dbxClient)
        {
            // Configure picasso to know about special thumbnail requests
            sPicasso = new Picasso.Builder(context)
                    .Downloader(new OkHttpDownloader(context))
                    .AddRequestHandler(new FileThumbnailRequestHandler(dbxClient))
                    .Build();
        }


        public static Picasso getPicasso()
        {
            return sPicasso;
        }
    }

    public class FileThumbnailRequestHandler : RequestHandler
    {
        static readonly String SCHEME = "dropbox";
        static readonly String HOST = "dropbox";
        readonly DbxClientV2 mDbxClient;

        public FileThumbnailRequestHandler(DbxClientV2 dbxClient)
        {
            mDbxClient = dbxClient;
        }


        public static Uri buildPicassoUri(FileMetadata file)
        {
            var nativeUri = new Android.Net.Uri
                    .Builder()
                    .Scheme(SCHEME)
                    .Authority(HOST)
                    .Path(file.PathLower)
                    .Build();
            return new Uri(nativeUri.ToString());
        }

        public override bool CanHandleRequest(Request data)
        {
            return SCHEME.Equals(data.Uri.Scheme) && HOST.Equals(data.Uri.Host);
        }

        public override Result Load(Request request, int networkPolicy)
        {

            try
            {
                DbxDownloader downloader = mDbxClient
                    .Files()
                    .GetThumbnailBuilder(request.Uri.Path)
                    .WithFormat(ThumbnailFormat.Jpeg)
                    .WithSize(ThumbnailSize.W1024h768)
                    .Start();

                return new Result(downloader.InputStream, Picasso.LoadedFrom.Network);
            }
            catch (DbxException e)
            {
                throw new IOException(e.Message);
            }
        }
    }
}
