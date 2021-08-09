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
using Abletech.WebApi.Client.Arxivar.Client;
using Abletech.WebApi.Client.Arxivar.Model;

namespace ExampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Auto login only for debug purpose
            LoginClick(null, null);
        }

        private string _authToken;
        private string _refreshToken;

        public Abletech.WebApi.Client.Arxivar.Client.Configuration Configuration
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
        private string _appId = Settings.ExampleSettings.AppName;
        private string _secret = Settings.ExampleSettings.AppSecret;
        private string _apiUrl = Settings.ExampleSettings.ApiBaseUrl;


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

        
        private void buttonGetAoo_Click(object sender, EventArgs e)
        {
            try
            {
                //Inizialize BusinessUnit Api
                var aooApi = new Abletech.WebApi.Client.Arxivar.Api.BusinessUnitsApi(Configuration);
                //Get Aoo list
                var businessUnits = aooApi.BusinessUnitsGet();
                //Bind to the grid as IEnumerable<T>
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
                if (aooTable.SelectedRows != null && aooTable.SelectedRows.Count > 0)
                {
                    var aooCode = ((BusinessUnitDTO) aooTable.SelectedRows[0].DataBoundItem).Code;
                    //Inizialize DocumentTypes Api
                    var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                    //Get DocumentTypes list

                    var docTypes = docTypesApi.DocumentTypesGet_0(1, aooCode);
                    //Bind to the grid
                    aooTable.DataSource = docTypes;
                }
                
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
                //Inizialize BusinessUnit & DocumentTypes Api
                var aooApi = new Abletech.WebApi.Client.Arxivar.Api.BusinessUnitsApi(Configuration);
                var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                //Call Async method
                AsyncDocTypes(aooApi, docTypesApi);
                //Test asyncronous operations
                MessageBox.Show("Step forward from async call: " + DateTime.Now.ToString("O"));
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private async Task AsyncDocTypes(Abletech.WebApi.Client.Arxivar.Api.BusinessUnitsApi aooApi, Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi docTypesApi)
        {
            List<DocumentTypeBaseDTO> doctypes = null;
            for (int i = 0; i < 100; i++)
            {
                var aoos = await aooApi.BusinessUnitsGetAsync(0, "");
                doctypes = await docTypesApi.DocumentTypesGet_0Async(1, aoos.First().Code);
            }

            aooTable.Invoke((MethodInvoker)delegate ()
            {
                aooTable.DataSource = doctypes;
                MessageBox.Show("End of async calls: " + DateTime.Now.ToString("O"));
            });
        }

        private void maskGetData(object sender, EventArgs e)
        {
            try
            {
                var maskApi = new Abletech.WebApi.Client.Arxivar.Api.MasksApi(Configuration);
                var masks = maskApi.MasksGetList();
                datagridComplex.DataSource = masks;

            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }


        private void getMaskByIdHandler(object sender, EventArgs e)
        {
            try
            {
                var maskApi = new Abletech.WebApi.Client.Arxivar.Api.MasksApi(Configuration);
                if (datagridComplex.SelectedRows != null && datagridComplex.SelectedRows.Count > 0)
                {
                    var mascheraSelezionata = (MaskDTO) datagridComplex.SelectedRows[0].DataBoundItem;
                    var mascheraDettaglio = maskApi.MasksGetById(mascheraSelezionata.Id);
                    MessageBox.Show(string.Format("La maschera {0} contiene {1} dettagli", mascheraDettaglio.MaskName, mascheraDettaglio.MaskDetails.Count));
                }
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void buttonPredefinedProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var predefinedProfileApi = new Abletech.WebApi.Client.Arxivar.Api.PredefinedProfilesApi(Configuration);
                var predefProfiles = predefinedProfileApi.PredefinedProfilesGet();
                datagridComplex.DataSource = predefProfiles;

            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void buttonPredProfById_Click(object sender, EventArgs e)
        {
            try
            {
                var predefinedProfileApi = new Abletech.WebApi.Client.Arxivar.Api.PredefinedProfilesApi(Configuration);
                if (datagridComplex.SelectedRows != null && datagridComplex.SelectedRows.Count > 0)
                {
                    var predefinedProfileSelected = (PredefinedProfileDTO) datagridComplex.SelectedRows[0].DataBoundItem;
                    var predefinedProfileDetail = predefinedProfileApi.PredefinedProfilesGetById(predefinedProfileSelected.Id);
                    MessageBox.Show(string.Format("Il profilo predefinito {0} contiene {1} dettagli", predefinedProfileDetail.Name, predefinedProfileDetail.Fields.Count));
                }
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }
    }
}
