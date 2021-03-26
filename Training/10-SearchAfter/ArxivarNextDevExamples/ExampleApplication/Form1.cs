using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Client;
using IO.Swagger.Model;

using Microsoft.VisualBasic;

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

        public IO.Swagger.Client.Configuration Configuration
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
                var authApi = new IO.Swagger.Api.AuthenticationApi(_apiUrl);
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
                var authApi = new IO.Swagger.Api.AuthenticationApi(_apiUrl);
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
                var aooApi = new IO.Swagger.Api.BusinessUnitsApi(Configuration);
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
                    var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
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
                var aooApi = new IO.Swagger.Api.BusinessUnitsApi(Configuration);
                var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
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

        private async Task AsyncDocTypes(IO.Swagger.Api.BusinessUnitsApi aooApi, IO.Swagger.Api.DocumentTypesApi docTypesApi)
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
                var maskApi = new IO.Swagger.Api.MasksApi(Configuration);
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
                var maskApi = new IO.Swagger.Api.MasksApi(Configuration);
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
                var predefinedProfileApi = new IO.Swagger.Api.PredefinedProfilesApi(Configuration);
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
                var predefinedProfileApi = new IO.Swagger.Api.PredefinedProfilesApi(Configuration);
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


        private void buttonSearch_click(object sender, EventArgs e)
        {
            try
            {
                //Preambolo
                String messaggio;
                var businesUnitApi = new ... (Configuration);
                var searchApi = new ...(Configuration);
                var docTypesApi = new ...(Configuration);

                //Su quale AOO dobbiamo lavorare?
                messaggio = "Su quale AOO vuoi lavorare?\n";
                var listaAOO = businesUnitApi. ...(1, "CODICE");
                foreach (BusinessUnitDTO bu in listaAOO)
                {
                    messaggio += string.Format("{0}: {1}\n", bu.Code, bu.Name, bu);
                }
                var buScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");

                //Mi faccio ritornare la lista degli stati documentali
                var listaDocTypes = docTypesApi. ...(1, buScelta);

                //Chiedo all'utente su quela classe documentale lavorare
                messaggio = "Su quale classe documentale vuoi lavorare?\n";
                foreach (DocumentTypeBaseDTO classeDocumentale in listaDocTypes)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.Key, classeDocumentale.Description);
                }
                var classeDocumentoScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var classeDocumento = listaDocTypes.FirstOrDefault(i => i.Key == classeDocumentoScelta);

                //Preparo gli oggetti per le ricerca
                var defaultSearch = ... . ... ();
                var defaultSelect = ... . ...(classeDocumento.Id);

                //Cerco in DOCUMENTTYPE (primo "filtraggio")
                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = 3;

                //Effettuo la ricerca
                var values = ... . ...(new SearchCriteriaDto(..., ...));

                //Preparo il risultato per porlo nel DataTable
                var profiles = new DataTable();
                foreach (var columnSearchResult in values.First().Columns) profiles.Columns.Add(columnSearchResult.Label);
                foreach (var rowSearchResult in values) profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                searchGrid.DataSource = ...;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void buttonDownloadDoc_Click(object sender, EventArgs e)
        {
            try
            {
                var documentApi = new ... (Configuration);
                if (searchGrid.SelectedRows != null && searchGrid.SelectedRows.Count > 0)
                {
                    var doc = documentApi.DocumentsGetForProfileWithHttpInfo(int.Parse(searchGrid.SelectedRows[0].Cells["System ID"].Value.ToString()));
                    var fileName = doc.Headers["Content-Disposition"].Replace("attachment; filename=", "");
                    var buffer = new byte[doc.Data.Length];
                    doc.Data.Read(buffer, 0, Convert.ToInt32(doc.Data.Length));

                    var writeStream = File.Create(fileName);
                    doc.Data.Seek(0, SeekOrigin.Begin);
                    doc.Data.CopyTo(writeStream);
                    writeStream.Close();

                    ProcessStartInfo pi = new ProcessStartInfo(fileName);
                    pi.UseShellExecute = true;
                    pi.FileName = fileName;
                    Process.Start(pi);
                }
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Preambolo
                String messaggio;
                var businesUnitApi = new ...(Configuration);
                var searchApi = new ...(Configuration);
                var docTypesApi = new ...(Configuration);

                //Su quale AOO dobbiamo lavorare?
                messaggio = "Su quale AOO vuoi lavorare?\n";
                var listaAOO = businesUnitApi. ...(1, "CODICE");
                foreach (BusinessUnitDTO bu in listaAOO)
                {
                    messaggio += string.Format("{0}: {1}\n", bu.Code, bu.Name, bu);
                }
                var buScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");

                //Mi faccio ritornare la lista degli stati documentali
                var listaDocTypes = docTypesApi. ...(1, buScelta);

                //Chiedo all'utente su quela classe documentale lavorare
                messaggio = "Su quale classe documentale vuoi lavorare?\n";
                foreach (DocumentTypeBaseDTO classeDocumentale in listaDocTypes)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.Key, classeDocumentale.Description);
                }
                var classeDocumentoScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var classeDocumento = listaDocTypes.FirstOrDefault(i => i.Key == classeDocumentoScelta);

                //Preparo gli oggetti per le ricerca
                var defaultSearch = ... . ...();
                var defaultSelect = ... . ...(classeDocumento.Id);

                //Cerco in DOCUMENTTYPE (primo "filtraggio")
                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = ...;
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);

                //Cerco dato uno specifico DOCNUMBER
                messaggio = "Quale DOCNUMBER desideri?";
                int docuNumberScelto = Int32.Parse(Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore"));
                var docnumbertypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCNUMBER", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchIntDto)docnumbertypefield).Operator = ...;
                ((FieldBaseForSearchIntDto)docnumbertypefield).Valore1 = docuNumberScelto;

                //Effettuo la ricerca
                var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(..., ...));

                //Preparo il risultato per porlo nel DataTable
                var profiles = new DataTable();
                foreach (var columnSearchResult in values.First().Columns) profiles.Columns.Add(columnSearchResult.Label);
                foreach (var rowSearchResult in values) profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                searchGrid.DataSource = profiles;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Preambolo
                String messaggio;
                var businesUnitApi = new ...(Configuration);
                var searchApi = new ...(Configuration);
                var docTypesApi = new ...(Configuration);

                //Su quale AOO dobbiamo lavorare?
                messaggio = "Su quale AOO vuoi lavorare?\n";
                var listaAOO = businesUnitApi.BusinessUnitsGet(1, "CODICE");
                foreach (BusinessUnitDTO bu in listaAOO)
                {
                    messaggio += string.Format("{0}: {1}\n", bu.Code, bu.Name, bu);
                }
                var buScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");

                //Mi faccio ritornare la lista degli stati documentali
                var listaDocTypes = docTypesApi. ...(1, buScelta);

                //Chiedo all'utente su quela classe documentale lavorare
                messaggio = "Su quale classe documentale vuoi lavorare?\n";
                foreach (DocumentTypeBaseDTO classeDocumentale in listaDocTypes)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.Key, classeDocumentale.Description);
                }
                var classeDocumentoScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var classeDocumento = listaDocTypes.FirstOrDefault(i => i.Key == classeDocumentoScelta);

                //Preparo gli oggetti per le ricerca
                var defaultSearch = searchApi. ...();
                var defaultSelect = searchApi. ...(classeDocumento.Id);

                //Cerco in DOCUMENTTYPE (primo "filtraggio")
                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = 3;
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);

                //Cerco dato uno specifico DOCNUMBER
                messaggio = "Quali profili, da un certo DOCNUMBER in poi, vuoi visualizzare?";
                int docuNumberScelto = Int32.Parse(Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore"));
                var docnumbertypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCNUMBER", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchIntDto)docnumbertypefield).Operator = ...;
                ((FieldBaseForSearchIntDto)docnumbertypefield).Valore1 = docuNumberScelto;

                //Effettuo la ricerca
                var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(..., ...));

                //Preparo il risultato per porlo nel DataTable
                var profiles = new DataTable();
                foreach (var columnSearchResult in values.First().Columns) profiles.Columns.Add(columnSearchResult.Label);
                foreach (var rowSearchResult in values) profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                searchGrid.DataSource = profiles;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Preambolo
                String messaggio;
                var businesUnitApi = new ...(Configuration);
                var searchApi = new ...(Configuration);
                var docTypesApi = new ...(Configuration);

                //Su quale AOO dobbiamo lavorare?
                messaggio = "Su quale AOO vuoi lavorare?\n";
                var listaAOO = businesUnitApi. ...(1, "CODICE");
                foreach (BusinessUnitDTO bu in listaAOO)
                {
                    messaggio += string.Format("{0}: {1}\n", bu.Code, bu.Name, bu);
                }
                var buScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");

                //Mi faccio ritornare la lista degli stati documentali
                var listaDocTypes = docTypesApi. ...(1, buScelta);

                //Chiedo all'utente su quela classe documentale lavorare
                messaggio = "Su quale classe documentale vuoi lavorare?\n";
                foreach (DocumentTypeBaseDTO classeDocumentale in listaDocTypes)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.Key, classeDocumentale.Description);
                }
                var classeDocumentoScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var classeDocumento = listaDocTypes.FirstOrDefault(i => i.Key == classeDocumentoScelta);

                //Preparo gli oggetti per le ricerca
                var defaultSearch = searchApi.SearchesGet();
                var defaultSelect = searchApi.SearchesGetSelect_0(classeDocumento.Id);

                //Cerco in DOCUMENTTYPE (primo "filtraggio")
                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = 3;
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);

                //Cerco una parola contenuta in DOCNAME
                messaggio = "Quale parola vuoi cercare in DOCNAME?";
                String parolaScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var docnametypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCNAME", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchStringDto)docnametypefield).Operator = ...;
                ((FieldBaseForSearchStringDto)docnametypefield).Valore1 = parolaScelta;

                //Effettuo la ricerca
                var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(defaultSearch, defaultSelect));

                //Preparo il risultato per porlo nel DataTable
                var profiles = new DataTable();
                foreach (var columnSearchResult in values.First().Columns) profiles.Columns.Add(columnSearchResult.Label);
                foreach (var rowSearchResult in values) profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                searchGrid.DataSource = profiles;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //Preambolo
                String messaggio;
                var businesUnitApi = new ...(Configuration);
                var searchApi = new ...(Configuration);
                var docTypesApi = new ...(Configuration);

                //Su quale AOO dobbiamo lavorare?
                messaggio = "Su quale AOO vuoi lavorare?\n";
                var listaAOO = businesUnitApi. ...(1, "CODICE");
                foreach (BusinessUnitDTO bu in listaAOO)
                {
                    messaggio += string.Format("{0}: {1}\n", bu.Code, bu.Name, bu);
                }
                var buScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");

                //Mi faccio ritornare la lista degli stati documentali
                var listaDocTypes = docTypesApi.DocumentTypesGet_0(1, buScelta);

                //Chiedo all'utente su quela classe documentale lavorare
                messaggio = "Su quale classe documentale vuoi lavorare?\n";
                foreach (DocumentTypeBaseDTO classeDocumentale in listaDocTypes)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.Key, classeDocumentale.Description);
                }
                var classeDocumentoScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var classeDocumento = listaDocTypes.FirstOrDefault(i => i.Key == classeDocumentoScelta);

                //Preparo gli oggetti per le ricerca
                var defaultSearch = searchApi.SearchesGet();
                var defaultSelect = searchApi.SearchesGetSelect_0(classeDocumento.Id);

                //Cerco in DOCUMENTTYPE (primo "filtraggio")
                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = ...;
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);

                //Mi recupero la lista dei campi aggiuntivi
                var additionals = searchApi. ...(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3, buScelta);

                //Cerco una parola contenuta in DOCNAME
                messaggio = "Quale parola vuoi cercare in StringaProtocollo?";
                String stringaProtocolloScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var campoAggiuntivoStringaProtocollo = additionals.FirstOrDefault(i => i.Description == "StringaProtocollo"); //mi recupero il campo aggiuntivo "StringaProtocollo"
                ((FieldBaseForSearchStringDto)campoAggiuntivoStringaProtocollo).Operator = ...;
                ((FieldBaseForSearchStringDto)campoAggiuntivoStringaProtocollo).Valore1 = stringaProtocolloScelta;
                defaultSearch.Fields.Add(campoAggiuntivoStringaProtocollo);
                defaultSelect.Fields.FirstOrDefault(i => i.Label == "StringaProtocollo").Selected = true;

                //Effettuo la ricerca
                var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(defaultSearch, defaultSelect));

                //Preparo il risultato per porlo nel DataTable
                var profiles = new DataTable();
                foreach (var columnSearchResult in values.First().Columns) profiles.Columns.Add(columnSearchResult.Label);
                foreach (var rowSearchResult in values) profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                searchGrid.DataSource = profiles;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //Preambolo
                String messaggio;
                var businesUnitApi = new ...(Configuration);
                var searchApi = new ...(Configuration);
                var docTypesApi = new ...(Configuration);

                //Su quale AOO dobbiamo lavorare?
                messaggio = "Su quale AOO vuoi lavorare?\n";
                var listaAOO = businesUnitApi.BusinessUnitsGet(1, "CODICE");
                foreach (BusinessUnitDTO bu in listaAOO)
                {
                    messaggio += string.Format("{0}: {1}\n", bu.Code, bu.Name, bu);
                }
                var buScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");

                //Mi faccio ritornare la lista degli stati documentali
                var listaDocTypes = docTypesApi.DocumentTypesGet_0(1, buScelta);

                //Chiedo all'utente su quela classe documentale lavorare
                messaggio = "Su quale classe documentale vuoi lavorare?\n";
                foreach (DocumentTypeBaseDTO classeDocumentale in listaDocTypes)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.Key, classeDocumentale.Description);
                }
                var classeDocumentoScelta = Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore");
                var classeDocumento = listaDocTypes.FirstOrDefault(i => i.Key == classeDocumentoScelta);

                //Preparo gli oggetti per le ricerca
                var defaultSearch = searchApi.SearchesGet();
                var defaultSelect = searchApi.SearchesGetSelect_0(classeDocumento.Id);

                //Cerco in DOCUMENTTYPE (primo "filtraggio")
                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = ...;
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3);

                //Mi recupero la lista dei campi aggiuntivi
                var additionals = searchApi. ...(classeDocumento.DocumentType, classeDocumento.Type2, classeDocumento.Type3, buScelta);

                //Cerco un range di valori per CodiceProtocollo
                messaggio = "Valore minimo per CodiceProtocollo?";
                int valoreMinimo = int.Parse(Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore"));
                messaggio = "Valore massimo per CodiceProtocollo?";
                int valoreMassimo = int.Parse(Interaction.InputBox(messaggio, "Ricerche con le API", "Immetti un valore"));
                var campoAggiuntivoCodiceProtocollo = additionals.FirstOrDefault(i => i.Description == "CodiceProtocollo"); //mi recupero il campo aggiuntivo "StringaProtocollo"
                ((FieldBaseForSearchIntDto)campoAggiuntivoCodiceProtocollo).Operator = ...;
                ((FieldBaseForSearchIntDto)campoAggiuntivoCodiceProtocollo). ... = valoreMinimo;
                ((FieldBaseForSearchIntDto)campoAggiuntivoCodiceProtocollo). ... = valoreMassimo;
                defaultSearch.Fields.Add(campoAggiuntivoCodiceProtocollo);
                defaultSelect.Fields.FirstOrDefault(i => i.Label == "CodiceProtocollo").Selected = true;

                //Effettuo la ricerca
                var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(defaultSearch, defaultSelect));

                //Preparo il risultato per porlo nel DataTable
                var profiles = new DataTable();
                foreach (var columnSearchResult in values.First().Columns) profiles.Columns.Add(columnSearchResult.Label);
                foreach (var rowSearchResult in values) profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                searchGrid.DataSource = profiles;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }
    }
}
