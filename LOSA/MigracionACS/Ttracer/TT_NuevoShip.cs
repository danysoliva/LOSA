using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_NuevoShip : Form
    {
        DataOperations dp = new DataOperations();
        public string usercode;
        public int IdCreate;
        public string codigoGen;
        public string shipname;
        public TT_NuevoShip(string UCode)
        {
            InitializeComponent();
            usercode = UCode;
        }
        public Boolean existeinsap(int Tipival, string Avallid)
        {
            string query = "";
            switch (Tipival)
            {
                case 1: //validar si existe en sap el codigo de Items
                    query = @"Select top 1
                            T0.ItemCode 
                            from OITM T0
                            where T0.ItemCode = @var";
                    break;
                case 2: //Validar si la descripcion es valida
                    query = @"Select top 1
                            T0.ItemName 
                            from OITM T0
                            where T0.ItemName like @var";
                    break;
                case 3:
                    query = @"Select top 1
                            T0.CardCode 
                            from OCRD T0
                            where T0.CardCode = @var";
                    break;
                case 4:
                    query = @"Select top 1
                            T0.CardName 
                            from OCRD T0
                            where T0.CardName like @var ";
                    break;
                default:
                    break;
            }
            SqlConnection con = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            con.Open();
            try
            {
                SqlCommand cmmd = new SqlCommand(query, con);
                SqlDataReader dr = cmmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void btnexcel_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = 0; //Contador que nos permite saber si existe mas de una linea configurada para la entrada de un barco.
                int id_ship = 0; // Nos guardara el dato del barco seleccionado.
                int Id_PlanH = 0; // Es el ID del plan cabeza de plan.
                int granel = 0; //Bit que nos indica si es tipo granel el envio.
                int id_planD = 0; // El id del plan detalle;
                string file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Seleccione el archivo importado anteriormente";
                Ttracer.dSTtracer dSMP1 = new dSTtracer();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\""; //String de conexion estandar de excel.
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Hoja1$]", con);
                    dSMP1.LoadExcelH.Clear();
                    myCommand.Fill(dSMP1.LoadExcelH);
                    contador = dSMP1.LoadExcelH.Rows.Count;
                    if (contador >1 )
                    {
                        MessageBox.Show("Problema con la data cargada. Se necesita que en la hoja1 solo exista una linea de informacion.");
                        return;
                    }
                   
                    foreach (DataRow row in dSMP1.LoadExcelH.Rows)
                    {
                        #region V A L I D A C I O N E S 
                        if (row["ItemCode"] == DBNull.Value )
                        {
                            MessageBox.Show("Codigo de materia prima vacio, por favor ingresar la informacion completa.","Mensaje de error",MessageBoxButtons.OKCancel);
                            return;
                        }
                        
                        if (row["ItemName"] == DBNull.Value) 
                        {
                            MessageBox.Show("Descripcion de materia prima vacia. por favor ingresar la informacion completa","Mensaje de error", MessageBoxButtons.OKCancel);
                            return;
                        }
                        if (row["CardCode"] == DBNull.Value)
                        {
                            MessageBox.Show("El codigo de proveedor esta vacio, por favor colocar la informacion completa", "Mensaje de error");
                            return;
                        }
                        if (row["quantity"] ==DBNull.Value)
                        {
                            MessageBox.Show("La columna de cantidad no puede ir vacia. Por favor colocar el numero de vehiculos que participaran en el arribo", "Mensaje de error");
                            return;

                        }
                        else
                        {
                            int cantidad = Convert.ToInt32(row["quantity"].ToString());
                            if (cantidad > 10)
                            {
                                if (MessageBox.Show("La cantidad de camiones esperados es mayor que 10. Estas seguro que esperas una cantidad mayor?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {

                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        if (row["CardName"] == DBNull.Value)
                        {
                            MessageBox.Show("La descripcion del proveedor esta vacia. Por favor llenar los campos correctamente.");
                            return;
                        }
                        if (row["date_begin"] == DBNull.Value)
                        {
                            MessageBox.Show("La fecha de inicio de plan esta vacia, Por favor llenar los campos correctamente");
                            return;
                        }
                        else
                        {
                            if (Convert.ToDateTime(row["date_begin"].ToString()).Date < DateTime.Now.Date)
                            {
                                MessageBox.Show("No es posible guardar el plan con una fecha anterior al dia de hoy. Por favor validar los datos.");
                                return;
                            }
                        }
                        if (row["date_end"] == DBNull.Value)
                        {
                            MessageBox.Show("La fecha de terminacion de plan esta vacia, Por favor llenar los campos correctamente.","Mensaje de error");
                            return;
                        }
                        else
                        {
                            if (Convert.ToDateTime(row["date_end"].ToString()).Date < Convert.ToDateTime(row["date_begin"].ToString()).Date)
                            {
                                MessageBox.Show("Al parecer la fecha final es menor que la fecha de inicio. Por favor llenar los campos correctamente.", "Mensaje de error");
                                return;
                            }
                        }
                        if (row["peso"] == DBNull.Value)
                        {
                            MessageBox.Show("El peso de materia prima adquirida esta vacia. Por favor llenar los campos correctamente.","Mensaje de error");
                            return;
                        }
                        if (row["DocNum"] == DBNull.Value)
                        {
                            MessageBox.Show("El numero de Orden de SAP no puede ir vacio, Por favor llenar los campos correctamente.", "Mensaje de error");
                            return;
                        }
                        if (row["Comment"]== DBNull.Value)
                        {
                            MessageBox.Show("El comentario del plan no puede ir vacio.Por favor llenar los campos correctamente", "Mensaje de error");
                            return;
                        }
                        if (row["pesoxvehiculo"] == DBNull.Value)
                        {
                            MessageBox.Show("Se debe especificar un promedio de peso que viene en cada camion. Por favor llenar los campos correctamente.", "Mensaje de error");
                            return;
                        }
                        if (row["granel"] == DBNull.Value)
                        {
                            MessageBox.Show("Se debe especificar si el envio es a granel o no","Mensaje de error");
                            return;
                        }
                        else
                        {
                            if (Convert.ToBoolean(row["granel"].ToString()))
                            {
                                granel = 1;
                            }
                            else
                            {
                                granel = 0;
                            }
                        }
                        if (!existeinsap(1, row["ItemCode"].ToString()))
                        {
                            MessageBox.Show("El item a ingresar no existe en SAP o esta mal escrito.");
                            return;
                        }
                        if (!existeinsap(1, row["ItemName"].ToString()))
                        {
                            MessageBox.Show("El item a ingresar no existe en SAP o esta mal escrito.");
                            return;
                        }
                        if (!existeinsap(1, row["CardCode"].ToString()))
                        {
                            MessageBox.Show("El codigo de proveedor no existe en SAP o esta mal escrito.");
                            return;
                        }
                        if (!existeinsap(1, row["CardName"].ToString()))
                        {
                            MessageBox.Show("El codigo de proveedor no existe en SAP o esta mal escrito.");
                            return;
                        }

                        #endregion
                        string query = @"SELECT TOP 1 [id]
                                        FROM [dbo].[M_ship]
                                        where descripcion like '" + row["shipname"].ToString() + @"%%'";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            id_ship = Convert.ToInt32(dr[0].ToString());
                        }
                        else
                        {
                            if (MessageBox.Show("No pudimos encontrar el barco que estas intendo subir, Si desea registrar un barco nuevo, Precionar OK. Si desea editar simplemente precione Cancelar", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            { //Insertamos un nuevo barco segun la informacion recibida
                                string query2 = @"INSERT INTO [dbo].[M_ship]
                                                            ([codigo]
                                                            ,[enable]
                                                            ,[descripcion])
                                                        VALUES
                                                            (@codigo
                                                            ,1
                                                            ,@descrip)Select SCOPE_IDENTITY()";
                                SqlCommand MyCommand = new SqlCommand(query2, cn);
                                MyCommand.Parameters.Add("@codigo", SqlDbType.VarChar).Value = dp.Nexcode(4);
                                MyCommand.Parameters.Add("@descrip", SqlDbType.VarChar).Value = row["shipname"].ToString();
                                id_ship = Convert.ToInt32(MyCommand.ExecuteScalar());
                                dp.updatesecuence(4);
                                cn.Close();

                                // Y despues de seleccionar el barco.............Preparamos el insert del H de barco.


                            }
                            else
                            {
                                return;
                            }
                            string InsertHeader = @"INSERT INTO [dbo].[TS_ship_h]
                                                        ([code]
                                                        ,[quantity]
                                                        ,[status]
                                                        ,[date_begin]
                                                        ,[date_end]
                                                        ,[date_create]
                                                        ,[peso]
                                                        ,[enable]
                                                        ,[close]
                                                        ,[createby]
                                                        ,[datelastmod]
                                                        ,[shipid])
                                                    VALUES
                                                        (@code
                                                        ,@cantidad
                                                        ,10
                                                        ,@dtini
                                                        ,@dtfin
                                                        ,SYSDATETIME()
                                                        ,@peso
                                                        ,1
                                                        ,0
                                                        ,@usuario
                                                        ,SYSDATETIME()
                                                        ,@idship)Select SCOPE_IDENTITY()";
                            using (SqlConnection cnn = new SqlConnection(dp.ConnectionStringBascula))
                            {
                                cn.Open();
                                SqlCommand cmd3 = cn.CreateCommand();
                                SqlTransaction trans;
                                trans = cn.BeginTransaction("SampleTransaction");
                                cmd.Connection = cn;
                                cmd.Transaction = trans;

                                try
                                {
                                    cmd3.CommandText = InsertHeader;
                                    cmd3.Parameters.Add("@code", SqlDbType.VarChar).Value = dp.Nexcode(5);
                                    cmd3.Parameters.Add("@cantidad", SqlDbType.Int).Value = Convert.ToInt32(row["quantity"].ToString());
                                    cmd3.Parameters.Add("@dtini", SqlDbType.DateTime).Value = Convert.ToDateTime(row["date_begin"].ToString());
                                    cmd3.Parameters.Add("@dtfin", SqlDbType.DateTime).Value = Convert.ToDateTime(row["date_end"].ToString());
                                    cmd3.Parameters.Add("@peso", SqlDbType.Decimal).Value = Convert.ToDecimal(row["peso"].ToString());
                                    cmd3.Parameters.Add("@usuario", SqlDbType.Int).Value = Convert.ToInt32(usercode);
                                    cmd3.Parameters.Add("@idship", SqlDbType.Int).Value = id_ship;
                                    Id_PlanH = Convert.ToInt32(cmd3.ExecuteScalar());
                                    cmd3.Parameters.Clear();
                                    cmd3.CommandText = @"INSERT INTO [dbo].[TS_ship_d]
                                                        ([id_shiph]
                                                        ,[DocNum]
                                                        ,[ItemCode]
                                                        ,[ItemName]
                                                        ,[CardCode]
                                                        ,[Cardname]
                                                        ,[status]
                                                        ,[date_create]
                                                        ,[peso]
                                                        ,[enable]
                                                        ,[id_unit]
                                                        ,[close]
                                                        ,[usersing]
                                                        ,[DocEntry]
                                                        ,[Linenum]
                                                        ,[granel]
                                                        ,[Comment])
                                                    VALUES
                                                        (@Idh
                                                        ,@docnum
                                                        ,@Itemcode
                                                        ,@Itemname
                                                        ,@cardcode
                                                        ,@cardname
                                                        ,10
                                                        ,SYSDATETIME()
                                                        ,@pesoorden
                                                        ,1
                                                        ,1
                                                        ,1
                                                        ,@usercode
                                                        ,@docnum
                                                        ,0
                                                        ,@granel
                                                        ,@comment) Select SCOPE_IDENTITY()";
                                    cmd3.Parameters.Add("@Idh", SqlDbType.Int).Value = Id_PlanH;
                                    cmd3.Parameters.Add("@docnum", SqlDbType.Int).Value = Convert.ToInt32(row["DocNum"].ToString());
                                    cmd3.Parameters.Add("@itemcode", SqlDbType.VarChar).Value = row["ItemCode"].ToString();
                                    cmd3.Parameters.Add("@Itemname", SqlDbType.VarChar).Value = row["ItemName"].ToString();
                                    cmd3.Parameters.Add("@cardcode", SqlDbType.VarChar).Value = row["CardCode"].ToString();
                                    cmd3.Parameters.Add("@CardName", SqlDbType.VarChar).Value = row["CardName"].ToString();
                                    cmd3.Parameters.Add("@pesoorden", SqlDbType.Decimal).Value = Convert.ToInt32(row["peso"].ToString());
                                    cmd3.Parameters.Add("@usercode", SqlDbType.Int).Value = Convert.ToInt32(usercode);
                                    cmd3.Parameters.Add("@granel", SqlDbType.Bit).Value = granel;
                                    cmd3.Parameters.Add("@comment", SqlDbType.VarChar).Value = row["Comment"].ToString();
                                    id_planD = Convert.ToInt32(cmd3.ExecuteScalar());
                                    cmd3.Parameters.Clear();
                                    
                                    trans.Commit();


                                }
                                catch (Exception ex)
                                {

                                    try
                                    {
                                        trans.Rollback();
                                    }
                                    catch (Exception ex2)
                                    {

                                        MessageBox.Show(ex2.Message + ex.Message);
                                    }
                                }

                            }
                        }
                        //Buscar el nombre del barco si existe
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnmanual_Click(object sender, EventArgs e)
        {
            TT_shipconfig algo = new TT_shipconfig(1, usercode);
            if (algo.ShowDialog() == DialogResult.OK)
            {
                codigoGen = algo.codigoGen;
                shipname = algo.shipname;
                IdCreate = algo.IdCreate;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
