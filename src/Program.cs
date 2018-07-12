using System;

namespace MediaMarkupWinConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientSettings = new MediaMarkup.Settings
            {
                ApiBaseUrl = Settings.MediaMarkupBaseUrl,
                ClientId = Settings.MediaMarkupClientId,
                SecretKey = Settings.MediaMarkupSecretKey
            };

            // Create API Client
            var apiClient = new MediaMarkup.ApiClient(clientSettings);

            // Initialise API Client (Validates api keys and gets an api token for subsequent api calls)
            var token = AsyncHelpers.RunSync(() => apiClient.InitializeAsync());

            var authenticated = AsyncHelpers.RunSync(() => apiClient.Authenticated());
            // Check authentication

            Console.WriteLine($"MediaMarkup Authenticated: {(authenticated ? "Yes" : "No")}");

            //Note: we include AsyncHelpers.cs to handle the async methods
        }
    }
}
