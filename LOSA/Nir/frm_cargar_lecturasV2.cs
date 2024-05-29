using ACS.Classes;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using Huellas;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Nir
{
    public partial class frm_cargar_lecturasV2 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_lectura;
        UserLogin UsuarioLogeado;
        int tipo = 0;

        public frm_cargar_lecturasV2(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            tipo = 0;

            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtVentana.Visible = true;
            else
                txtVentana.Visible = false;
        }

        public frm_cargar_lecturasV2(UserLogin Puser, int id)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_lectura = id;
            tipo = 1;//editar
            Load_lecturas();
            if (tipo == 1)
            {
                //btnupdate.Visible = false;
                //btnSave.Visible = false;
            }
        }

        public void Load_lecturas()
        {
            string query = @"sp_load_lecturas_nir_to_edit";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_lectura);
                dsNIR_PRD1.Nir_lecturas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNIR_PRD1.Nir_lecturas);
                CN.Close();
                query = "sp_load_titulo_de_lectura_h";

                CN.Open();
                cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_lectura);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcomentario.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                }
                dr.Close();
                CN.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcomentario.Text == "")
            {
                CajaDialogo.Error("No debe de quedar la caja de comentarios vacia.");
                return;
            }
            if (dsNIR_PRD1.Nir_lecturas.Rows.Count == 0)
            {
                CajaDialogo.Error("Debe de cargar por lo menos una lectora del Nir.");
                return;
            }
            if (tipo == 0) //nuevo
            {
                string query = @"sp_insert_header_lectura_nir";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    int Id_header = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();

                    query = @"sp_insert_lectura_nir_detalle";
                    foreach (dsNIR_PRD.Nir_lecturasRow row in dsNIR_PRD1.Nir_lecturas.Rows)
                    {
                        cn.Open();
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", Id_header);
                        cmd.Parameters.AddWithValue("@lote", row.__Lote == null ? " " : row.__Lote);
                        cmd.Parameters.AddWithValue("@nombre_producto", row.Nombre_de_Producto == null ? " " : row.Nombre_de_Producto);
                        cmd.Parameters.AddWithValue("@comentario", row.Comentario == null ? " " : row.Comentario);
                        cmd.Parameters.AddWithValue("@TS", row.TS == -99 ? (object)DBNull.Value : row.TS);
                        cmd.Parameters.AddWithValue("@NB", row.NB == -99 ? (object)DBNull.Value : row.NB);
                        cmd.Parameters.AddWithValue("@GH", row.GH == -99 ? (object)DBNull.Value : row.GH);
                        cmd.Parameters.AddWithValue("@broma_porcentaje", row.__Bromatologia);
                        cmd.Parameters.AddWithValue("@id_bromatologia", row.ID_Bromatologia);
                        cmd.Parameters.AddWithValue("@n_curva", row.Nombre_de_la_Curva);
                        cmd.Parameters.AddWithValue("@curva", row.__Curva);
                        cmd.Parameters.AddWithValue("@date", row._Fecha_Hora_de_Analisis);
                        cmd.Parameters.AddWithValue("@lectura", row.__Lectura);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    CajaDialogo.Information("Se ha cargado correctamente la plantilla");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }


            }
            else
            {       //editar

                string query = @"sp_update_titulo_de_leccturas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_lectura);
                cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Se ha cambiado correctamente el nombre de la plantilla");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                dialog.Title = "Seleccione el archivo importado anteriormente";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Sheet$]", con);

                    DataSet dataset = new DataSet();

                    try
                    {
                        myCommand.Fill(dataset, "Lecturas");
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    SplashForm frmProceso = new SplashForm();
                    //try
                    //{
                    //    myCommand.Fill(dsNIR_PRD1.lectura_nir_new);
                    //    dsNIR_PRD1.lectura_nir_new.AcceptChanges();
                    //}
                    //catch (Exception ec)
                    //{
                    //    CajaDialogo.Error(ec.Message);
                    //}

                    int TiempoP = 450;
                    frmProceso.ShowDialog();
                    Thread.Sleep(TiempoP);
                    frmProceso.Close();

                    DataTable nir_lecturas = dataset.Tables["Lecturas"];

                    foreach (DataRow item in nir_lecturas.Rows)
                    {
                        DataRow dr1 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr1[0] = 0;//id
                        dr1[1] = 0;//id_h
                        dr1[2] = item["Sample Number"];//#lectura
                        dr1[3] = item["Analysis Time"];//Fecha Analisis
                        dr1[4] = item["Product Code"];//#Curva
                        dr1[5] = item["Product Name"];//NombreCurva
                        dr1[6] = "PROTEIN";//IDBromatologia
                        if (item.ItemArray[4] == DBNull.Value || item.ItemArray[4].ToString() == "")
                            dr1[7] = 0;
                        else
                            dr1[7] = Convert.ToDecimal(item.ItemArray[4]);
                        dr1[8] = 0;//GH
                        dr1[9] = 0;//NB
                        dr1[10] = 0;//TS
                        dr1[11] = "";//comentario
                        dr1[12] = "";//Nombre de Algo 
                        dr1[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr1);

                        DataRow dr2 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr2[0] = 0;//id
                        dr2[1] = 0;//id_h
                        dr2[2] = item["Sample Number"];//#lectura
                        dr2[3] = item["Analysis Time"];//Fecha Analisis
                        dr2[4] = item["Product Code"];//#Curva
                        dr2[5] = item["Product Name"];//NombreCurva
                        dr2[6] = "FAT";//IDBromatologia
                        if (item.ItemArray[5] == DBNull.Value || item.ItemArray[5].ToString() == "")
                            dr2[7] = 0;
                        else
                            dr2[7] = Convert.ToDecimal(item.ItemArray[5]);
                        dr2[8] = 0;//GH
                        dr2[9] = 0;//NB
                        dr2[10] = 0;//TS
                        dr2[11] = "";//comentario
                        dr2[12] = "";//Nombre de Algo 
                        dr2[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr2);

                        DataRow dr3 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr3[0] = 0;//id
                        dr3[1] = 0;//id_h
                        dr3[2] = item["Sample Number"];//#lectura
                        dr3[3] = item["Analysis Time"];//Fecha Analisis
                        dr3[4] = item["Product Code"];//#Curva
                        dr3[5] = item["Product Name"];//NombreCurva
                        dr3[6] = "FAT HYDROLYSIS";//IDBromatologia
                        if (item.ItemArray[6] == DBNull.Value || item.ItemArray[6].ToString() == "")
                            dr3[7] =  0;
                        else
                            dr3[7] = Convert.ToDecimal(item.ItemArray[6]);
                        dr3[8] = 0;//GH
                        dr3[9] = 0;//NB
                        dr3[10] = 0;//TS
                        dr3[11] = "";//comentario
                        dr3[12] = "";//Nombre de Algo 
                        dr3[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr3);

                        DataRow dr4 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr4[0] = 0;//id
                        dr4[1] = 0;//id_h
                        dr4[2] = item["Sample Number"];//#lectura
                        dr4[3] = item["Analysis Time"];//Fecha Analisis
                        dr4[4] = item["Product Code"];//#Curva
                        dr4[5] = item["Product Name"];//NombreCurva
                        dr4[6] = "FAT_NMR";//IDBromatologia
                        if (item.ItemArray[7] == DBNull.Value || item.ItemArray[7].ToString() == "")
                            dr4[7] = 0;
                        else
                            dr4[7] = Convert.ToDecimal(item.ItemArray[7]);
                        dr4[8] = 0;//GH
                        dr4[9] = 0;//NB
                        dr4[10] = 0;//TS
                        dr4[11] = "";//comentario
                        dr4[12] = "";//Nombre de Algo 
                        dr4[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr4);

                        DataRow dr5 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr5[0] = 0;//id
                        dr5[1] = 0;//id_h
                        dr5[2] = item["Sample Number"];//#lectura
                        dr5[3] = item["Analysis Time"];//Fecha Analisis
                        dr5[4] = item["Product Code"];//#Curva
                        dr5[5] = item["Product Name"];//NombreCurva
                        dr5[6] = "MOISTURE";//IDBromatologia
                        if (item.ItemArray[8] == DBNull.Value || item.ItemArray[8].ToString() == "")
                            dr5[7] = 0;
                        else
                            dr5[7] = Convert.ToDecimal(item.ItemArray[8]);
                        dr5[8] = 0;//GH
                        dr5[9] = 0;//NB
                        dr5[10] = 0;//TS
                        dr5[11] = "";//comentario
                        dr5[12] = "";//Nombre de Algo 
                        dr5[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr5);

                        DataRow dr6 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr6[0] = 0;//id
                        dr6[1] = 0;//id_h
                        dr6[2] = item["Sample Number"];//#lectura
                        dr6[3] = item["Analysis Time"];//Fecha Analisis
                        dr6[4] = item["Product Code"];//#Curva
                        dr6[5] = item["Product Name"];//NombreCurva
                        dr6[6] = "ASH";//IDBromatologia
                        if (item.ItemArray[9] == DBNull.Value || item.ItemArray[9].ToString() == "")
                            dr6[7] = 0;
                        else
                            dr6[7] = Convert.ToDecimal(item.ItemArray[9]);
                        dr6[8] = 0;//GH
                        dr6[9] = 0;//NB
                        dr6[10] = 0;//TS
                        dr6[11] = "";//comentario
                        dr6[12] = "";//Nombre de Algo 
                        dr6[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr6);

                        DataRow dr7 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr7[0] = 0;//id
                        dr7[1] = 0;//id_h
                        dr7[2] = item["Sample Number"];//#lectura
                        dr7[3] = item["Analysis Time"];//Fecha Analisis
                        dr7[4] = item["Product Code"];//#Curva
                        dr7[5] = item["Product Name"];//NombreCurva
                        dr7[6] = "FIBER";//IDBromatologia
                        if (item.ItemArray[10] == DBNull.Value || item.ItemArray[10].ToString() == "")
                            dr7[7] = 0;
                        else
                            dr7[7] = Convert.ToDecimal(item.ItemArray[10]);
                        dr7[8] = 0;//GH
                        dr7[9] = 0;//NB
                        dr7[10] = 0;//TS
                        dr7[11] = "";//comentario
                        dr7[12] = "";//Nombre de Algo 
                        dr7[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr7);

                        DataRow dr8 = dsNIR_PRD1.Nir_lecturas.NewRow();
                        dr8[0] = 0;//id
                        dr8[1] = 0;//id_h
                        dr8[2] = item["Sample Number"];//#lectura
                        dr8[3] = item["Analysis Time"];//Fecha Analisis
                        dr8[4] = item["Product Code"];//#Curva
                        dr8[5] = item["Product Name"];//NombreCurva
                        dr8[6] = "PROTEIN_KOH";//IDBromatologia
                        if (item.ItemArray[11] == DBNull.Value || item.ItemArray[11].ToString() == "")
                            dr8[7] = 0;
                        else
                            dr8[7] = Convert.ToDecimal(item.ItemArray[11]);
                        dr8[8] = 0;//GH
                        dr8[9] = 0;//NB
                        dr8[10] = 0;//TS
                        dr8[11] = "";//comentario
                        dr8[12] = "";//Nombre de Algo 
                        dr8[13] = item["2_Additional information"];//#Lote
                        dsNIR_PRD1.Nir_lecturas.Rows.Add(dr8);
                    }
                    dsNIR_PRD1.AcceptChanges();

                    #region CodigoViejo

                    //Aqui debe ocurrir la magia de llenar la Plantilla de ALOSY
                    //foreach (dsNIR_PRD.lectura_nir_newRow rowNew in dsNIR_PRD1.lectura_nir_new)
                    //{
                    //    DataRow dr1 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr1[0] = 0;//id
                    //    dr1[1] = 0;//id_h
                    //    dr1[2] = rowNew.Sample_Number;//#lectura
                    //    dr1[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr1[4] = rowNew.Product_Code;//#Curva
                    //    dr1[5] = rowNew.Product_Name;//NombreCurva
                    //    dr1[6] = "PROTEIN";//IDBromatologia
                    //    dr1[7] = rowNew.PROTEIN;//%Bromatologia
                    //    dr1[8] = 0;//GH
                    //    dr1[9] = 0;//NB
                    //    dr1[10] = 0;//TS
                    //    dr1[11] = "";//comentario
                    //    dr1[12] = "";//Nombre de Algo 
                    //    dr1[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr1);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();

                    //    DataRow dr2 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr2[0] = 0;//id
                    //    dr2[1] = 0;//id_h
                    //    dr2[2] = rowNew.Sample_Number;//#lectura
                    //    dr2[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr2[4] = rowNew.Product_Code;//#Curva
                    //    dr2[5] = rowNew.Product_Name;//NombreCurva
                    //    dr2[6] = "FAT";//IDBromatologia
                    //    if (rowNew.IsFATNull())
                    //        dr2[7] = 0;//%Bromatologia
                    //    else
                    //        dr2[7] = rowNew.FAT;//%Bromatologia
                    //    dr2[8] = 0;//GH
                    //    dr2[9] = 0;//NB
                    //    dr2[10] = 0;//TS
                    //    dr2[11] = "";//comentario
                    //    dr2[12] = "";//Nombre de Algo 
                    //    dr2[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr2);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();

                    //    DataRow dr3 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr3[0] = 0;//id
                    //    dr3[1] = 0;//id_h
                    //    dr3[2] = rowNew.Sample_Number;//#lectura
                    //    dr3[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr3[4] = rowNew.Product_Code;//#Curva
                    //    dr3[5] = rowNew.Product_Name;//NombreCurva
                    //    dr3[6] = "FAT_HYDROLYSIS";//IDBromatologia
                    //    if (rowNew.IsFAT_HYDROLYSISNull())
                    //        dr3[7] = 0;
                    //    else
                    //        dr3[7] = rowNew.FAT_HYDROLYSIS;//%Bromatologia
                    //    dr3[8] = 0;//GH
                    //    dr3[9] = 0;//NB
                    //    dr3[10] = 0;//TS
                    //    dr3[11] = "";//comentario
                    //    dr3[12] = "";//Nombre de Algo 
                    //    dr3[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr3);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();

                    //    DataRow dr4 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr4[0] = 0;//id
                    //    dr4[1] = 0;//id_h
                    //    dr4[2] = rowNew.Sample_Number;//#lectura
                    //    dr4[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr4[4] = rowNew.Product_Code;//#Curva
                    //    dr4[5] = rowNew.Product_Name;//NombreCurva
                    //    dr4[6] = "FAT_NMR";//IDBromatologia
                    //    if (rowNew.IsFAT_NMRNull())
                    //        dr4[7] = 0;
                    //    else
                    //        dr4[7] = rowNew.FAT_NMR;//%Bromatologia
                    //    dr4[8] = 0;//GH
                    //    dr4[9] = 0;//NB
                    //    dr4[10] = 0;//TS
                    //    dr4[11] = "";//comentario
                    //    dr4[12] = "";//Nombre de Algo 
                    //    dr4[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr4);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();



                    //    DataRow dr5 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr5[0] = 0;//id
                    //    dr5[1] = 0;//id_h
                    //    dr5[2] = rowNew.Sample_Number;//#lectura
                    //    dr5[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr5[4] = rowNew.Product_Code;//#Curva
                    //    dr5[5] = rowNew.Product_Name;//NombreCurva
                    //    dr5[6] = "MOISTURE";//IDBromatologia
                    //    if (rowNew.IsMOISTURENull())
                    //        dr5[7] = 0;
                    //    else
                    //        dr5[7] = rowNew.MOISTURE;//%Bromatologia
                    //    dr5[8] = 0;//GH
                    //    dr5[9] = 0;//NB
                    //    dr5[10] = 0;//TS
                    //    dr5[11] = "";//comentario
                    //    dr5[12] = "";//Nombre de Algo 
                    //    dr5[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr5);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();



                    //    DataRow dr6 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr6[0] = 0;//id
                    //    dr6[1] = 0;//id_h
                    //    dr6[2] = rowNew.Sample_Number;//#lectura
                    //    dr6[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr6[4] = rowNew.Product_Code;//#Curva
                    //    dr6[5] = rowNew.Product_Name;//NombreCurva
                    //    dr6[6] = "ASH";//IDBromatologia
                    //    if (rowNew.IsASHNull())
                    //        dr6[7] = 0;
                    //    else
                    //        dr6[7] = rowNew.ASH;//%Bromatologia
                    //    dr6[8] = 0;//GH
                    //    dr6[9] = 0;//NB
                    //    dr6[10] = 0;//TS
                    //    dr6[11] = "";//comentario
                    //    dr6[12] = "";//Nombre de Algo 
                    //    dr6[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr6);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();

                    //    DataRow dr7 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr7[0] = 0;//id
                    //    dr7[1] = 0;//id_h
                    //    dr7[2] = rowNew.Sample_Number;//#lectura
                    //    dr7[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr7[4] = rowNew.Product_Code;//#Curva
                    //    dr7[5] = rowNew.Product_Name;//NombreCurva
                    //    dr7[6] = "FIBER";//IDBromatologia
                    //    if (rowNew.IsFIBERNull())
                    //        dr7[7] = 0;
                    //    else
                    //        dr7[7] = rowNew.FIBER;//%Bromatologia
                    //    dr7[8] = 0;//GH
                    //    dr7[9] = 0;//NB
                    //    dr7[10] = 0;//TS
                    //    dr7[11] = "";//comentario
                    //    dr7[12] = "";//Nombre de Algo 
                    //    dr7[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr7);
                    //    //dsNIR_PRD1.Nir_lecturas.AcceptChanges();

                    //    DataRow dr8 = dsNIR_PRD1.Nir_lecturas.NewRow();
                    //    dr8[0] = 0;//id
                    //    dr8[1] = 0;//id_h
                    //    dr8[2] = rowNew.Sample_Number;//#lectura
                    //    dr8[3] = rowNew.Analysis_Time;//Fecha Analisis
                    //    dr8[4] = rowNew.Product_Code;//#Curva
                    //    dr8[5] = rowNew.Product_Name;//NombreCurva
                    //    dr8[6] = "PROTEIN_KOH";//IDBromatologia
                    //    if (rowNew.IsPROTEIN_KOHNull())
                    //        dr8[7] = 0;
                    //    else
                    //        dr8[7] = rowNew.PROTEIN_KOH;//%Bromatologia
                    //    dr8[8] = 0;//GH
                    //    dr8[9] = 0;//NB
                    //    dr8[10] = 0;//TS
                    //    dr8[11] = "";//comentario
                    //    dr8[12] = "";//Nombre de Algo 
                    //    dr8[13] = rowNew._2_Additional_information;//#Lote
                    //    dsNIR_PRD1.Nir_lecturas.Rows.Add(dr8);

                    //}
                    //dsNIR_PRD1.AcceptChanges();

                    #endregion

                    //Eliminacion de 0
                    foreach (dsNIR_PRD.Nir_lecturasRow item in dsNIR_PRD1.Nir_lecturas.Rows)
                    {
                        if (item.__Bromatologia == 0)
                        {
                            item.Delete();
                        }
                    }
                    dsNIR_PRD1.AcceptChanges();

                    txtcomentario.Focus();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDescargarPlantilla_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                grdNirNew.ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}