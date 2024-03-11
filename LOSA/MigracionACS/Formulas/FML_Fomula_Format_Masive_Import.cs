using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.IO;
using System.Diagnostics;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Fomula_Format_Masive_Import : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables

        DataTable data = new DataTable();
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string directoryPath;

        int selectedRecord;
        string selectedPath;

        DataOperations dp = new DataOperations();

        #endregion

        #region Developer Defined Methods

        private string generate_file_name(string path, bool isfileName)
        {
            StreamReader reader = File.OpenText(path);
            string localname = string.Empty;

            string lineText = string.Empty;
            int lineCount = 1;

            while ((lineText = reader.ReadLine()) != null)
            {
                byte[] stringBytes = Encoding.Default.GetBytes(lineText);
                lineText = Encoding.ASCII.GetString(stringBytes);

                if (lineCount <= 14)
                {
                    if (lineCount == 8 && lineText.Length >= 57) 
                    {
                        if (isfileName)
                            localname = string.Format("{0} - {1}", lineText.Substring(5, 15).Trim(), lineText.Substring(18, 39).Trim());
                        else
                            localname = lineText.Substring(18, 39).Trim();
                        break;
                    }
                }
                else
                {
                    break;
                }

                lineCount++;
            }

            reader.Close();
            return localname;
        }

        #endregion

        #region Contructors

        public FML_Fomula_Format_Masive_Import()
        {
            InitializeComponent();
        }

        public FML_Fomula_Format_Masive_Import(string ActiveUserCode, string ActiveUserName, string ActiveUserType, DataTable formulas, string directoryPath)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.data = formulas;
            this.directoryPath = directoryPath;
        }
        #endregion

        private void FML_Fomula_Format_Masive_Import_Load(object sender, EventArgs e)
        {
            try
            {
                grd_Data.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void grdv_Data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void btn_Verify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in data.Rows) 
                {
                    if (!string.IsNullOrWhiteSpace(row["FileLName"].ToString()))
                    {
                        row["OnError"] = false;
                    }
                    else 
                    {
                        row["OnError"] = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_Verify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Verify_ItemClick(sender, e);
        }

        private void btn_ExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grdv_Data.ExportToXlsx(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_ExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_ExportExcel_ItemClick(sender, e);
        }

        private void grdv_Data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedRecord = int.Parse(grdv_Data.GetDataRow(e.FocusedRowHandle)["Record"].ToString());
                selectedPath = grdv_Data.GetDataRow(e.FocusedRowHandle)["FilePath"].ToString();
            }
            catch
            {

            }
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in data.Rows) 
                {
                    if (row["Record"].ToString() == selectedRecord.ToString())
                    {
                        row.Delete();
                        data.AcceptChanges();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Delete_ItemClick(sender, e);
        }

        private void btn_Accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DateTime current_date = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));
                DateTime available_date = Convert.ToDateTime(dt_desde.EditValue);
                DateTime due_date = Convert.ToDateTime(dt_hasta.EditValue);
                if (Convert.ToDateTime(available_date.ToShortDateString()) >= Convert.ToDateTime(current_date.ToShortDateString())) 
                {
                    if (Convert.ToDateTime(available_date.ToShortDateString()) < Convert.ToDateTime(due_date.ToShortDateString()))
                    {
                        bool allOK = true;

                        foreach (DataRow row in data.Rows)
                        {
                            if (Convert.ToBoolean(row["OnError"])) 
                            {
                                allOK = false;
                            }
                        }

                        if (allOK) 
                        {
                            foreach (DataRow row in data.Rows)
                            {
                                FML_Formula_Format_Import_Interface form = new FML_Formula_Format_Import_Interface(ActiveUserCode, ActiveUserName, ActiveUserType, true, row["FilePath"].ToString(), row["FileName"].ToString(), row["FileLName"].ToString(), Convert.ToDateTime(dt_desde.EditValue), Convert.ToDateTime(dt_hasta.EditValue));
                                form.ShowDialog();
                            }

                            MessageBox.Show("Proceso terminado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Todos los archivos deben tener un nombre local.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha de vencimiento debe ser mayor a la fecha disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("La fecha disponible no puede ser una fecha anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_AutoName_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_AutoName.Checked)
            {
                foreach (DataRow row in data.Rows)
                {
                    string name = generate_file_name(row["FilePath"].ToString(), false);
                    //(row["FileLName"] = row["FileName"].ToString().Replace(".txt", (string.Format(" - {0:MMMM} {1}", DateTime.Now, DateTime.Now.Year)));
                    if (name != "")
                    {
                        row["FileLName"] = string.Format("{0} - {1:MMMM} {2}", name, DateTime.Now, DateTime.Now.Year);
                        row["OnError"] = false;
                    }
                    else 
                    {
                        row["FileLName"] = "ERROR";
                        row["OnError"] = true;
                    }
                }
            }
            else 
            {
                foreach (DataRow row in data.Rows)
                {
                    row["FileLName"] = "";
                    row["OnError"] = true;
                }
            }
        }

        private void btn_ViewFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", selectedPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}