using ClassLibraryWebServiceConnect.Enums;
using ClassLibraryWebServiceConnect.Models;
using ClassLibraryWebServiceConnect.Operations;
using System.Collections.Generic;
using System.Data;
using WinFormsAppTrazoRegistrosAdmin.Excel;

namespace WinFormsAppTrazoRegistrosAdmin
{
    public partial class ReportStoreUserControl : UserControl
    {
        private EventHandler<(bool, string)> _RaiseRichTextInsertNewMessage;

        private WebServiceOperation _webserviceOperations;
        private List<Store> _storeList;
        private List<Supervisor> _supervisorList;
        private List<Status> _statusList;
        private List<StatusReport> _statusReportList;

        public ReportStoreUserControl(WebServiceOperation webserviceOperations,
            List<Store> storeList, List<Supervisor> supervisorList, List<Status> statusList,
            List<StatusReport> statusReportList, UserPermit _activePermissionSection,
            EventHandler<(bool, string)> RaiseRichTextInsertNewMessage)
        {
            InitializeComponent();

            _webserviceOperations = webserviceOperations;
            _storeList = storeList;
            _supervisorList = supervisorList;
            _statusList = statusList;
            _statusReportList = statusReportList;
            _RaiseRichTextInsertNewMessage = RaiseRichTextInsertNewMessage;

            LoadStore();
            LoadComboBoxStatus();
            LoadComboBoxSupervisors();

            ApplyPermissions(_activePermissionSection);
        }
        private void LoadStore()
        {
            listBoxStoreCodes.DataSource = null;
            listBoxStoreCodes.DisplayMember = "sto_code";
            listBoxStoreCodes.ValueMember = "sto_id";
            listBoxStoreCodes.DataSource = _storeList.Where(x => x.sto_id != (int)MagickInfo.STORE.ZERO).Select(x => x).ToList();
        }

        private void LoadComboBoxStatus()
        {
            var listStatus = new List<Status>(_statusList);
            listStatus.Add(new Status { sta_id = 0, sta_description = "TODOS" });
            var lastItem = listStatus[listStatus.Count - 1];
            listStatus[listStatus.Count - 1] = listStatus[0];
            listStatus[0] = lastItem;

            comboBoxStatus.DataSource = null;
            comboBoxStatus.DataSource = listStatus;
            comboBoxStatus.ValueMember = "sta_id";
            comboBoxStatus.DisplayMember = "sta_description";
            if (comboBoxStatus.Items.Count > 0)
            {
                comboBoxStatus.SelectedIndex = 0;
            }
            else
            {
                comboBoxStatus.SelectedIndex = -1;
            }
        }

        private void LoadComboBoxSupervisors()
        {
            var listSupervisor = new List<Supervisor>(_supervisorList);
            listSupervisor.RemoveAll(x => x.sup_id == (int)MagickInfo.SUPERVISOR.ADMINISTRADOR);
            listSupervisor.Add(new Supervisor { sup_id = 0, sup_description = "TODOS" });
            var lastItem = listSupervisor[listSupervisor.Count - 1];
            listSupervisor[listSupervisor.Count - 1] = listSupervisor[0];
            listSupervisor[0] = lastItem;

            comboBoxSupervisor.DataSource = null;
            comboBoxSupervisor.DataSource = listSupervisor;
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

        private string GetIdsOfStoresSelected()
        {
            string ids = string.Empty;

            foreach (var item in listBoxStoreCodes.SelectedItems)
            {
                ids += ((Store)item).sto_id.ToString() + ',';
            }

            return ids.TrimEnd(',');
        }

        private void checkBoxSelectUnselect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectUnselect.Checked)
            {
                for (int val = 0; val < listBoxStoreCodes.Items.Count; val++)
                {
                    listBoxStoreCodes.SetSelected(val, true);
                }
            }
            else
            {
                for (int val = 0; val < listBoxStoreCodes.Items.Count; val++)
                {
                    listBoxStoreCodes.SetSelected(val, false);
                }
            }
        }

