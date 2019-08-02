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
using Newtonsoft.Json;
using RestSharp;

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

                    var docTypes = docTypesApi.DocumentTypesGet(1, aooCode);
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
                doctypes = await docTypesApi.DocumentTypesGetAsync(1, aoos.First().Code);
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
                var searchApi = new IO.Swagger.Api.SearchesApi(Configuration);

                var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGet(1, "AbleBS");
                var classeFatture = docTypes.FirstOrDefault(i => i.Key == "AMM.FATT");

                var defaultSearch = searchApi.SearchesGet();
                var defaultSelect = searchApi.SearchesGetSelect_0(classeFatture.Id);

                var doctypefield = defaultSearch.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new DocumentTypeSearchFilterDto(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3);
                ((FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = 3;

                var additionals = searchApi.SearchesGetAdditionalByClasse(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3, "AbleBS");
                var codiceFattura = additionals.FirstOrDefault(i => i.Description == "Codice Fattura");
                ((FieldBaseForSearchStringDto) codiceFattura).Operator = 11; //non nullo e non vuoto;

                defaultSearch.Fields.Add(codiceFattura);
                defaultSelect.Fields.FirstOrDefault(i => i.Label == "Codice Fattura").Selected = true;

                var values = searchApi.SearchesPostSearch(new SearchCriteriaDto(defaultSearch,defaultSelect));
                var profiles = new DataTable();

                foreach (var columnSearchResult in values.First().Columns)
                {
                    profiles.Columns.Add(columnSearchResult.Label);
                }

                foreach (var rowSearchResult in values)
                {
                    profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                }

                searchGrid.DataSource = profiles;
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
                var documentApi = new IO.Swagger.Api.DocumentsApi(Configuration);
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
    

    private void buttonImport_Click(object sender, EventArgs e)
        {
            var bufferApi = new IO.Swagger.Api.BufferApi(Configuration);
            var profileApi = new IO.Swagger.Api.ProfilesApi(Configuration);
            var statesApi = new IO.Swagger.Api.StatesApi(Configuration);

            var aooApi = new IO.Swagger.Api.BusinessUnitsApi(Configuration);
            var aoo = aooApi.BusinessUnitsGet();

            var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
            var doctypes = docTypesApi.DocumentTypesGet(1, aoo.First().Code);


            var fo = new OpenFileDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                var stream = fo.OpenFile();
                var bufferId = bufferApi.BufferInsert(stream);

                var profileDto = profileApi.ProfilesGet_0();
                var classeGneric = doctypes.FirstOrDefault(i => i.Key.Equals("GENERIC", StringComparison.CurrentCultureIgnoreCase));
                var status = statesApi.StatesGet_0();
                ((StateFieldDTO) profileDto.Fields.FirstOrDefault(i => i.Name.Equals("Stato", StringComparison.CurrentCultureIgnoreCase))).Value = status.First().Id;
                ((DocumentTypeFieldDTO) profileDto.Fields.FirstOrDefault(i => i.Name.Equals("DocumentType"))).Value = classeGneric.Id;
                ((OriginFieldDTO) profileDto.Fields.FirstOrDefault(i => i.Name.Equals("Origine", StringComparison.CurrentCultureIgnoreCase))).Value = 0;
                profileDto.Document = new FileDTO(bufferId);

                var additional = profileApi.ProfilesGetAdditionalByClasse(classeGneric.DocumentType, classeGneric.Type2, classeGneric.Type3, "AbleBS");
                profileDto.Fields.AddRange(additional);

                ((SubjectFieldDTO) profileDto.Fields.FirstOrDefault(i => i.Name.Equals("DOCNAME", StringComparison.CurrentCultureIgnoreCase))).Value = "Oggeto nuovo";
                var result = profileApi.ProfilesPost(new ProfileDTO()
                {
                    Fields = profileDto.Fields,
                    Document = new FileDTO(){BufferIds = bufferId},
                    Attachments = new List<string>(),
                    AuthorityData = new AuthorityDataDTO(),
                    Notes = new List<NoteDTO>(),
                    PaNotes = new List<string>(),
                    PostProfilationActions = new List<PostProfilationActionDTO>()
                    
                });

                MessageBox.Show(result.DocNumber.ToString());

            }
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            var wfApi = new IO.Swagger.Api.WorkflowApi(Configuration);
            var documentApi = new IO.Swagger.Api.DocumentsApi(Configuration);

            if (searchGrid.SelectedRows != null && searchGrid.SelectedRows.Count > 0)
            {
                var doc = Convert.ToInt32(searchGrid.SelectedRows[0].Cells["System ID"].Value);
                var manualStartEvents = wfApi.WorkflowGetEventsForManualStarts(new List<int?>() {doc});

                wfGrid.DataSource = manualStartEvents;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var wfApi = new IO.Swagger.Api.WorkflowApi(Configuration);
            var documentApi = new IO.Swagger.Api.DocumentsApi(Configuration);

            if (searchGrid.SelectedRows != null && searchGrid.SelectedRows.Count > 0)
            {
                if (wfGrid.SelectedRows != null && wfGrid.SelectedRows.Count > 0)
                {
                    var doc = Convert.ToInt32(searchGrid.SelectedRows[0].Cells["System ID"].Value);
                    var eventId = ((WorkFlowEventDTO)wfGrid.SelectedRows[0].DataBoundItem).EventId;
                    wfApi.WorkflowWorkflowManualStart(doc, eventId);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var taskApi = new IO.Swagger.Api.TaskWorkApi(Configuration);
            var select = taskApi.TaskWorkGetDefaultSelect();
            var tasks = taskApi.TaskWorkGetTasks(new TaskWorkRequestDTO(select));

            var tasksTable = new DataTable();

            foreach (var columnSearchResult in tasks.First().Columns)
            {
                tasksTable.Columns.Add(columnSearchResult.Id);
            }

            foreach (var rowSearchResult in tasks)
            {
                tasksTable.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
            }

            wfGrid.DataSource = tasksTable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var taskApi = new IO.Swagger.Api.TaskWorkApi(Configuration);
                if (wfGrid.SelectedRows != null && wfGrid.SelectedRows.Count > 0)
                {
                    var exitcodes = taskApi.TaskWorkGetExitCodesByTaskWorkIds(new List<int?>() { Convert.ToInt32(wfGrid.SelectedRows[0].Cells["ID"].Value.ToString())});
                    wfGrid.DataSource = exitcodes;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updprofbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var profilesApi = new IO.Swagger.Api.ProfilesApi(Configuration);
                var profile = profilesApi.ProfilesGetSchema(48, true);

                //Update a standard field of the profile

                var oggetto = profile.Fields.FirstOrDefault(i => i.Name.Equals("DOCNAME", StringComparison.CurrentCultureIgnoreCase));
                ((SubjectFieldDTO) oggetto).Value = "Update from API call (DEV EXAMPLE)";

                //Update a additional field of the profile

                var numerofattura = profile.Fields.FirstOrDefault(i => i.ExternalId!= null && i.ExternalId.Equals("CodFatt", StringComparison.CurrentCultureIgnoreCase));
                ((AdditionalFieldStringDTO)numerofattura).Value = "CodFatt value (DEV EXAMPLE)";

                var profileToUpdate = new ProfileDTO();
                profileToUpdate.Fields = profile.Fields;
                profilesApi.ProfilesPut(48, profileToUpdate);

                MessageBox.Show("Profile Updated");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var searchV2Api = new IO.Swagger.Api.SearchesV2Api(Configuration);
                
                var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGet(1, "AbleBS");
                var classeFatture = docTypes.FirstOrDefault(i => i.Key == "AMM.FATT");
                var classeBolle = docTypes.FirstOrDefault(i => i.Key == "AMM.BOL");

                //Get search for the first documentType
                var searchFatture = searchV2Api.SearchesV2GetEmpty();
                var doctypefieldFatture = searchFatture.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefieldFatture).Valore1 = new DocumentTypeSearchFilterDto(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3);
                ((FieldBaseForSearchDocumentTypeDto)doctypefieldFatture).Operator = 3;

                //Get search for the second documenttype
                var searchBolle = searchV2Api.SearchesV2GetEmpty();
                var doctypefieldBolle = searchBolle.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((FieldBaseForSearchDocumentTypeDto)doctypefieldBolle).Valore1 = new DocumentTypeSearchFilterDto(classeBolle.DocumentType, classeBolle.Type2, classeBolle.Type3);
                ((FieldBaseForSearchDocumentTypeDto)doctypefieldBolle).Operator = 3;


                var baseSelect = searchV2Api.SearchesV2GetSelect_0(classeFatture.Id);
                
                var additionalsFatture = searchV2Api.SearchesV2GetAdditionalByClasse(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3, "AbleBS");
                var codiceFattura = additionalsFatture.FirstOrDefault(i => i.Description == "Codice Fattura");
                ((FieldBaseForSearchStringDto)codiceFattura).Operator = 11; //non nullo e non vuoto;

                searchFatture.Fields.Add(codiceFattura);
                baseSelect.Fields.FirstOrDefault(i => i.Label == "Codice Fattura").Selected = true;
                baseSelect.Fields
                    .FirstOrDefault(i => i.Name.Equals("CLASSEDOCDESC", StringComparison.CurrentCultureIgnoreCase))
                    .Selected = true;
                baseSelect.MaxItems = 0;

                var values = searchV2Api.SearchesV2PostSearchMultiple(new SearchCriteriaMultipleDto()
                {
                    SearchFilterDtoList = new List<SearchDTO>() {searchFatture, searchBolle},
                    SelectFilterDto = baseSelect
                });

                var profiles = new DataTable();

                foreach (var columnSearchResult in values.First().Columns)
                {
                    profiles.Columns.Add(columnSearchResult.Label);
                }

                foreach (var rowSearchResult in values)
                {
                    profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                }

                searchGrid.DataSource = profiles;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient();
                client.BaseUrl = new Uri(_apiUrl);

                var request = new RestRequest();
                request.Method = Method.GET;
                request.Resource = "/api/BusinessUnits";
                request.AddQueryParameter("criteria.mode", "0");
                request.AddQueryParameter("criteria.orderBy", "");

                request.AddHeader("Authorization", "Bearer " + _authToken);

                var result = client.ExecuteAsGet(request, "GET");
                var aoos = JsonConvert.DeserializeObject(result.Content, typeof(List<Aoo>), new JsonSerializerSettings());
                
                aooTable.DataSource = aoos;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        internal class Aoo
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }
    }
}
