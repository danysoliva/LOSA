using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using LOSA.Clases;
using LOSA.Classes;

namespace LOSA.MigracionACS
{
    public partial class CargarXML : Form
    {
        public string ActiveUserCode;
        public string ActiveUserName;
        public string ActiveUserType;
        String ParPath; DataSet DAta;
        DataOperations dp = new DataOperations();

        public CargarXML()
        {
            InitializeComponent();
            try
            {string Qry = @"Select [id]
                                  ,[descripcion]   
                              FROM [dbo].[FCT_Tipo_Saco]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Qry, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            pruebaXMLxsd.Tipo_Saco.Clear();
            da.Fill(pruebaXMLxsd.Tipo_Saco);
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Visualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParPath = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML File(.xml)| *.xml";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Seleccione el archivo De Formula.";
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ParPath = @dialog.FileName.ToString();
                    LoadXML Ld = new LoadXML(ParPath);
                    DAta = Ld.Dosomething();
                    DAta.Tables["ProductHeader"].Columns.Add("Comentario", typeof(String));
                    DAta.Tables["ProductHeader"].Columns.Add("ValidSince", typeof(DateTime));
                    DAta.Tables["ProductHeader"].Columns.Add("Typeofbag", typeof(Int32));
                    DAta.Tables["ProductHeader"].Columns.Add("FormOf", typeof(Boolean));
                    DAta.Tables["Material"].Columns.Add("PorcenCum", typeof(Double));
                    DAta.Tables["Material"].Columns.Add("PesoCum", typeof(Double));
                    DAta.Tables["ProductHeader"].Columns.Add("ifsubir", typeof(Boolean));

                    foreach (DataRow row in DAta.Tables["ProductHeader"].Rows)
                    {
                        row["ValidSince"] = DateTime.Today;
                        row["ifsubir"] = true;
                        row["FormOf"] = false;

                        string par;
                        if (row["Description"].ToString().Length >= 7)
                            par = row["Description"].ToString().Substring(0, 7);
                        else
                            par = row["Description"].ToString();
                        string query = @"SELECT top 1 id
                               FROM[dbo].FCT_Tipo_Saco ss
                               where ss.nulo <> 1 and
                                     ss.descripcion like '%" + par.Trim() + "%'";
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                            Conn.Open();

                            SqlCommand cmd = new SqlCommand(query, Conn);
                            int val = Convert.ToInt32(cmd.ExecuteScalar());
                            row["Typeofbag"] = val;
                        }
                        catch (Exception)
                        {
                            
                        }

                        double cumPor = 0, cumWe = 0;

                        foreach (DataRow rou in DAta.Tables["Material"].Rows)
                        {
                            if (row["Code"].ToString() == rou["ProductCode"].ToString())//Mientra el codigo de encabezado sea 
                                                                                        //igual al Codigo de formula en Material
                            {
                                cumPor = cumPor + Convert.ToDouble(rou["Percentage"].ToString());
                                rou["PorcenCum"] = cumPor;
                                cumWe = cumWe + Convert.ToDouble(rou["Weight"].ToString());
                                rou["PesoCum"] = cumWe;
                                
                            }

                        }
                    }

                    gridControl1.DataSource = DAta;
                    grdHeader2.DataSource = DAta;
                    
                    gridControl1.DataMember = "Material";
                    grdHeader2.DataMember = "ProductHeader";
                    Btn_Insert.Enabled = true;
                    btn_LoadHead.Enabled = true;
                    btn_clearAll.Enabled = true;



                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
           
        }

        private void Btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if (MessageBox.Show("Sí no ha guardado los cambios estos se perderan.", "Desea cerrar el Formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();

            }
        }