        private async void buttonStoreReportConsult_Click(object sender, EventArgs e)
        {
            Block();

            if (ValidationConsult() == false)
            {
                UnBlock();
                return;
            }

            var result = await _webserviceOperations.StoreReportFiltered(new StoreFilter
            {
                p_storep_sto_id = GetIdsOfStoresSelected(),
                p_storep_date_ini = dateTimePickerInit.Value,
                p_storep_date_end = dateTimePickerFinal.Value,
                p_storep_total_bs = Decimal.Parse(textBoxTotalFacturado.Text),
                p_storep_change_bs = Decimal.Parse(textBoxCambio.Text),
                p_storep_equivalent_dollar = Decimal.Parse(textBoxEquivalente.Text),
                p_storep_payed_euro = Decimal.Parse(textBoxEuros.Text),
                p_storep_payed_zelle = Decimal.Parse(textBoxZelle.Text),
                p_storep_payed_dollar = Decimal.Parse(textBoxDolar.Text),
                p_storep_expended_dollar = Decimal.Parse(textBoxGastos.Text),
                p_storep_total_dollar = Decimal.Parse(textBoxResta.Text),
                p_storep_sta_id = ((Status)comboBoxStatus.SelectedItem).sta_id,
                p_storep_sup_id = ((Supervisor)comboBoxSupervisor.SelectedItem).sup_id
            });

            _RaiseRichTextInsertNewMessage(this, new(result.Item1, result.Item2));

            if (result.Item1)
            {
                LoadStoreReport(result.Item3);
                CalculateTotales();
            }

            UnBlock();
        }

        private void Block()
        {
            buttonStoreReportConsult.Enabled = false;
            buttonStoreReportClean.Enabled = false;
            buttonExportToExcel.Enabled = false;
            dateTimePickerInit.Enabled = false;
            dateTimePickerFinal.Enabled = false;
            textBoxTotalFacturado.Enabled = false;
            textBoxCambio.Enabled = false;
            textBoxEquivalente.Enabled = false;
            textBoxEuros.Enabled = false;
            textBoxZelle.Enabled = false;
            textBoxDolar.Enabled = false;
            textBoxGastos.Enabled = false;
            textBoxResta.Enabled = false;
            comboBoxStatus.Enabled = false;
            comboBoxSupervisor.Enabled = false;
        }

        private void UnBlock()
        {
            buttonStoreReportConsult.Enabled = true;
            buttonStoreReportClean.Enabled = true;
            buttonExportToExcel.Enabled = true;
            dateTimePickerInit.Enabled = true;
            dateTimePickerFinal.Enabled = true;
            textBoxTotalFacturado.Enabled = true;
            textBoxCambio.Enabled = true;
            textBoxEquivalente.Enabled = true;
            textBoxEuros.Enabled = true;
            textBoxZelle.Enabled = true;
            textBoxDolar.Enabled = true;
            textBoxGastos.Enabled = true;
            textBoxResta.Enabled = true;
            comboBoxStatus.Enabled = true;
            comboBoxSupervisor.Enabled = true;
        }


