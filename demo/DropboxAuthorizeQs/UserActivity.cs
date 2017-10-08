using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Dropbox.Core.Android;

namespace DropboxAuthorizeQs
{
    [Activity(Label = "UserActivity", MainLauncher = true, Theme = "@style/AppTheme")]
    public class UserActivity : DropboxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_user);

            var toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.app_bar);
            SetSupportActionBar(toolbar);

            var loginButton = (Button)FindViewById(Resource.Id.login_button);
            loginButton.Click += (s, e) =>
            {
                Auth.StartOAuth2Authentication(this, GetString(Resource.String.app_key));
            };

            var filesButton = (Button)FindViewById(Resource.Id.files_button);

            filesButton.Click += (sender, e) =>
            {
                StartActivity(FilesActivity.GetIntent(this, ""));
            };

            var openWithButton = (Button)FindViewById(Resource.Id.open_with);
            openWithButton.Click += (sender, e) =>
            {
                Intent openWithIntent = new Intent(this, typeof(OpenWithActivity));
                StartActivity(openWithIntent);
            };
        }


        protected override void OnResume()
        {
            base.OnResume();

            if (HasToken())
            {
                FindViewById(Resource.Id.login_button).Visibility = ViewStates.Gone;
                FindViewById(Resource.Id.email_text).Visibility = ViewStates.Visible;
                FindViewById(Resource.Id.name_text).Visibility = ViewStates.Visible;
                FindViewById(Resource.Id.type_text).Visibility = ViewStates.Visible;
                FindViewById(Resource.Id.files_button).Enabled = (true);
                FindViewById(Resource.Id.open_with).Enabled = (true);
            }
            else
            {
                FindViewById(Resource.Id.login_button).Visibility = ViewStates.Visible;
                FindViewById(Resource.Id.email_text).Visibility = ViewStates.Gone;
                FindViewById(Resource.Id.name_text).Visibility = ViewStates.Gone;
                FindViewById(Resource.Id.type_text).Visibility = ViewStates.Gone;
                FindViewById(Resource.Id.files_button).Enabled = (false);
                FindViewById(Resource.Id.open_with).Enabled = (false);
            }
        }

        protected async override void LoadData()
        {
            var result = await Task.Run(() =>
            {
                var client = DropboxClientFactory.GetClient();

                return client.Users().CurrentAccount;
            });

            ((TextView)FindViewById(Resource.Id.email_text)).Text =(result.Email);
            ((TextView)FindViewById(Resource.Id.name_text)).Text =(result.Name.DisplayName);
            ((TextView)FindViewById(Resource.Id.type_text)).Text =(result.AccountType.Name());
        }
    }
}
