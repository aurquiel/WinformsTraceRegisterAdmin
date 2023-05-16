using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Data;
using WinFormsAppTrazoRegistrosAdmin.Excel;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class ReportSupervisorUserControl : UserControl
    {
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;

        private WebServiceOperation _webserviceOperations;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private List<StatusReport> _statusReportList;

        public ReportSupervisorUserControl(WebServiceOperation webserviceOperations,
            List<Store> storeList, List<Supervisor> supervisorList,
            List<StatusReport> statusReportList, UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage)
        {
            InitializeComponent();

            _webserviceOperations = webserviceOperations;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _statusReportList = statusReportList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;

            LoadComboBoxSupervisor();

            ApplyPermissions(_activePermissionSection);
        }

        private void LoadComboBoxSupervisor()
        {
            comboBoxSupervisor.DataSource = null;
            comboBoxSupervisor.DataSource = _supervisorList;
            comboBoxSupervisor.ValueMember = "sup_id";
            comboBoxSupervisor.DisplayMember = "sup_description";
            if (comboBoxSupervisor.Items.Count > 0)
            {
                comboBoxSupervisor.SelectedIndex = 0;
            }
            else
            {
                comboBoxSupervisor.SelectedIndex = -1;
            }
        }

        private void ApplyPermissions(UserPermit activePermissionSection)
        {
            if (activePermissionSection.upm_update == false)
            {

            }

            if (activePermissionSection.upm_delete == false)
            {

            }

            if (activePermissionSection.upm_insert == false)
            {

            }

            _RaiseRichTextInsertNewMessage?.Invoke(this, new(true, "Permisos de Usuario aplicados."));
        }

        private async void buttonSupervisorReportConsult_Click(object sender, EventArgs e)
        {
            Block();

            if (ValidationConsult() == false)
            {
                UnBlock();
                return;
            }

            var result = await _webserviceOperations.SupervisorReportFiltered(new SupervisorFilter
            {
                p_suprep_sup_id = ((Supervisor)comboBoxSupervisor.SelectedItem).sup_id,
                p_suprep_date_ini = dateTimePickerInit.Value,
                p_suprep_date_end = dateTimePickerFinal.Value,
                p_suprep_in_dollar = Decimal.Parse(textBoxDolarIn.Text),
                p_suprep_out_dollar = Decimal.Parse(textBoxDolarOut.Text),
                p_suprep_in_euro = Decimal.Parse(textBoxEuroIn.Text),
                p_suprep_out_euro = Decimal.Parse(textBoxEuroOut.Text),
                p_suprep_in_peso = Decimal.Parse(textBoxPesoIn.Text),
                p_suprep_out_peso = Decimal.Parse(textBoxPesoOut.Text)

            });

            _RaiseRichTextInsertNewMessage(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                LoadSupervisorReport(result.Item3);
                CalculateTotales();
            }

            UnBlock();
        }

        private void Block()
        {
            buttonSupervisorReportConsult.Enabled = false;
            buttonSupervisorReportClean.Enabled = false;
            buttonExportToExcel.Enabled = false;
            dateTimePickerInit.Enabled = false;
            dateTimePickerFinal.Enabled = false;
            textBoxDolarIn.Enabled = false;
            textBoxDolarOut.Enabled = false;
            textBoxEuroIn.Enabled = false;
            textBoxEuroOut.Enabled = false;
            textBoxPesoIn.Enabled = false;
            textBoxPesoOut.Enabled = false;
        }

        private void UnBlock()
        {
            buttonSupervisorReportConsult.Enabled = true;
            buttonSupervisorReportClean.Enabled = true;
            buttonExportToExcel.Enabled = true;
            dateTimePickerInit.Enabled = true;
            dateTimePickerFinal.Enabled = true;
            textBoxDolarIn.Enabled = true;
            textBoxDolarOut.Enabled = true;
            textBoxEuroIn.Enabled = true;
            textBoxEuroOut.Enabled = true;
            textBoxPesoIn.Enabled = true;
            textBoxPesoOut.Enabled = true;
        }


        private bool ValidationConsult()
        {
            if (comboBoxSupervisor.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error debe seleccionar un Supervisor."));
                return false;
            }

            if (dateTimePickerInit.Value.Date > dateTimePickerFinal.Value.Date)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Fecha de Inicio mayor a Fecha Final."));
                return false;
            }

            if (dateTimePickerFinal.Value.Date < dateTimePickerInit.Value.Date)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Fecha de Final menor a Fecha Inicio."));
                return false;
            }

            decimal dolarIn = 0;

            if (Decimal.TryParse(textBoxDolarIn.Text, out dolarIn) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Dolar In formato invalido."));
                return false;
            }

            decimal dolarOut = 0;

            if (Decimal.TryParse(textBoxDolarOut.Text, out dolarOut) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Dolar Out formato invalido."));
                return false;
            }

            decimal euroIn = 0;

            if (Decimal.TryParse(textBoxEuroIn.Text, out euroIn) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Euro In formato invalido."));
                return false;
            }

            decimal euroOut = 0;

            if (Decimal.TryParse(textBoxEuroOut.Text, out euroOut) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Euro Out formato invalido."));
                return false;
            }

            decimal pesoIn = 0;

            if (Decimal.TryParse(textBoxPesoIn.Text, out pesoIn) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Peso In formato invalido."));
                return false;
            }

            decimal pesoOut = 0;

            if (Decimal.TryParse(textBoxPesoOut.Text, out pesoOut) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Peso Out formato invalido."));
                return false;
            }

            return true;
        }

        private void LoadSupervisorReport(List<SupervisorReport> output)
        {
            var reports = GetSupervisorReport(output);

            var comboboxStatus = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportEdit.Columns["dgvEditSupervisorReportColumnStore"];
            comboboxStatus.DisplayMember = "sto_code";
            comboboxStatus.ValueMember = "sto_id";
            comboboxStatus.DataSource = _storeList;

            var comboboxStatusReport = (DataGridViewComboBoxColumn)dataGridViewSupervisorReportEdit.Columns["dgvEditSupervisorReportColumnProcesado"];
            comboboxStatusReport.DisplayMember = "starep_description";
            comboboxStatusReport.ValueMember = "starep_id";
            comboboxStatusReport.DataSource = _statusReportList;

            dataGridViewSupervisorReportEdit.DataSource = reports;
        }

        private List<ModelEditSupervisorReport> GetSupervisorReport(List<SupervisorReport> output)
        {
            try
            {
                var list = new List<ModelEditSupervisorReport>();

                foreach (var item in output)
                {
                    list.Add(new ModelEditSupervisorReport
                    {
                        suprep_selection = false,
                        suprep_id = item.suprep_id,
                        suprep_date = item.suprep_date,
                        suprep_sup_description = this._supervisorList.Where(s => s.sup_id == item.suprep_sup_id).Select(d => d.sup_description).FirstOrDefault(),
                        suprep_sto_id = item.suprep_sto_id,
                        suprep_in_dollar = item.suprep_in_dollar,
                        suprep_out_dollar = item.suprep_out_dollar,
                        suprep_in_euro = item.suprep_in_euro,
                        suprep_out_euro = item.suprep_out_euro,
                        suprep_in_peso = item.suprep_in_peso,
                        suprep_out_peso = item.suprep_out_peso,
                        suprep_comments = item.suprep_comments == null ? string.Empty : item.suprep_comments,
                        suprep_starep_id = item.suprep_starep_id
                    });
                }

                return list;
            }
            catch (Exception ex)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Excepcion: " + ex.Message.ToLower() + " .Funcion: GetSupervisorReport()"));
                return new List<ModelEditSupervisorReport>();
            }
        }

        private void CalculateTotales()
        {
            if (dataGridViewSupervisorReportEdit.DataSource == null || dataGridViewSupervisorReportEdit.Rows.Count <= 0)
            {
                labelSupervisorInDolares.Text = "0";
                labelSupervisorOutDolares.Text = "0";
                labelSupervisorDifferenceDolar.Text = "0";

                labelSupervisorInEuros.Text = "0";
                labelSupervisorOutEuros.Text = "0";
                labelSupervisorDifferenceEuros.Text = "0";

                labelSupervisorInPesos.Text = "0";
                labelSupervisorOutPesos.Text = "0";
                labelSupervisorDifferencePesos.Text = "0";

                return;
            }

            decimal inDolar = 0;
            decimal outDolar = 0;
            decimal differenceDolar = 0;

            decimal inEuro = 0;
            decimal outEuro = 0;
            decimal differenceEuro = 0;

            decimal inPeso = 0;
            decimal outPeso = 0;
            decimal differencePeso = 0;

            foreach (var item in (List<ModelEditSupervisorReport>)dataGridViewSupervisorReportEdit.DataSource)
            {
                inDolar += item.suprep_in_dollar;
                outDolar += item.suprep_out_dollar;

                inEuro += item.suprep_in_euro;
                outEuro += item.suprep_out_euro;

                inPeso += item.suprep_in_peso;
                outPeso += item.suprep_out_peso;
            }

            differenceDolar = inDolar - outDolar;
            differenceEuro = inEuro - outEuro;
            differencePeso = inPeso - outPeso;

            labelSupervisorInDolares.Text = inDolar.ToString("N2");
            labelSupervisorOutDolares.Text = outDolar.ToString("N2");
            labelSupervisorDifferenceDolar.Text = differenceDolar.ToString("N2");

            labelSupervisorInEuros.Text = inEuro.ToString("N2");
            labelSupervisorOutEuros.Text = outEuro.ToString();
            labelSupervisorDifferenceEuros.Text = differenceEuro.ToString("N2");

            labelSupervisorInPesos.Text = inPeso.ToString("N2");
            labelSupervisorOutPesos.Text = outPeso.ToString("N2");
            labelSupervisorDifferencePesos.Text = differencePeso.ToString("N2");
        }

        private void decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 45))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

            if (e.KeyChar == 45)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void buttonSupervisorReportClean_Click(object sender, EventArgs e)
        {
            dataGridViewSupervisorReportEdit.DataSource = new List<ModelEditSupervisorReport>();
        }

        private async void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            Block();

            if (dataGridViewSupervisorReportEdit.DataSource == null || dataGridViewSupervisorReportEdit.Rows.Count <= 0)
            {
                UnBlock();
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Title = "Save XLSX File";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "XLSX";
            saveFileDialog.Filter = "XLSX files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var listExcelDTO = ((List<ModelEditSupervisorReport>)dataGridViewSupervisorReportEdit.DataSource).Select(x => new ExcelReportSupervisorDTO
                {
                    suprep_sup_description = x.suprep_sup_description,
                    suprep_date = x.suprep_date,
                    suprep_sto_code = _storeList.Where(d => d.sto_id == x.suprep_sto_id).Select(h => h.sto_code).FirstOrDefault(),
                    suprep_in_dollar = x.suprep_in_dollar,
                    suprep_out_dollar = x.suprep_out_dollar,
                    suprep_in_euro = x.suprep_in_euro,
                    suprep_out_euro = x.suprep_out_euro,
                    suprep_in_peso = x.suprep_in_peso,
                    suprep_out_peso = x.suprep_out_peso,
                    suprep_comments = x.suprep_comments == null ? string.Empty : x.suprep_comments,
                    suprep_starep_description = _statusReportList.Where(s => s.starep_id == x.suprep_starep_id).Select(d => d.starep_description).FirstOrDefault(),
                }).ToList();

                var result = await ManageExcel.CreateReportSupervisor(listExcelDTO, GetTotalesExcel(listExcelDTO), saveFileDialog.FileName);

                _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));
            }

            UnBlock();
        }

        private ExcelReportSupervisorTotalDTO GetTotalesExcel(List<ExcelReportSupervisorDTO> listExcelDTO)
        {
            ExcelReportSupervisorTotalDTO itemTotal = new ExcelReportSupervisorTotalDTO();
            foreach (var item in listExcelDTO)
            {
                itemTotal.total_suprep_in_dollar += item.suprep_in_dollar;
                itemTotal.total_suprep_out_dollar += item.suprep_out_dollar;
                itemTotal.total_suprep_in_euro += item.suprep_in_euro;
                itemTotal.total_suprep_out_euro += item.suprep_out_euro;
                itemTotal.total_suprep_in_peso += item.suprep_in_peso;
                itemTotal.total_suprep_out_peso += item.suprep_out_peso;
            }

            return itemTotal;
        }

        private bool flagCommentSize = false;
        private void dataGridViewSupervisorReportEdit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 11 && flagCommentSize == false)
            {
                dataGridViewSupervisorReportEdit.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                flagCommentSize = true;
            }
            else if (e.ColumnIndex == 11)
            {
                dataGridViewSupervisorReportEdit.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dataGridViewSupervisorReportEdit.Columns[11].Width = 200;
                flagCommentSize = false;
            }
        }
    }

}
