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
using System.Data.SqlClient;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_NewFormula_v2 : DevExpress.XtraEditors.XtraForm
    {
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;
        int selIdFormula;
        
        string formType;

        int selectedLine;
        int FormStatus;

        DataOperations dp = new DataOperations();

        DataSet Items;

        private void Initialize_DataSet()
        {
            Items = new DataSet();

            Items.Tables.Add("items");
            Items.Tables["items"].Columns.Add("id");
            Items.Tables["items"].Columns.Add("id_item");
            Items.Tables["items"].Columns.Add("codigo");
            Items.Tables["items"].Columns.Add("material");
            Items.Tables["items"].Columns.Add("peso");
            Items.Tables["items"].Columns.Add("inclusion");
            Items.Tables["items"].Columns.Add("tipo1");
            Items.Tables["items"].Columns.Add("tipo2");
            Items.Tables["items"].Columns.Add("tipo3");

            Items.Tables["items"].Columns["id"].DataType = System.Type.GetType("System.Int32");
            Items.Tables["items"].Columns["id_item"].DataType = System.Type.GetType("System.Int32");
            Items.Tables["items"].Columns["codigo"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["material"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["peso"].DataType = System.Type.GetType("System.Double");
            Items.Tables["items"].Columns["inclusion"].DataType = System.Type.GetType("System.Double");
            Items.Tables["items"].Columns["tipo1"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["tipo2"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["tipo3"].DataType = System.Type.GetType("System.String");
        }

        private void add_item() 
        {
            DataRow row = Items.Tables["items"].NewRow();

            row["id"] = ((Items.Tables["items"].Rows.Count + 1) * -1);
            row["id_item"] = cmb_mp.EditValue;
            DataRowView rw = cmb_mp.Properties.GetDataSourceRowByKeyValue(cmb_mp.EditValue) as DataRowView;
            row["codigo"] = rw["codigo"].ToString();
            row["material"] = rw["material"].ToString();
            row["tipo1"] = rw["tipo"].ToString();
            row["tipo3"] = rw["tipo2"].ToString();

            if (formType == "FB") 
            {
                row["peso"] = Convert.ToDouble(txt_pesomp.Text.ToString());
                Double pesoTotal = Convert.ToDouble(txt_pesomp.Text.ToString());
                foreach (DataRow r in Items.Tables["items"].Rows) 
                {
                    pesoTotal += Convert.ToDouble(r["peso"].ToString());
                }
                row["inclusion"] = (Convert.ToDouble(txt_pesomp.Text.ToString()) / pesoTotal);
                if (row["tipo3"].ToString() != "NC")
                    row["tipo2"] = dp.ACS_GetSelectData(@"SELECT B.[tipo]
                                                FROM [dbo].[MP_MateriasPrimas] A
                                               INNER JOIN  [dbo].[MP_TipoMateriaPrima] B
	                                              ON A.[tipo] = B.[id]
                                               WHERE A.[id] = " + row["id_item"].ToString() + "").Tables[0].Rows[0][0].ToString();
                else
                    row["tipo2"] = "Microingrediente";
            }
            else if (formType == "NC")
            {
                Double pesoTotal = 100;
                row["inclusion"] = (Convert.ToDouble(txt_pesomp.Text.ToString()) / 100);
                row["peso"] = (pesoTotal * Convert.ToDouble(row["inclusion"].ToString()));
                row["tipo2"] = "Microingrediente";
            }

            Items.Tables["items"].Rows.Add(row);
            Items.Tables["items"].AcceptChanges();

            if(formType == "FB")
                FB_recalculate_dataset();

            txt_pesomp.Text = "0";
            cmb_mp.Focus();
        }

        private void remove_item() 
        {
            foreach (DataRow row in Items.Tables["items"].Rows)
            {
                if (row["id"].ToString() == selectedLine.ToString()) 
                {
                    row.Delete();
                    Items.Tables["items"].AcceptChanges();
                    break;
                }
            }

            //grdv_mp.DeleteRow(grdv_mp.FocusedRowHandle);
            //Items.Tables["items"].Rows.RemoveAt(grdv_mp.FocusedRowHandle);
            //Items.Tables["items"].AcceptChanges();

            if(formType == "FB")
                FB_recalculate_dataset();
        }

        private void FB_recalculate_dataset() 
        {
            Double pesoTotal = 0;
            foreach (DataRow row in Items.Tables["items"].Rows)
            {
                pesoTotal += Convert.ToDouble(row["peso"].ToString());
            }

            foreach (DataRow row in Items.Tables["items"].Rows)
            {
                row["inclusion"] = (Convert.ToDouble(row["peso"].ToString()) / pesoTotal);
            }
        }

        private Boolean NC_validate_data() 
        {
            Double inclusionTotal = 0;
            foreach (DataRow row in Items.Tables["items"].Rows)
            {
                inclusionTotal += Convert.ToDouble(row["inclusion"].ToString());
            }

            if (inclusionTotal == 1)
                return true;
            else
                return false;
        }

        private void GetEspecies()
        {
            try
            {
                string query = @"SELECT [id]
                                       ,[Descripcion]
                                   FROM [Conf_Especies]";

                cmb_especie.Properties.DataSource = dp.ACS_GetSelectData(query).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMP()
        {
            try
            {
                string FixedQuery = "";

                if (cmb_MPoNC.SelectedIndex == 0)
                {
                    FixedQuery = @"  SELECT [id]
                                              ,[codigo]
                                              ,[material]
                                              ,'Materia Prima' AS tipo
                                              ,'MP' AS tipo2
                                          FROM [MP_MateriasPrimas]
                                          WHERE estado= 'a' ";
                }
                else if (cmb_MPoNC.SelectedIndex == 1)
                {
                    FixedQuery = @" SELECT [id]
                                          ,CONCAT([codigo],'.',[version]) AS codigo
                                          ,[nombre] AS material
	                                      ,'Nucleo' AS tipo
	                                      ,'NC' AS tipo2
                                      FROM [dbo].[FML_Formulas_v2]
                                     WHERE [tipo] = 'NC' AND [especie] = " + cmb_especie.EditValue.ToString() + "";
                }

                DataSet mp = new DataSet();

                mp = dp.ACS_GetSelectData(FixedQuery);

                cmb_mp.Properties.DataSource = mp.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_kind_formula()
        {
            if (FormAction == "new")
            {
                cmb_MPoNC.Properties.Items.Clear();
                cmb_MPoNC.Properties.Items.Add("MP - Materias Primas");
                cmb_MPoNC.Properties.Items.Add("NC - Nucleos");
                cmb_MPoNC.SelectedIndex = 0;
            }
            else
            {
                if (formType == "FB")
                {
                    cmb_MPoNC.Properties.Items.Clear();
                    cmb_MPoNC.Properties.Items.Add("MP - Materias Primas");
                    cmb_MPoNC.Properties.Items.Add("NC - Nucleos");
                    cmb_MPoNC.SelectedIndex = 0;
                }
                else if (formType == "NC")
                {
                    cmb_MPoNC.Properties.Items.Clear();
                    cmb_MPoNC.Properties.Items.Add("MP - Materias Primas");
                    cmb_MPoNC.SelectedIndex = 0;
                }
            }
        }

        private void save_header() 
        {
            //*************SAVE FORMULA HEADER***********

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@tipo", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@creado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));

            SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
            param.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters["@codigo"].Value = int.Parse(txt_Codigo.Text.ToString());
            cmd.Parameters["@version"].Value = int.Parse(txt_versionFormula.Text.ToString());
            if (cmb_type.SelectedIndex == 0)
                cmd.Parameters["@tipo"].Value = "FB";
            else if (cmb_type.SelectedIndex == 1)
                cmd.Parameters["@tipo"].Value = "NC";
            cmd.Parameters["@nombre"].Value = txt_descripcion.Text.ToString();
            cmd.Parameters["@especie"].Value = int.Parse(cmb_especie.EditValue.ToString());
            cmd.Parameters["@creado"].Value = ActiveUserCode;
            cmd.Parameters["@modificado"].Value = ActiveUserCode;
            cmd.Parameters["@comment"].Value = txt_comment.Text.ToString();
            cmd.Parameters["@estado"].Value = 20;

            selIdFormula = dp.ACS_Exec_SP_GetID("FM_Insert_Header", cmd, param);

            //*******************************************
        }

        private void save_detail()
        {
            //*************DELETE FORMULA LINES****************

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = selIdFormula;

            dp.ACS_Exec_SP("FM_Formula_Delete_Lines", cmd);

            //*************************************************

            //*************INSERT FORMULA LINES****************

            foreach (DataRow row in Items.Tables["items"].Rows)
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@type", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@item", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@inclusion", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@peso_batch", SqlDbType.Decimal));

                cmd.Parameters["@type"].Value = row["tipo3"].ToString();
                cmd.Parameters["@item"].Value = int.Parse(row["id_item"].ToString());
                cmd.Parameters["@formula"].Value = selIdFormula;
                cmd.Parameters["@inclusion"].Value = Convert.ToDecimal(row["inclusion"].ToString());
                cmd.Parameters["@peso_batch"].Value = Convert.ToDecimal(row["peso"].ToString()); ;

                dp.ACS_Exec_SP("FM_Insert_Detail", cmd);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

            //*************************************************
        }

        public FML_NewFormula_v2(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string FormAction)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
        }

        public FML_NewFormula_v2(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string FormAction, int selIdFormula, string Formtype)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
            this.selIdFormula = selIdFormula;
            this.formType = Formtype;
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmb_type.SelectedIndex == 0) 
            {
                txt_pesomp.Properties.MaxValue = 100000000;
                txt_pesomp.Properties.MinValue = (decimal)0.000001;
                lbl_peso.Text = "Kg";
                col_peso.Visible = true;
                formType = "FB";
            }
            else if (cmb_type.SelectedIndex == 1)
            {
                txt_pesomp.Properties.MaxValue = 100;
                txt_pesomp.Properties.MinValue = (decimal)0.000001;
                lbl_peso.Text = "%";
                col_peso.Visible = false;
                formType = "NC";
            }
        }

        private void FML_NewFormula_v2_Load(object sender, EventArgs e)
        {
            try
            {
                Initialize_DataSet();
                GetEspecies();
                load_kind_formula();
                grd_mp.DataSource = Items.Tables["items"];

                if (FormAction == "new")
                {
                    grp_agregarMP.Enabled = false;
                    formType = "FB";
                }
                else if (FormAction == "edit" || FormAction == "copy") 
                {
                    //*************LOAD FORMULA INFORMATION***********

                    DataTable header = new DataTable();
                    DataTable detail = new DataTable();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

                    cmd.Parameters["@id_formula"].Value = selIdFormula;

                    header = dp.ACS_Exec_SP_Get_Data("FM_Get_Formula_Header", cmd);
                    detail = dp.ACS_Exec_SP_Get_Data("FM_Get_Formula_Detail", cmd);

                    selIdFormula = int.Parse(header.Rows[0]["id"].ToString());
                    txt_Codigo.Text = header.Rows[0]["codigo"].ToString();
                    txt_versionFormula.Text = header.Rows[0]["version"].ToString();
                    formType = header.Rows[0]["tipo"].ToString();
                    txt_descripcion.Text = header.Rows[0]["nombre"].ToString();
                    cmb_especie.Text = header.Rows[0]["especie"].ToString();
                    txt_comment.Text = header.Rows[0]["comment"].ToString();

                    if (formType == "FB")
                        cmb_type.SelectedIndex = 0;
                    else if (formType == "NC")
                        cmb_type.SelectedIndex = 1;

                    if (cmb_type.SelectedIndex == 0)
                    {
                        txt_pesomp.Properties.MaxValue = 100000000;
                        txt_pesomp.Properties.MinValue = (decimal)0.000001;
                        lbl_peso.Text = "Kg";
                        col_peso.Visible = true;
                        formType = "FB";
                    }
                    else if (cmb_type.SelectedIndex == 1)
                    {
                        txt_pesomp.Properties.MaxValue = 100;
                        txt_pesomp.Properties.MinValue = (decimal)0.000001;
                        lbl_peso.Text = "%";
                        col_peso.Visible = false;
                        formType = "NC";
                    }

                    foreach (DataRow row in detail.Rows) 
                    {
                        DataRow row2 = Items.Tables["items"].NewRow();

                        row2["id"] = row["id"];
                        row2["id_item"] = row["id_item"];
                        row2["codigo"] = row["codigo"];
                        row2["material"] = row["material"];
                        row2["peso"] = row["peso_batch"];
                        row2["inclusion"] = row["inclusion"];
                        row2["tipo1"] = row["tipo1"];
                        row2["tipo2"] = row["tipo2"];
                        row2["tipo3"] = row["tipo3"];

                        Items.Tables["items"].Rows.Add(row2);
                    }

                    Items.Tables["items"].AcceptChanges();

                    //************************************************

                    GetMP();
                    cmb_especie.Enabled = false;
                    cmb_type.Enabled = false;

                    if (FormAction == "edit")
                    {
                        txt_Codigo.Enabled = false;
                        txt_versionFormula.Enabled = false;

                        if (int.Parse(dp.ACS_GetSelectData("SELECT [estado] FROM [dbo].[FML_Formulas_v2] WHERE [id] = " + selIdFormula + "").Tables[0].Rows[0][0].ToString()) >= 30)
                            btn_save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
                    else if(FormAction == "copy")
                    {
                        txt_Codigo.Enabled = true;
                        txt_versionFormula.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (FormAction == "new")
                {
                    save_header();

                    txt_Codigo.Enabled = false;
                    txt_versionFormula.Enabled = false;
                    cmb_especie.Enabled = false;
                    cmb_type.Enabled = false;

                    grp_agregarMP.Enabled = false;

                    FormAction = "edit";

                    grp_agregarMP.Enabled = true;

                    load_kind_formula();
                    GetMP();
                }
                else if (FormAction == "edit")
                {
                    /******************************UPDATE HEADER INFO******************************/

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));

                    cmd.Parameters["@id_formula"].Value = selIdFormula;
                    cmd.Parameters["@nombre"].Value = txt_descripcion.Text.ToString();
                    cmd.Parameters["@comment"].Value = txt_comment.Text.ToString();
                    cmd.Parameters["@code"].Value = int.Parse(txt_Codigo.Text.ToString());
                    cmd.Parameters["@version"].Value = int.Parse(txt_versionFormula.Text.ToString());

                    dp.ACS_Exec_SP("FM_Update_Header", cmd);

                    /******************************************************************************/

                    if (formType == "FB")
                    {
                        save_detail();
                    }
                    else if (formType == "NC")
                    {
                        if (NC_validate_data() == true)
                        {
                            save_detail();
                        }
                        else
                        {
                            MessageBox.Show("La formula del Nucleo debe completar el 100% de inclusión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (FormAction == "copy") 
                {

                    if (MessageBox.Show("Estas copiando una formula, asegurate que el codigo y version sea el correcto.\n\n¿Deseas Guardar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                    {
                        save_header();

                        if (formType == "FB")
                        {
                            save_detail();
                        }
                        else if (formType == "NC")
                        {
                            if (NC_validate_data() == true)
                            {
                                save_detail();
                            }
                            else
                            {
                                MessageBox.Show("La formula del Nucleo debe completar el 100% de inclusión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdv_mp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedLine = int.Parse(grdv_mp.GetDataRow(e.FocusedRowHandle)["id"].ToString());
            }
            catch { }
        }

        private void btn_addMP_Click(object sender, EventArgs e)
        {
            add_item();
        }

        private void btn_RemoveMP_Click(object sender, EventArgs e)
        {
            remove_item();
        }

        private void txt_pesomp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                add_item();
            }
        }

        private void grdv_mp_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmb_MPoNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetMP();
        }

        private void FML_NewFormula_v2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PrintScreen) 
            {
                this.Close();
            }
        }

        private void FML_NewFormula_v2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), new Rectangle(10, 10, 32, 32));
        }
    }
}