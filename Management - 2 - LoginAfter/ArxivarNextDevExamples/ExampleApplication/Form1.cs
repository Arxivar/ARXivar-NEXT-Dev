using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Management.Client;
using IO.Swagger.Model;

namespace ExampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _appId = Settings.ExampleSettings.AppName;
        private string _secret = Settings.ExampleSettings.AppSecret;
        private string _apiUrl = Settings.ExampleSettings.ApiBaseUrl;

        private string _authToken;
        private string _refreshToken;

        public IO.Swagger.Management.Client.Configuration Configuration
        {
            get
            {
                //Build a configuration object with the Token provided during login procedure or refresh token procedure
                return new Configuration()
                {
                    BasePath = _apiUrl,
                    ApiKey = new Dictionary<string, string>() { { "Authorization", _authToken} },
                    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Inizialize Authentication api (Authentication api not require authentication token)
                var authApi = new IO.Swagger.Api.AuthenticationApi(_apiUrl);
                //Login to obtain a valid token (and a refresh token)

                /*
                 *
                 *
                 *
                 *      In the login procedure for the management API it is necessary to specify the additional scope ArxManagement to obtain a token enabled for management API
                 *
                 *
                 *
                 */


                var resultToken = authApi.AuthenticationGetToken(new AuthenticationTokenRequestDTO(userTxt.Text, passwordTxt.Text, _appId, _secret,null, null, null, null, null, null, null, new List<string>{"ArxManagement"}));

                _authToken = resultToken.AccessToken;
                _refreshToken = resultToken.RefreshToken;

                tokenLabel.Text = "Token presente";
                tokenLabel.ForeColor = Color.Green;
                tokenValue.Text = string.Empty;
                //Print token information
                foreach (var propertyInfo in resultToken.GetType().GetProperties())
                {
                    tokenValue.Text += string.Format("{0}: {1}{2}", propertyInfo.Name, propertyInfo.GetValue(resultToken), Environment.NewLine);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aooManagementApi = new IO.Swagger.Management.Api.BusinessUnitsManagementApi(Configuration);
            var aoos = aooManagementApi.BusinessUnitsManagementGet();
            aooGrid.DataSource = aoos;
        }
    }
}