        private void Btn_Insert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int Valid = 0;
            //DAta.GetChanges(DataRowState.Modified);
            try
            {
                foreach (DataRow row in DAta.Tables["ProductHeader"].Rows)
                {

                    if (row["Comentario"] == DBNull.Value)
                    {
                        row["Comentario"] = " ";
                        Valid = 0;
                      
                    }
                    if (row["ValidSince"] == DBNull.Value)
                    {
                        MessageBox.Show("Fecha hasta donde esta vigente la fecha requeria.");
                        Valid = 1;
                        return;
                    }
                    if (row["Typeofbag"] == DBNull.Value)
                    {
                        MessageBox.Show("Seleccione un tipo de saco");
                        Valid = 1;
                        return;
                    }
                    if (row["FormOf"] == DBNull.Value)
                    {
                        MessageBox.Show("Falta la seleccion si es Nutreco o Regal");
                        Valid = 1;
                        return;
                    }
                   
                }

            if (Valid == 0)
            {
                string Dname = "", 
                    Type = "",
                    Version = "", 
                    Usuar = "",
                    Len, 
                    Created = "",
                    AppNombre = "";
                foreach (DataRow row in DAta.Tables["TransactionHeader"].Rows)
                {
                    Dname = row["DatabaseName"].ToString();
                    Type = row["MessageType"].ToString();
                    Version = row["MessageVersion"].ToString();
                    Usuar = row["MessageCreatedBy"].ToString();
                    Len = row["DataLanguage"].ToString();
                    Created = row["MessageDate"].ToString();
                    AppNombre = row["ApplicationName"].ToString();
                }
                foreach (DataRow rou in DAta.Tables["ProductHeader"].Rows)
                {
                    if (Convert.ToBoolean(rou["ifsubir"].ToString()))
                    { int formuid = save_formula_header(Dname, Created, Usuar,rou["Code"].ToString(), rou["Description"].ToString(),
                        rou["TotalWeight"].ToString(), rou["ValidFrom"].ToString(), rou["ValidSince"].ToString(), rou["FormOf"].ToString()
                        , Convert.ToInt32(rou["Typeofbag"].ToString()));
                        save_formula_detail(formuid, rou["Code"].ToString());
                    }
                }
                if (MessageBox.Show("Se cargo los datos exitosamente","Exitosamente",MessageBoxButtons.OK,MessageBoxIcon.Information)== DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }

            }
            catch (Exception)
            {
                Valid = 1;
                MessageBox.Show("Um...! Ocurrio un error inesperado, debe comunicarse con el departamento de Sistemas.");
                return;
            }


        }
        private Int32 save_formula_header(string ServerName, string Datecreate, string CreadoX, string CodeForm, string FormName,
            string PesoFor, string desdeFe, string hastaFe, string Ouner, int TypeOFbag)
        {
            try
            {
                int Ouwner;
                if (Ouner == "True")
                {
                    Ouwner = 1;
                }
                else
                {
                    Ouwner = 0;
                }
                Int32 InsertedID = 0;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@src_company_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_company_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_plant_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_mix_type", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_mix_ref_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_server_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_created_date", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@src_created_time", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@src_printed_date", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@src_printed_time", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@src_printed_by", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_formula_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_formula_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_formula_tonnes", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_batch_size_kg", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@src_last_updated", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@lcl_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@lcl_loaded_by", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@lcl_last_mod_by", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@copy_number", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@approve_prod", SqlDbType.Bit));
                cmd.Parameters.Add(new SqlParameter("@aprove_fin", SqlDbType.Bit));
                cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@lcl_owner", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@id_tipo_saco", SqlDbType.Int));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@src_company_code"].Value ="4401"; 
                cmd.Parameters["@src_company_name"].Value ="Scretting Ecuador";
                cmd.Parameters["@src_plant_code"].Value = "0088";
                cmd.Parameters["@src_mix_type"].Value = "Single-Mix";
                cmd.Parameters["@src_mix_ref_code"].Value = "1312.5/3.16";
                cmd.Parameters["@src_server_name"].Value = ServerName;
                cmd.Parameters["@src_created_date"].Value = Convert.ToDateTime(Datecreate);
                cmd.Parameters["@src_created_time"].Value = (Convert.ToDateTime(Datecreate)).ToString("hh:mm:ss");
                cmd.Parameters["@src_printed_date"].Value = Convert.ToDateTime(Datecreate);
                cmd.Parameters["@src_printed_time"].Value = (Convert.ToDateTime(Datecreate)).ToString("hh:mm:ss");
                cmd.Parameters["@src_printed_by"].Value = CreadoX;
                cmd.Parameters["@src_formula_code"].Value = CodeForm;
                cmd.Parameters["@src_formula_name"].Value = FormName;
                cmd.Parameters["@src_formula_tonnes"].Value = " ";//Por verificar su necesidad
                cmd.Parameters["@src_batch_size_kg"].Value = Convert.ToDouble(PesoFor);
                cmd.Parameters["@src_last_updated"].Value = Convert.ToDateTime(Datecreate);
                cmd.Parameters["@lcl_name"].Value = FormName + " - " + cbxMes.Text + " " + txtAno.Text;//dp.Now().ToString("MMMM yyyy");
                //cmd.Parameters["@lcl_name"].Value = FormName + " - " + dp.Now().ToString("MMMM yyyy");
                cmd.Parameters["@lcl_loaded_by"].Value = ActiveUserCode;
                cmd.Parameters["@lcl_last_mod_by"].Value = ActiveUserCode;
                cmd.Parameters["@status"].Value = 35;
                cmd.Parameters["@copy_number"].Value = 0;
                cmd.Parameters["@approve_prod"].Value = DBNull.Value;
                cmd.Parameters["@aprove_fin"].Value = DBNull.Value;
                cmd.Parameters["@available_date"].Value = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(desdeFe));
                cmd.Parameters["@due_date"].Value = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(hastaFe).AddMonths(2));
                cmd.Parameters["@lcl_owner"].Value = Ouwner;// 1 Es AQF , 0 es Nutreco
                cmd.Parameters["@id_tipo_saco"].Value = TypeOFbag;

                InsertedID = dp.ACS_Exec_SP_GetID("FM_FF_Insert_Main_v2", cmd, param);

                FMOP fmop = new FMOP();
                fmop.ext_formula_event_entry(InsertedID, int.Parse(ActiveUserCode), "INI", "Formula Cargada al Sistema");

                return InsertedID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private void save_formula_detail(Int32 header_id, string codigo)
        {
           
          
            try
            {
                if (header_id > 0)
                {
                    foreach (DataRow row in DAta.Tables["Material"].Rows)
                    {
                        if (codigo == row["ProductCode"].ToString())
                        {
                            
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id_h", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_code", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_name", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_group", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_bin", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_per", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_per_cum", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_kg", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_kg_cum", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_mkt_rep_cost", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@local_rm", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@local_rm_match", SqlDbType.Bit));
                        cmd.Parameters.Add(new SqlParameter("@sys_comment", SqlDbType.VarChar));
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                            cn.Open();
                            string query = @"SELECT 
                                              a.[tipo] 
                                          FROM [dbo].[MP_TipoMateriaPrima] a join
                                          ACS.dbo.MP_MateriasPrimas b on
                                          a.id = b.tipo
                                          where b.codigo = '" + row["CentralArticleCode"].ToString() + @"'";
                            SqlCommand cmdd = new SqlCommand(query, cn);
                            SqlDataReader dr = cmdd.ExecuteReader();
                            string bin = "N/A";
                            if (dr.Read())
                            {
                                bin = dr.GetString(0);

                            }
                            dr.Close();
                            cn.Close();
                        cmd.Parameters["@id_h"].Value = header_id;
                        cmd.Parameters["@source_mat_code"].Value = row["CentralArticleCode"].ToString();
                        cmd.Parameters["@source_mat_name"].Value = row["MaterialDescription"].ToString();
                        cmd.Parameters["@source_mat_group"].Value = "N/A";
                        cmd.Parameters["@source_mat_bin"].Value = bin;
                        cmd.Parameters["@source_inc_per"].Value = Convert.ToDouble(row["Percentage"].ToString());
                        cmd.Parameters["@source_inc_per_cum"].Value = Convert.ToDouble(row["PorcenCum"].ToString());
                        cmd.Parameters["@source_inc_kg"].Value = Convert.ToDouble(row["Weight"].ToString());
                        cmd.Parameters["@source_inc_kg_cum"].Value = Convert.ToDouble(row["PesoCum"]);
                        cmd.Parameters["@source_mkt_rep_cost"].Value = 0;//Convert.ToDouble(row["source_mkt_rep_cost"].ToString());

                        DataSet temp = dp.ACS_GetSelectData(string.Format("SELECT [id] ,[estado] FROM [dbo].[MP_MateriasPrimas] WHERE [codigo] = '{0}'", row["MaterialCode"]));

                        if (temp.Tables[0].Rows.Count <= 0)
                        {
                            cmd.Parameters["@local_rm"].Value = DBNull.Value;
                            cmd.Parameters["@local_rm_match"].Value = 0;
                            cmd.Parameters["@sys_comment"].Value = "El codigo de materia prima no existe.";
                        }
                        else if (temp.Tables[0].Rows.Count == 1)
                        {
                            if (temp.Tables[0].Rows[0][1].ToString() == "a")
                            {
                                cmd.Parameters["@local_rm"].Value = int.Parse(temp.Tables[0].Rows[0][0].ToString());
                                cmd.Parameters["@local_rm_match"].Value = 1;
                                cmd.Parameters["@sys_comment"].Value = "Ok";
                            }
                            else if (temp.Tables[0].Rows[0][1].ToString() == "i")
                            {
                                cmd.Parameters["@local_rm"].Value = int.Parse(temp.Tables[0].Rows[0][0].ToString());
                                cmd.Parameters["@local_rm_match"].Value = 0;
                                cmd.Parameters["@sys_comment"].Value = "La materia prima localmente esta inactiva.";
                            }
                        }
                        else if (temp.Tables[0].Rows.Count > 1)
                        {
                            cmd.Parameters["@local_rm"].Value = DBNull.Value;
                            cmd.Parameters["@local_rm_match"].Value = 0;
                            cmd.Parameters["@sys_comment"].Value = "Este codigo de materia prima esta repetido en la base de datos.";
                        }

                        dp.ACS_Exec_SP("FM_FF_Insert_Detail", cmd);
                            
                    } }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeadXmlLook Head = new HeadXmlLook(DAta);
            Head.Show();
        }

        private void btn_clearAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Se va a descartar los datos seleccionado","Descartar",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DAta.Tables["Material"].Clear();
                DAta.Tables["TransactionHeader"].Clear();
                DAta.Tables["ProductHeader"].Clear();
                Btn_Insert.Enabled = false;
                btn_LoadHead.Enabled = false;
                btn_clearAll.Enabled = false;
            }
           
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void grdHeader2_Validated(object sender, EventArgs e)
        {
           // SendKeys.Send("{ENTER}");
        }

        private void grdHeader2_TextChanged(object sender, EventArgs e)
        {
            //string a = "";
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Column.Name == "colComentario")
            {
                
            }
        }

        private void gridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = gridView.GetFocusedDataRow();
            gridView2.SetRowCellValue(gridView.GetRowHandle(0), "colComentario", row["colComentario"]);
        }

        private void grdHeader2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = gridView.GetFocusedDataRow();
            gridView2.SetRowCellValue(gridView.GetRowHandle(0), "colComentario", row["colComentario"]);
        }
    }
}
