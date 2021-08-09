using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abletech.WebApi.Client.Arxivar.Model;
using Abletech.WebApi.Client.ArxivarWorkflow.Client;

namespace ExampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Configuration Configuration;

        private string _appId = Settings.ExampleSettings.AppName;
        private string _secret = Settings.ExampleSettings.AppSecret;
        private string _apiUrl = Settings.ExampleSettings.ApiBaseUrl;
        private string _wfApiUrl = Settings.ExampleSettings.WorkflowApiBaseUrl;

        private string _authToken;
        private string _refreshToken;

        private void LoginClick(object sender, EventArgs e)
        {
            try
            {
                //Inizialize Authentication api (Authentication api not require authentication token)
                var authApi = new Abletech.WebApi.Client.Arxivar.Api.AuthenticationApi(_apiUrl);
                //Login to obtain a valid token (and a refresh token)
                var resultToken = authApi.AuthenticationGetToken(new AuthenticationTokenRequestDTO(userTxt.Text, passwordTxt.Text, _appId, _secret));

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

                Configuration =  new Configuration()
                {
                    BasePath = _wfApiUrl,
                    ApiKey = new Dictionary<string, string>() { { "Authorization", _authToken } },
                    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                };

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void refreshToken(object sender, EventArgs e)
        {
            try
            {
                //Inizialize Authentication api (Authentication api not require authentication token)
                var authApi = new Abletech.WebApi.Client.Arxivar.Api.AuthenticationApi(_apiUrl);
                //Try to obtain a new token with the refresh token provided durin login procedure
                var resultToken = authApi.AuthenticationRefresh(new RefreshTokenRequestDTO(_appId, _secret, _refreshToken));
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
                Console.WriteLine(exception);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var wfApi = new Abletech.WebApi.Client.ArxivarWorkflow.Api.DiagramsApi(Configuration);

            var diagramList = wfApi.ApiV1DiagramsInfoGet(0, 0, null, null, 0, 10);

            diagramGrid.DataSource = diagramList.Items;

        }
    }
}
