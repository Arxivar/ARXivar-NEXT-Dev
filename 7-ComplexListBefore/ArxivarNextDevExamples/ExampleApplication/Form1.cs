using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace ExampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoginClick(null, null);
        }

        private string _authToken;
        private string _refreshToken;

        public IO.Swagger.Client.Configuration Configuration
        {
            get
            {
                return new Configuration(new ApiClient("http://localhost/ARXivarResourceServer/"))
                {
                    ApiKey = new Dictionary<string, string>() { { "Authorization", _authToken} },
                    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                };
            }
        }

        private void LoginClick(object sender, EventArgs e)
        {
            try
            {
                var authApi = new IO.Swagger.Api.AuthenticationApi("http://localhost/ARXivarResourceServer/");
                var resultToken = authApi.AuthenticationGetToken(userTxt.Text, passwordTxt.Text);
                _authToken = resultToken.AccessToken;
                _refreshToken = resultToken.RefreshToken;
                tokenLabel.Text = "Token presente";
                tokenLabel.ForeColor = Color.Green;
                tokenValue.Text = string.Empty;
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

        private void refreshToken(object sender, EventArgs e)
        {
            try
            {
                var authApi = new IO.Swagger.Api.AuthenticationApi("http://localhost/ARXivarResourceServer/");
                var resultToken = authApi.AuthenticationRefresh(_refreshToken);
                _authToken = resultToken.AccessToken;
                _refreshToken = resultToken.RefreshToken;
                tokenLabel.Text = "Token presente";
                tokenLabel.ForeColor = Color.Green;
                tokenValue.Text = string.Empty;
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

        private void buttonGetAoo_Click(object sender, EventArgs e)
        {
            try
            {
                var aooApi = new IO.Swagger.Api.BusinessUnitsApi(Configuration);
                var businessUnits = aooApi.BusinessUnitsGet();
                aooTable.DataSource = businessUnits;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }   
        }

        private void buttonGetDocTypes_Click(object sender, EventArgs e)
        {
            try
            {
                var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGet("search", "AbleBS");
                aooTable.DataSource = docTypes;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void buttonGetAooAsync_Click(object sender, EventArgs e)
        {
            try
            {
                var aooApi = new IO.Swagger.Api.BusinessUnitsApi(Configuration);
                var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
                AsyncDocTypes(aooApi, docTypesApi);
                var x = 2;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private async Task AsyncDocTypes(IO.Swagger.Api.BusinessUnitsApi aooApi, IO.Swagger.Api.DocumentTypesApi docTypesApi)
        {
            var aoos = await aooApi.BusinessUnitsGetAsync();
            var doctypes = await docTypesApi.DocumentTypesGetAsync("search", aoos.First().Code);
            aooTable.DataSource = doctypes;
        }
    }
}