        private bool ValidationConsult()
        {
            if (listBoxStoreCodes.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error debe seleccionar una Tienda."));
                return false;
            }

            if (comboBoxStatus.SelectedIndex == -1)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error debe seleccionar un Estatus."));
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

            decimal totalFacturado = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out totalFacturado) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Total Facturado Bs formato invalido."));
                return false;
            }

            decimal cambio = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out cambio) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Cambio Bs formato invalido."));
                return false;
            }

            decimal equivalente = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out equivalente) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Equivalente $ formato invalido."));
                return false;
            }

            decimal euros = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out euros) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Euros formato invalido."));
                return false;
            }

            decimal zelle = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out zelle) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Zelle formato invalido."));
                return false;
            }

            decimal dolar = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out dolar) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Dolar $ formato invalido."));
                return false;
            }

            decimal gastos = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out gastos) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Gastos formato invalido."));
                return false;
            }

            decimal resta = 0;

            if (Decimal.TryParse(textBoxTotalFacturado.Text, out resta) == false)
            {
                _RaiseRichTextInsertNewMessage(this, new(false, "Error Resta $ formato invalido."));
                return false;
            }

            return true;
        }

        private void LoadStoreReport(List<StoreReport> output)
        {
            var reports = GetStoreReport(output);

            var comboboxStatus = (DataGridViewComboBoxColumn)dataGridViewStoreReport.Columns["dgvEditStoreReportColumnStatus"];
            comboboxStatus.DisplayMember = "sta_description";
            comboboxStatus.ValueMember = "sta_id";
            comboboxStatus.DataSource = _statusList;

            var comboboxStatusReport = (DataGridViewComboBoxColumn)dataGridViewStoreReport.Columns["dgvEditStoreReportColumnEstatusProcesado"];
            comboboxStatusReport.DisplayMember = "starep_description";
            comboboxStatusReport.ValueMember = "starep_id";
            comboboxStatusReport.DataSource = _statusReportList;

            dataGridViewStoreReport.DataSource = reports;
        }

        private List<ModelEditStoreReport> GetStoreReport(List<StoreReport> output)
        {
            try
            {
                var list = new List<ModelEditStoreReport>();

                foreach (var items in output)
                {
                    list.Add(new ModelEditStoreReport
                    {
                        storep_selection = false,
                        storep_id = items.storep_id,
                        storep_code = _storeList.Where(x => x.sto_id == items.storep_sto_id).Select(x => x.sto_code).FirstOrDefault(),
                        storep_date = items.storep_date.Date,
                        storep_total_bs = items.storep_total_bs,
                        storep_change_bs = items.storep_change_bs,
                        storep_rate = items.storep_rate,
                        storep_equivalent_dollar = items.storep_equivalent_dollar,
                        storep_payed_euro = items.storep_payed_euro,
                        storep_payed_zelle = items.storep_payed_zelle,
                        storep_payed_dollar = items.storep_payed_dollar,
                        storep_expended_dollar = items.storep_expended_dollar,
                        storep_total_dollar = items.storep_total_dollar,
                        storep_sta_id = items.storep_sta_id,
                        storep_supervisor = this._supervisorList.Where(s => s.sup_id == items.storep_sup_id).Select(g => g.sup_description).FirstOrDefault(),
                        storep_comments = items.storep_comments == null ? string.Empty : items.storep_comments,
                        storep_starep_id = items.storep_starep_id
                    });
                }

                return list;
            }
            catch (Exception ex)
            {
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(false, "Excepcion: " + ex.Message.ToLower() + " .Funcion: GetEditStoreReport()"));
                return new List<ModelEditStoreReport>();
            }
        }

        private bool flagCommentSize = false;
        private void dataGridViewStoreReport_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 15 && flagCommentSize == false)
            {
                dataGridViewStoreReport.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                flagCommentSize = true;
            }
            else if (e.ColumnIndex == 15)
            {
                dataGridViewStoreReport.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dataGridViewStoreReport.Columns[15].Width = 200;
                flagCommentSize = false;
            }
        }

        private void buttonStoreReportClean_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreReport.DataSource != null && dataGridViewStoreReport.Rows.Count > 0)
            {
                dataGridViewStoreReport.DataSource = new List<ModelEditStoreReport>();
                dataGridViewStoreReport.Refresh();
                CalculateTotales();
            }
        }

        private void CalculateTotales()
        {
            if (dataGridViewStoreReport.DataSource == null || dataGridViewStoreReport.Rows.Count <= 0)
            {
                labelStoreTotalFacturado.Text = "0";
                labelStoreCambioBs.Text = "0";
                labelStoreEquivalente.Text = "0";
                labelStoreEuros.Text = "0";
                labelStoreZelle.Text = "0";
                labelStoreDolares.Text = "0";
                labelStoreGastos.Text = "0";
                labelStoreRestaEfectivo.Text = "0";

                return;
            }

            decimal totalFacturado = 0;
            decimal cambioBs = 0;
            decimal equivalente = 0;
            decimal euros = 0;
            decimal zelle = 0;
            decimal dolares = 0;
            decimal gastos = 0;
            decimal restaEfectivo = 0;

            foreach (var item in (List<ModelEditStoreReport>)dataGridViewStoreReport.DataSource)
            {
                totalFacturado += item.storep_total_bs;
                cambioBs += item.storep_change_bs;
                equivalente += item.storep_equivalent_dollar;
                euros += item.storep_payed_euro;
                zelle += item.storep_payed_zelle;
                dolares += item.storep_payed_dollar;
                gastos += item.storep_expended_dollar;
                restaEfectivo += item.storep_total_dollar;
            }

            labelStoreTotalFacturado.Text = totalFacturado.ToString("N2");
            labelStoreCambioBs.Text = cambioBs.ToString("N2");
            labelStoreEquivalente.Text = equivalente.ToString("N2");
            labelStoreEuros.Text = euros.ToString("N2");
            labelStoreZelle.Text = zelle.ToString("N2");
            labelStoreDolares.Text = dolares.ToString("N2");
            labelStoreGastos.Text = gastos.ToString("N2");
            labelStoreRestaEfectivo.Text = restaEfectivo.ToString("N2");
        }

        private async void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            Block();

            if (dataGridViewStoreReport.DataSource == null || dataGridViewStoreReport.Rows.Count <= 0)
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
                var listExcelDTO = ((List<ModelEditStoreReport>)dataGridViewStoreReport.DataSource).Select(x => new ExcelReportStoreDTO
                {
                    storep_code = x.storep_code,
                    storep_date = x.storep_date,
                    storep_total_bs = x.storep_total_bs,
                    storep_change_bs = x.storep_change_bs,
                    storep_rate = x.storep_rate,
                    storep_equivalent_dollar = x.storep_equivalent_dollar,
                    storep_payed_euro = x.storep_payed_euro,
                    storep_payed_zelle = x.storep_payed_zelle,
                    storep_payed_dollar = x.storep_payed_dollar,
                    storep_expended_dollar = x.storep_expended_dollar,
                    storep_total_dollar = x.storep_total_dollar,
                    storep_sta_description = _statusList.Where(s => s.sta_id == x.storep_sta_id).Select(d => d.sta_description).FirstOrDefault(),
                    storep_supervisor = x.storep_supervisor,
                    storep_comments = x.storep_comments == null ? string.Empty : x.storep_comments,
                    storep_starep_description = _statusReportList.Where(s => s.starep_id == x.storep_starep_id).Select(d => d.starep_description).FirstOrDefault(),
                }).ToList();

                var result = await ManageExcel.CreateReportStore(listExcelDTO, GetTotalesExcel(listExcelDTO), saveFileDialog.FileName);
                _RaiseRichTextInsertNewMessage?.Invoke(this, new(result.Item1, result.Item2));
            }

            UnBlock();
        }

        private ExcelReportStoreTotalDTO GetTotalesExcel(List<ExcelReportStoreDTO> listExcelDTO)
        {
            ExcelReportStoreTotalDTO itemTotal = new ExcelReportStoreTotalDTO();
            foreach (var item in listExcelDTO)
            {
                itemTotal.total_storep_total_bs += item.storep_total_bs;
                itemTotal.total_storep_change_bs += item.storep_change_bs;
                itemTotal.total_storep_equivalent_dollar += item.storep_equivalent_dollar;
                itemTotal.total_storep_payed_euro += item.storep_payed_euro;
                itemTotal.total_storep_payed_zelle += item.storep_payed_zelle;
                itemTotal.total_storep_payed_dollar += item.storep_payed_dollar;
                itemTotal.total_storep_expended_dollar += item.storep_expended_dollar;
                itemTotal.total_storep_total_dollar += item.storep_total_dollar;
            }

            return itemTotal;
        }
    }
}
