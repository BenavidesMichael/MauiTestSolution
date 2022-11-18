namespace MauiTest.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        #region Setting Constants
        private const string AccessToken = "access_token";
        private const string IdToken = "id_token";
        private const string IdLatitude = "latitude";
        private const string IdLongitude = "longitude";
        private const string IdAllowGpsLocation = "allow_gps_location";
        private readonly string AccessTokenDefault = string.Empty;
        private readonly string IdTokenDefault = string.Empty;
        private readonly bool AllowGpsLocationDefault = false;
        #endregion

        #region Settings Properties

        public string AuthAccessToken
        {
            get => Preferences.Get(AccessToken, AccessTokenDefault);
            set => Preferences.Set(AccessToken, value);
        }

        public string AuthIdToken
        {
            get => Preferences.Get(IdToken, IdTokenDefault);
            set => Preferences.Set(IdToken, value);
        }

        public string Latitude
        {
            get => Preferences.Get(IdLatitude, string.Empty);
            set => Preferences.Set(IdLatitude, value);
        }

        public string Longitude
        {
            get => Preferences.Get(IdLongitude, string.Empty);
            set => Preferences.Set(IdLongitude, value);
        }

        public bool AllowGpsLocation
        {
            get => Preferences.Get(IdAllowGpsLocation, AllowGpsLocationDefault);
            set => Preferences.Set(IdAllowGpsLocation, value);
        }

        #endregion
    }
}