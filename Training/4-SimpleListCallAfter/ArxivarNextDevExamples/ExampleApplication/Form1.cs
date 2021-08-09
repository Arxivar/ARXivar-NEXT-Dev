﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                //Inizializzo BusinessUnit Api
                var aooApi = new ... . ... . ... . ... (Configuration);

                //Mi fatto ritornare la lista delle AOO presenti in Arxivar Next
                var businessUnits = aooApi. ...();

                //Bind to the grid as IEnumerable<T>
                aooTable.DataSource = ...;
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
                    //Recuperiamo, dalla riga selezionata, il codice della AOO
                    var aooCode = ((BusinessUnitDTO) aooTable.SelectedRows[0].DataBoundItem).Code;

                    //Inizializzo "DocumentTypes Api"
                    var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);

                    //Mi faccio ritornare la lista delle classi documentali censite
                    var docTypes = docTypesApi.DocumentTypesGet_0(1, aooCode);

                    //Costruisco la tabella con la lista delle classi documentali
                    aooTable.DataSource = docTypes;
                }
                
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }
    }
}
