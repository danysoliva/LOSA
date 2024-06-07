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
using Microsoft;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ACS.MP
{
   
    public partial class MP_CargarII : DevExpress.XtraEditors.XtraForm
    {
        //------------------------------------------
        DataSet datos;
        DataOperations dp = new DataOperations();
        //------------------------------------------

        public MP_CargarII()
        {
            InitializeComponent();
        }

        private void MP_CargarII_Load(object sender, EventArgs e)
        {
            //CargarComboAnio();
            //CargarComboMes();
            cargarPeriodos();
        }

        void CargarComboAnio()
        {
//            try
//            {
//                datos = dp.ACS_GetSelectData(@"SELECT  year
//                        FROM    [dbo].[MP_Inventario_Inicial]
//                        Group By year
//                        Order by year desc
//                        ");
//                cmblAnio.Properties.DataSource = datos.Tables[0];
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
        }

        void CargarComboMes()
        {
//            try
//            {
//                datos = dp.ACS_GetSelectData(@"SELECT  year, month, id
//                        FROM    [dbo].[MP_Inventario_Inicial]
//                        Where   year= " + (cmblAnio.EditValue == null ? "0" : cmblAnio.EditValue) + @"
//                        Order by month
//                        ");
//                cmblMes.Properties.DataSource = datos.Tables[0];
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
        }

        void CargarGrid()
        {
            try
            {
                datos = dp.ACS_GetSelectData(@"SELECT  b.codigo, b.material, a.quantity, a.value_usd, a.value_hnl 
                        FROM    [dbo].[MP_Inventario_Inicial_D] a
                                Left Join [dbo].[MP_MateriasPrimas] b on a.id_mp= b.id
                        Where enable = 1 and  a.id_ii= " + cmb_Period.EditValue );
                grdDetalle.DataSource = datos.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cmblAnio_EditValueChanged(object sender, EventArgs e)
        {
            CargarComboMes();
            grdDetalle.DataSource = null;
        }

        private void btnCargarII_Click(object sender, EventArgs e)
        {
            #region Imporar Cuadro de Excel
            DataSet ds_importado = ReadTextFile();
            if (ds_importado.Tables[0].Rows.Count >0)
            {
                MP_CarcarII_Preview frm = new MP_CarcarII_Preview(ds_importado);
                frm.ShowDialog();
                MP_CargarII_Load(this, new EventArgs());
                cargarPeriodos();
            }
            #endregion
        }



        private void btnBajarPlantilla_Click(object sender, EventArgs e)
        {
            #region Exportando Plantilla Excel
            try
            {
                datos = dp.ACS_GetSelectData(@"SELECT  codigo, material, 0.0000 cantidad, 0.0000 valor_usd, 0.0000 valor_hnl, 0.0000 consumo_kgs, 0.0000 inv_fisico_kgs
                        FROM    [dbo].[MP_MateriasPrimas] b
                        WHERE   b.estado= 'a' and 
                                b.Codigo not in('1004000012', '1005000021') and
                                b.codigo not like '%*%'
                        ");
                grdPlantilla.DataSource = datos.Tables[0];

                SaveFileDialog archivo = new SaveFileDialog();
                archivo.Filter = "Excel (*.xlsx)|*.xlsx";
                if (archivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    grdPlantillaView.ExportToXlsx(archivo.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }


        private DataSet ReadTextFile()
        {
            try
            {
                DataSet compras = new DataSet();
                compras.Tables.Add();

                string[] columns = null;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Cargar Materia Prima en Kilogramos (Kg)";
                dialog.Filter = "Archivo de Texto (.txt)|*.txt";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var lines = File.ReadAllLines(dialog.FileName);

                    if (lines.Count() > 0)
                    {
                        columns = lines[0].Split(new char[] { '\t' });

                        foreach (var col in columns)
                        {
                            compras.Tables[0].Columns.Add(col);
                        }

                        for (int i = 1; i < lines.Count(); i++)
                        {
                            DataRow row = compras.Tables[0].NewRow();
                            string[] val = lines[i].Split(new char[] { '\t' });

                            for (int r = 0; r < val.Count() && r < columns.Count(); r++)
                            {
                                if (r >= 2 && val[r] == "") val[r] = "0";
                                row[r] = val[r];
                            }
                            //if(row[0].ToString().Trim()!="")
                                compras.Tables[0].Rows.Add(row);
                        }
                        //compras.Tables[0].Columns.Add("existe", System.Type.GetType("System.Boolean"));    //nuevo experimento... 09/02/2016
                        compras.Tables[0].Columns.Add("existe", typeof(Boolean));    //nuevo experimento... 09/02/2016
                        compras.Tables[0].Columns.Add("id_mp");     //nuevo experimento... 09/02/2016 
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Aparentemente el archivo esta vacio.\n\nDebe seleccionar un archivo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    //txt_file.Text = dialog.FileName;
                }
                return compras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carga de datos ha fallado.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void cargarPeriodos()
        {
            try
            {
                cmb_Period.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT  id,[descripcion]as period 
                                                                            FROM  [dbo].[MP_PeriodosContables]   
                                                                            where enable = 1  order by id desc").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error\n\nDetalle: {0}\n\nStacktrace: {1}", ex.Message, ex.StackTrace), "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Period_EnabledChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cmb_Period.EditValue) > 0)
                CargarGrid();
        }

        private void cmb_Period_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cmb_Period.EditValue) > 0)
                CargarGrid();
        }

        private void btnBajarXPeriodo_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cmb_Period.EditValue) > 0)
            {
                #region Exportando Plantilla de Periodo Existente Excel
                try
                {
                    datos = dp.ACS_GetSelectData(@"SELECT  B.codigo codigo, b.material material, a.quantity cantidad, value_usd valor_usd, a.value_hnl valor_hnl, consumo_kgs, inv_fisico_kgs
                            FROM    [dbo].[MP_Inventario_Inicial_D] a
                                    LEFT JOIN MP_MateriasPrimas B ON B.ID= A.id_mp
                            WHERE  A.id_ii= " + cmb_Period.EditValue);
                    grdPlantilla.DataSource = datos.Tables[0];

                    SaveFileDialog archivo = new SaveFileDialog();
                    archivo.Filter = "Excel (*.xlsx)|*.xlsx";
                    if (archivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        grdPlantillaView.ExportToXlsx(archivo.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else
            { 
                MessageBox.Show("Debe seleccionar el periodo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                cmb_Period.Focus();
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void cmdAnularLineasInv_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Realmente desea anular estas lineas?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_anular_lineas_inv_contabilidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                cmd.ExecuteNonQuery();

                con.Close();
                CajaDialogo.InformationAuto();
                CargarGrid();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}