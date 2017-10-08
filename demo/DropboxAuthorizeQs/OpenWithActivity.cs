

using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Com.Dropbox.Core.Android;

namespace DropboxAuthorizeQs
{
    [Activity(Label = "OpenWith", Theme = "@style/AppTheme")]
    [IntentFilter(
        new string[] { "com.dropbox.android.intent.action.DBXC_EDIT" },
        Categories = new string [] { "android.intent.category.DEFAULT" },
        DataMimeType = "text/plain"
    )]
    public class OpenWithActivity : DropboxActivity
    {
        DbxOfficialAppConnector mDoac;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_open_with);

            var toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.app_bar);
            SetSupportActionBar(toolbar);

            var generateIntentButton = (Button)FindViewById(Resource.Id.generate_intent);

            generateIntentButton.Click += (sender, e) =>
            {
                var editText = (EditText)FindViewById(Resource.Id.editText);
                string path = editText.Text;
                //fake OpenWithIntent with some dummy parameters
                var fakeOpenWithIntent = GenerateOpenWithIntent(path);
                //encode the fake OpenWithIntent into UtmContent
                var encodedFakeIntent = EncodeOpenWithIntent(fakeOpenWithIntent);
                try
                {
                    //test that decoding utmcontent works
                    var decodedIntent = DbxOfficialAppConnector.GenerateOpenWithIntentFromUtmContent(encodedFakeIntent);
                    //start that fake OpenWithIntent. This will lead us to a new OpenWithActivity.
                    StartActivity(decodedIntent);
                }
                catch (DropboxParseException ex)
                {
                    // TODO Auto-generated catch block
                    ex.PrintStackTrace();
                }
            };

            Button mInstalled = (Button)FindViewById(Resource.Id.is_installed);
            mInstalled.Click += (s, e) =>
            {
                var installInfo = DbxOfficialAppConnector.IsInstalled(this);
                ShowToast((installInfo != null) ? installInfo.ToString() : "Not installed!");
            };

            Button mGenLinked = (Button)FindViewById(Resource.Id.is_linked_any_button);
            mGenLinked.Click += (s, e) =>
            {
                var isSigned = DbxOfficialAppConnector.IsAnySignedIn(this);
                ShowToast("Any Signed in?:" + isSigned);
            };

            Button mSpecLinked = (Button)FindViewById(Resource.Id.is_linked_spec_button);
            mSpecLinked.Click += (s, e) =>
            {
                var isSigned = mDoac.IsSignedIn(this);
                ShowToast("Signed in?:" + isSigned);
            };

            Button mPreview = (Button)FindViewById(Resource.Id.preview_button);
            mPreview.Click += (s, e) =>
            {
                var editText = (EditText)FindViewById(Resource.Id.editText);
                var path = editText.Text;
                var pIntent = mDoac.GetPreviewFileIntent(this, path, "");

                if (pIntent == null) {
                    Toast.MakeText(this, "Couldn't create preview intent", ToastLength.Short)
                         .Show();

                    return;
                } 

                StartActivity(pIntent);
            };

            Button mUpgrade = (Button)FindViewById(Resource.Id.upgrade_button);
            mUpgrade.Click += (s, e) =>
            {
                var uIntent = mDoac.GetUpgradeAccountIntent(this);
                StartActivity(uIntent);
            };
        }

        /* Because it's just a fake intent, we just print it in Toast and do nothing here. As third
         * party app you should take the intent from Dropbox official app and potentially go through
         * the auth flow. Finally handle that file sent with this intent.
         */
        void HandleFakeOpenWithIntent(Intent intent)
        {
            var intentAction = intent.Action;
            if (intentAction == DbxOfficialAppConnector.ActionDbxcEdit ||
                intentAction == DbxOfficialAppConnector.ActionDbxcView)
            {
                var path = intent.GetStringExtra(DbxOfficialAppConnector.ExtraDropboxPath);
                var uid = intent.GetStringExtra(DbxOfficialAppConnector.ExtraDropboxUid);
                var read_only = intent.GetBooleanExtra(DbxOfficialAppConnector.ExtraDropboxReadOnly, false);
                var session_id = intent.GetStringExtra(DbxOfficialAppConnector.ExtraDropboxSessionId);
                ShowToast(path + uid + read_only + session_id);
            }
        }

        protected Intent GenerateOpenWithIntent(string path)
        {
            var uid = Auth.Uid;

            // fake the URI
            // WARNING: URI FORMAT IS NOT FINALIZED AND MAY CHANGE AT ANY TIME
            Android.Net.Uri.Builder builder = new Android.Net.Uri.Builder();
            builder.Scheme("content");
            builder.Authority("com.dropbox.android.FileCache");
            builder.AppendPath("filecache");
            builder.AppendPath(uid);

            foreach (var component in path.Substring(1).Split('/'))
            {
                builder.AppendPath(component);
            }

            var uri = builder.Build();
            // end URI fakery

            Intent owpIntent = new Intent(DbxOfficialAppConnector.ActionDbxcEdit, uri);

            // extras
            owpIntent.PutExtra(DbxOfficialAppConnector.ExtraDropboxPath, path);
            owpIntent.PutExtra(DbxOfficialAppConnector.ExtraDropboxUid, uid);
            owpIntent.PutExtra(DbxOfficialAppConnector.ExtraDropboxReadOnly, false);
            owpIntent.PutExtra(DbxOfficialAppConnector.ExtraDropboxSessionId, "generated");
            owpIntent.SetDataAndType(uri, "text/plain");

            return owpIntent;
        }

        protected string EncodeOpenWithIntent(Intent owpIntent)
        {
            /*
             * Encode OpenWith intent
             * Real 3rd party apps should never run this function as DropboxApp does this entirely
             */

            Bundle extras = owpIntent.Extras;
            extras.PutString("_action", owpIntent.Action);
            extras.PutParcelable("_uri", owpIntent.Data);
            extras.PutString("_type", owpIntent.Type);

            // marshall it!
            Parcel parcel = Parcel.Obtain();
            parcel.WriteBundle(extras);
            byte[] b = parcel.Marshall();
            parcel.Recycle();
            return Convert.ToBase64String(b);
        }

        void ShowToast(String msg)
        {
            Toast error = Toast.MakeText(this, msg, ToastLength.Long);
            error.Show();
        }

        protected override void LoadData()
        {
            try
            {
                String uid = Auth.Uid;
                if (uid == null)
                {
                    var prefs = GetSharedPreferences("naxam-dropbox-sample", FileCreationMode.Private);
                    uid = prefs.GetString("user-id", null);
                }
                this.mDoac = new DbxOfficialAppConnector(uid);
            }
            catch (DropboxUidNotInitializedException e)
            {
                e.PrintStackTrace();
                return;
            }

            HandleFakeOpenWithIntent(Intent);
        }
    }
}
