using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;
using LOSA.Clases;

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_exoneracionNueva : Form
    {
        int isedit = 0; // 0 = nuevo 1 = editar
        UserLogin UsuarioLogeado;
        int Seterror = 0; // 0 Normal 1 Listo 2 Error
        int contador  = 0; // Los segundos que dura la alarma;
        public int idH = 0;
        int enable = 0;
        int cerrado = 0;
        DataOperations dp = new DataOperations();
        public SAR_exoneracionNueva(UserLogin User, int tipo, int idexoneracion)
        {
            
            InitializeComponent();

            isedit = tipo;
            if (isedit == 0) // crear
            {
             UsuarioLogeado = User;
                    load_plantilla();
                    timer1.Enabled = true;
                tgcerrado.Visible = false;
                tgenable.Visible = false;
            }
            else
            {
                idH = idexoneracion;
                btnload.Enabled = false;
                btndescargar.Enabled = false;
                btnsave.Enabled = true;
                btnver.Enabled = false;
                load_data_of_exoneracion();
                this.Text = "Editar exoneracion";
                labelControl1.Text = "Editar la exoneracion.";
            }
          
        }
        public void load_plantilla()
        {
            string Query = @"SELECT [Code] as Codigo
                              ,[Name] as Rubro
	                          , 0 as  Monto
                          FROM [AQFSVR006\AQFSVR006].[dbo].[@RUBRO]
                          order by cast(Code as int) asc";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.plantilla.Clear();
                da.Fill(dS_SAR.plantilla);
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la data " + ex.Message);
            }
        }
        private void dtinicial_EditValueChanged(object sender, EventArgs e)
        {
            DateTime Selected;
            Selected = dtinicial.DateTime;//Obteniendo la fecha para validar si existe un registro de este periodo
            try
            {
                string query = @"SELECT
                                [anio]
                            FROM [dbo].[SAR_presupuesto_h]
                            where anio = @anio and enable = 1";
                if (isedit == 0)
                {
                     query = @"SELECT
                                [anio]
                            FROM [dbo].[SAR_presupuesto_h]
                            where anio = @anio and enable = 1";
                }
                else
                {
                    query = @"SELECT
                                [anio]
                            FROM [dbo].[SAR_presupuesto_h]
                            where anio = @anio and enable = 1 and id not in ("+idH+")";
                }
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@anio", SqlDbType.Int).Value = Selected.ToString("yyyy");
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Seterror = 2;
                    CajaDialogo.Error("Ya existe un registro con este año, por favor actualizarlo");
                    dtinicial.Focus();
                    return;

                }
                else
                {

                    dtfinal.DateTime = Selected.AddDays(365);
                    dtanio.DateTime = Selected;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Seterror = 2;
                CajaDialogo.Error("Error.." + ex.Message);
              
            }
        }
        public void load_data_of_exoneracion()
        {
            string query = @"SELECT
                              [anio] --0
                              ,[inicio] -- 1
                              ,[final] --2
                              ,[enable] -- 3
                              ,[cerrado] -- 4
                          FROM [dbo].[SAR_presupuesto_h]
                          where id = @id";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand sql = new SqlCommand(query, cn);
                sql.Parameters.Add("@id", SqlDbType.Int).Value = idH;
                SqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    dtanio.DateTime = DateTime.Parse("1/1/" + dr[0].ToString());
                    dtinicial.DateTime = DateTime.Parse(dr[1].ToString());
                    dtfinal.DateTime = DateTime.Parse(dr[2].ToString());
                    if (dr[3].ToString() == "True")
                    {
                        tgenable.IsOn = true;
                        enable = 1;
                    }
                    else
                    {
                        tgenable.IsOn = false;
                        enable = 0;
                    }
                    if (dr[4].ToString() == "True")
                    {
                        tgcerrado.IsOn = true;
                        cerrado = 1;
                    }
                    else
                    {
                        tgcerrado.IsOn = false;
                        cerrado = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (Seterror)
            {
                case 1://Listo
                    pnalert.BackColor = Color.Green;
                    if (contador == 5)
                    {
                        Seterror = 0;
                        contador = 0;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                 
                    break;
                case 2: // Error
                    pnalert.BackColor = Color.Red;
                    if (contador == 5)
                    {
                        Seterror = 0;
                        contador = 0;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                    break;
                default: // normal
                    pnalert.BackColor = Color.FromArgb(235, 236, 239);
                    contador = 0;
                    break;
            }
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_plantillas.ExportToXlsx(dialog.FileName);
                OpenMicrosoftExcel(dialog.FileName);
            }
        }
        static void OpenMicrosoftExcel(string f)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = f;
            Process.Start(startInfo);
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                string file_name;
                file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Subir un archivo de planilla de rubro.";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        file_name = @dialog.FileName.ToString();
                        string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                        OleDbConnection con = new OleDbConnection(Connection);
                        OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Hoja1$]", con);
                        dS_SAR.plantilla.Clear();
                        myCommand.Fill(dS_SAR.plantilla);
                        btnver.Enabled = true;
                        btnsave.Enabled = true;
                    }
                    catch (Exception)
                    {
                        file_name = @dialog.FileName.ToString();
                        string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                        OleDbConnection con = new OleDbConnection(Connection);
                        OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Sheet$]", con);
                        dS_SAR.plantilla.Clear();
                        myCommand.Fill(dS_SAR.plantilla);
                        btnver.Enabled = true;
                        btnsave.Enabled = true;


                    }
                  
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error al cargar la informacion. Llamada: " +ex.Message );
            }
           
         }

        private void btnver_Click(object sender, EventArgs e)
        {
            SAR_detalle detail = new SAR_detalle(dS_SAR.plantilla);
            detail.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Selected;
                if (dtinicial.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar una fecha de inicio de exoneracion.");
                    return;
                }
                if (dtfinal.Text == "")
                {
                    CajaDialogo.Error("No puede dejar el campo de fecha final de la exoneracion vacia.");
                    return;
                }
                if (dtinicial.DateTime >= dtfinal.DateTime)
                {
                    CajaDialogo.Error("La fecha final no puede ser menor que la fecha inicial.");
                    return;
                }
                if (dtanio.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar un año para la exoneracion.");
                    return;
                }
                else
                {
                    Selected = dtanio.DateTime;
                }
                if (isedit == 0)
                {
                    if (btnver.Enabled == false)
                    {
                        CajaDialogo.Error("Debe cargar un formato con datos correctos para continuar.");
                        return;
                    }
                    try
                    {
                        SqlConnection cnn = new SqlConnection(dp.ConnectionStringCostos);
                        cnn.Open();
                        string query = @"SELECT
                                [anio]
                            FROM [dbo].[SAR_presupuesto_h]
                            where anio = @anio and enable = 1";
                        SqlCommand cmmmmd = new SqlCommand(query, cnn);
                        cmmmmd.Parameters.Add("@anio", SqlDbType.Int).Value = Selected.ToString("yyyy");
                        SqlDataReader dr = cmmmmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Seterror = 2;
                            CajaDialogo.Error("Ya existe un registro con este año, por favor actualizarlo");
                            dtinicial.Focus();
                            return;

                        }
                    }
                    catch (Exception)
                    {

                    }
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    string Query = @"INSERT INTO [dbo].[SAR_presupuesto_h]
                                            ([anio]
                                            ,[inicio]
                                            ,[final]
                                            ,[user_create]
                                            ,[enable]
                                            ,[cerrado])
                                        VALUES
                                            (@anio
                                            ,@dtinicio
                                            ,@dtfinal
                                            ,@usuario
                                            ,1
                                            ,0) SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.Parameters.Add("@anio", SqlDbType.Int).Value = dtanio.Text;
                    cmd.Parameters.Add("@dtinicio", SqlDbType.DateTime).Value = dtinicial.DateTime;
                    cmd.Parameters.Add("@dtfinal", SqlDbType.DateTime).Value = dtfinal.DateTime;
                    cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = UsuarioLogeado.UserId;

                    int idheader = Convert.ToInt32(cmd.ExecuteScalar());
                    idH = idheader;
                    foreach (DataRow row in dS_SAR.plantilla.Rows)
                    {
                        Query = @"INSERT INTO [dbo].[SAR_presupuesto_d]
                                           ([code]
                                           ,[monto]
                                           ,[idh]
                                           ,[enable])
                                     VALUES
                                           (@code
                                           ,@monto
                                           ,@encabezado
                                           ,1)";
                        SqlCommand cmmd = new SqlCommand(Query, cn);
                        cmmd.Parameters.Add("@code", SqlDbType.VarChar).Value = row["Codigo"].ToString();
                        cmmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = row["Monto"].ToString();
                        cmmd.Parameters.Add("@encabezado", SqlDbType.Int).Value = idheader;
                        cmmd.ExecuteNonQuery();

                    }

                    Seterror = 1;
                    CajaDialogo.Information("Operacion exitosa");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    try
                    {
                        if (enable == 0)
                        {
                            if (MessageBox.Show("Desea deshabilitar la exoneracio?", "Advertencia", MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                            {

                            }
                            else
                            {
                                return;
                            }


                        }
                        if (cerrado ==1 )
                        {
                            if (MessageBox.Show("Desea cerrar la exoneracio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {

                            }
                            else
                            {
                                return;
                            }
                        }
                        string query = @"UPDATE [dbo].[SAR_presupuesto_h]
                                       SET [anio] = @anio
                                          ,[inicio] = @dtinicio
                                          ,[final] = @dtfinal
                                          ,[enable] = @enable
                                          ,[cerrado] = @cerrar
                                      where id = @id";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.Add("@anio", SqlDbType.Int).Value = dtanio.Text;
                        cmd.Parameters.Add("@dtinicio", SqlDbType.DateTime).Value = dtinicial.DateTime;
                        cmd.Parameters.Add("@dtfinal", SqlDbType.DateTime).Value = dtfinal.DateTime;
                        cmd.Parameters.Add("@enable", SqlDbType.Bit).Value = enable;
                        cmd.Parameters.Add("@cerrar", SqlDbType.Bit).Value = cerrado;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idH;
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        if (cerrado == 1)
                        {
                            idH = 0;
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {

                Seterror = 2;
                MessageBox.Show(ex.Message);
            }
        }

        private void tgenable_Toggled(object sender, EventArgs e)
        {
            if (tgenable.IsOn)
            {
                enable = 1;
            }
            else
            {

                enable = 0;
            }
        }

        private void tgcerrado_Toggled(object sender, EventArgs e)
        {
            if (tgcerrado.IsOn)
            {
                cerrado = 1;
            }
            else
            {

                cerrado = 0;
            }
        }
    }
}
