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
                    var predefinedProfileSelected = (PredefinedProfileDTO)datagridComplex.SelectedRows[0].DataBoundItem;
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
                var searchApi = new IO.Swagger.Api.SearchesVApi(Configuration);

                var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGet("search", "AbleBS");
                var classeFatture = docTypes.FirstOrDefault(i => i.Key == "AMM.FATT");

                var defaultSearch = searchApi.SearchesV2Get();
                var defaultSelect = searchApi.SearchesV2GetSelect_0(classeFatture.Id);

                defaultSearch.DocumentTypeField.Valore1 = new DocumentTypeSearchFilterDto(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3);
                defaultSearch.DocumentTypeField._Operator = FieldBaseForSearchDocumentTypeDto.OperatorEnum.Uguale;

                var additionals = searchApi.SearchesV2GetAdditionalByClasse(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3, "AbleBS");
                var codiceFattura = additionals.StringFields.FirstOrDefault(i => i.Description == "Codice Fattura");
                codiceFattura._Operator = FieldBaseForSearchStringDto.OperatorEnum.NonNulloeNonVuoto;

                defaultSearch.StringFields.Add(codiceFattura);
                defaultSelect.Fields.FirstOrDefault(i => i.Label == "Codice Fattura").Selected = true;

                var values = searchApi.SearchesV2PostSearch(new SearchConcreteCriteriaDto(100, SearchConcreteCriteriaDto.DaAAndOrEnum.And, defaultSearch, defaultSelect));
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
            var profileApi = new IO.Swagger.Api.ProfilesVApi(Configuration);

            var aooApi = new IO.Swagger.Api.BusinessUnitsApi(Configuration);
            var aoo = aooApi.BusinessUnitsGet();

            var docTypesApi = new IO.Swagger.Api.DocumentTypesApi(Configuration);
            var doctypes = docTypesApi.DocumentTypesGet("search", aoo.First().Code);


            var fo = new OpenFileDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                var stream = fo.OpenFile();
                var bufferId = bufferApi.BufferInsert(stream);

                var profileDto = profileApi.ProfilesV2Get();
                var classeGneric = doctypes.FirstOrDefault(i => i.Key.Equals("GENERIC", StringComparison.CurrentCultureIgnoreCase));
                profileDto.Fields.DocumentTypeField.Value = classeGneric.Id;
                profileDto.Document = new FileDTO(bufferId);

                var additional = profileApi.ProfilesV2GetAdditionalByClasse(classeGneric.DocumentType, classeGneric.Type2, classeGneric.Type3, "AbleBS");
                profileDto.Fields.AdditionalFieldsBoolean = additional.AdditionalFieldsBoolean;
                profileDto.Fields.AdditionalFieldsClasse = additional.AdditionalFieldsClasse;
                profileDto.Fields.AdditionalFieldsCombo = additional.AdditionalFieldsCombo;
                profileDto.Fields.AdditionalFieldsDateTime = additional.AdditionalFieldsDateTime;
                profileDto.Fields.AdditionalFieldsDouble = additional.AdditionalFieldsDouble;
                profileDto.Fields.AdditionalFieldsInt = additional.AdditionalFieldsInt;
                profileDto.Fields.AdditionalFieldsMultivalue = additional.AdditionalFieldsMultivalue;
                profileDto.Fields.AdditionalFieldsString = additional.AdditionalFieldsString;
                profileDto.Fields.AdditionalFieldsTable = additional.AdditionalFieldsTable;


                profileDto.Fields.SubjectField.Value = "Oggeto nuovo";
                var result = profileApi.ProfilesV2Post(profileDto);
                MessageBox.Show(result.DocNumber.ToString());
            }
        }
    }
}
