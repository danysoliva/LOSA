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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace ACS.MP
{
    public partial class MP_CarcarII_Preview : DevExpress.XtraEditors.XtraForm
    {
        //Variables -------------------------------------------
        DataSet dt;
        DataOperations dp = new DataOperations();
        int id_ii_existente = 0, contInexistentes=0;
        Boolean RegistroSatisfactorio = false, continuarProceso;
        //-----------------------------------------------------

        public MP_CarcarII_Preview(DataSet datos)
        {
            InitializeComponent();
            dt = datos;
            cargarPeriodos();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MP_CarcarII_Preview_Load(object sender, EventArgs e)
        {
            conteo_revision();
            grdDetalle.DataSource = dt.Tables[0];
            //spnAnio.Value= DateTime.Now.Year;   //remover
            //spnMes.Value = DateTime.Now.Month;  //remover

            if (tieneDuplicados())
            {
                MessageBox.Show(
                    "Elarchivo contiene codigos de materia prima repetidos, corrija los datos y vuelva a intentar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

        } 


        private void btnProcesar_Click(object sender, EventArgs e)
        {   //-----------------------------------------------------
            if (contInexistentes > 0) 
            {
                MessageBox.Show(
                    "Uno o mas registros no existen en la base de datos de materia prima. \n Llamar a sistemas.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (cmb_Period.ItemIndex==-1)
            {
                MessageBox.Show("Seleccione periodo.");
                cmb_Period.Focus();
                return;
            }

            //if (spnAnio.Value > DateTime.Now.Year || spnMes.Value > 12) //remover
            //{
            //    MessageBox.Show("Ingrese año y mes válidos.");
            //    spnAnio.Focus();
            //    return;
            //}

            #region Procesando..
            //Boolean continuar= false;
                id_ii_existente = 0;

                #region Comprobación si ya existe Año y Mes a cargar
                //------------------------------------------------------------------------------------------
                DataSet resultado=  dp.ACS_GetSelectData(@" SELECT ID 
                                                            FROM [dbo].[MP_Inventario_Inicial] 
                                                            WHERE [period_id]= " + cmb_Period.EditValue );
                                    //WHERE [year]= " + spnAnio.Value + " AND [month]= " + spnMes.Value);
                if (resultado.Tables[0].Rows.Count == 0)   {
                    //No existe año y mes a crear
                    continuarProceso = true;
                    Insertar_CTL_DET_Blanco();
                }
                else 
                {
                    //Ya existe un "inventario inic ial" del AÑO y MES seleccionado
                    DialogResult respuesta = MessageBox.Show(
                                        "Ya existe una carga de inventario inicial con ese periodo, ¿desea reemplazar los datos?", 
                                        "Advertencia", 
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation);
                    if (respuesta == DialogResult.Yes)
                    {
                        //Ininicializando variables para limpiar valores para actualizar con nueva carga
                        continuarProceso = true;
                        Inicializando_CTL_DET();    //Seteando a 0 los valores
                        id_ii_existente = Convert.ToInt32(resultado.Tables[0].Rows[0]["id"]);
                    }

                }
                //------------------------------------------------------------------------------------------
                #endregion 
                if (continuarProceso)
                {
                    Actualizando_CTL_DET();
                    if (RegistroSatisfactorio) {
                        MessageBox.Show("Carga de inventario correspndiente al " + getPeriodoName() + " satisfactoria.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar_Click(this, new EventArgs());
                    }
                }
            #endregion ....

            //-----------------------------------------------------
        }


        void conteo_revision()   ////////////////////////
        {
            //int cont = 0; //, contInexistentes=0;
            //double tUSD = 0, tHNL = 0;
            #region Recorriendo para Conteo y Revision
            try
            {
                foreach (DataRow linea in dt.Tables[0].Rows)
                {
                    //tUSD = tUSD + Convert.ToDouble(linea["valor_usd"]);
                    //tHNL = tHNL + Convert.ToDouble(linea["valor_hnl"]);
                    //cont++;

                    int vId_mp = Convert.ToInt32((getIdCodigoMP(linea["codigo"].ToString())));
                    if (vId_mp > 0) //Si existe.
                    {
                        linea["existe"] = true;
                    }
                    else
                    {
                        linea["existe"] = false;
                        contInexistentes++;
                    }
                    linea["id_mp"] = vId_mp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }               ////////////////////////

        
        void Insertar_CTL_DET_Blanco()
        {
            try
            {
                #region Creando Registro Control (MP_Inventario_Inicial)
                id_ii_existente = dp.ACS_InsertAndReturnID(@"  INSERT INTO [dbo].[MP_Inventario_Inicial](
                    								  [year]
                    								 ,[month]
                    								 ,[period_id]
                    								 ,[period_name]
                    								 ,[created_date]
                    								 ,[created_by])
                    						  VALUES (" 
                                                        + 0 + @"
                    								 ," + 0 + @"
                                                     ," + cmb_Period.EditValue + @"
                    								 ,'" + getPeriodoName() + @"'
                    						         , getdate() 
                    								 ," + 1 + "); Select Scope_Identity(); ");  //TEMPORAL 1= USUARIO ID 1
                #endregion

                #region Creando Registro Detalle (En Blanco)
                dp.ACS_InsertAndReturnID(@"  INSERT INTO [dbo].[MP_Inventario_Inicial_D] 
                                                     (id_ii
                                                     ,id_mp
                                                     ,quantity
                                                     ,value_usd
                                                     ,value_hnl
                                                     ,consumo_kgs
                                                     ,inv_fisico_kgs
                                                    ) 
                                              ( SELECT " + id_ii_existente + @",b.ID,0.00,0.00,0.00, 0.00,0.00 
                                                FROM [dbo].[MP_MateriasPrimas] b
                                                WHERE b.estado= 'a' and 
                                                      b.codigo not like '%*%'
                                              ) ");  //TEMPORAL 1= USUARIO ID 1
                #endregion
            }
            catch (Exception ex)
            {
                continuarProceso = false;
                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

        void Actualizando_CTL_DET()
        {
            try
            {
                //- Control ----------------------------------------------------------
                dp.ACS_InsertAndReturnID(@"  UPDATE [dbo].[MP_Inventario_Inicial] SET 
                                                    [created_date]= getdate()
                                                    ,[created_by]= 1 
                    						  WHERE id=" + id_ii_existente ); 
                                                    //[year]= " + spnAnio.Value + @" and 
                    								//[month]=" + spnMes.Value);
                //- Detalle ---------------------------------------------------------- AQUI!
                foreach (DataRow linea in dt.Tables[0].Rows)
                {
                    double valor_costo = Convert.ToDouble(Convert.ToDouble(linea["valor_usd"]));
                    int idmp = Convert.ToInt32(linea["id_mp"]);
                    double dispo = Convert.ToDouble(Convert.ToDouble(linea["cantidad"]));
                    if (dispo == 0)
                        dispo = 1;

                    double CostoR = (valor_costo / dispo)*1000;

                    dp.ACS_DoSmallDBOperation(@" UPDATE [dbo].[MP_Inventario_Inicial_D] SET
                    				                    [quantity]=" + Convert.ToDouble(Convert.ToDouble(linea["cantidad"])) + @"
                    						            ,[value_usd]=" + Convert.ToDouble(Convert.ToDouble(linea["valor_usd"])) + @"
                                                        ,[value_hnl]=" + Convert.ToDouble(Convert.ToDouble(linea["valor_hnl"])) + @"
                                                        ,[consumo_kgs]=" + Convert.ToDouble(Convert.ToDouble(linea["consumo_kgs"])) + @"
                                                        ,[inv_fisico_kgs]=" + Convert.ToDouble(Convert.ToDouble(linea["inv_fisico_kgs"])) + @"
                                                WHERE   id_ii=" + id_ii_existente.ToString() + @" and
                                                        id_mp=" + Convert.ToInt32(linea["id_mp"]));


                    //sp_set_ultimo_costo_finanzas
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_set_ultimo_costo_finanzas", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@costo", CostoR);
                        cmd.Parameters.AddWithValue("@idmp", idmp);
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
                //--------------------------------------------------------------------
                RegistroSatisfactorio = true;
            }
            catch (Exception ex)
            {
                continuarProceso = false;
                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Inicializando_CTL_DET()   
        {
            try
            {
                //- Control ----------------------------------------------------------
                dp.ACS_InsertAndReturnID(@"  UPDATE [dbo].[MP_Inventario_Inicial] SET 
                                                    [created_date]= 0
                                                    ,[created_by]= 1 
                    						  WHERE id=" + id_ii_existente);
                //- Detalle ----------------------------------------------------------
                foreach (DataRow linea in dt.Tables[0].Rows)
                {
                    dp.ACS_DoSmallDBOperation(@" UPDATE [dbo].[MP_Inventario_Inicial_D] SET
                    				        [quantity]=0 
                    						,[value_usd]=0 
                                            ,[value_hnl]=0 
                                            WHERE id_ii=" + id_ii_existente);
                }
                //--------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                continuarProceso = false;
                MessageBox.Show("Error\n\nDetalle: " + ex.Message + "\n\nStacktrace: " + ex.StackTrace, "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        int getIdCodigoMP(String pMP)
        {
            DataSet resultado = dp.ACS_GetSelectData(@"SELECT ID FROM [dbo].[MP_MateriasPrimas] MP WHERE MP.[codigo]= '" + pMP + "'") ;
            return (resultado.Tables[0].Rows.Count==0? 0 : Convert.ToInt32(resultado.Tables[0].Rows[0]["ID"]));
        }


        Boolean tieneDuplicados()
        {
            bool duplicado= false;
            int n ;
            foreach (DataRow linea in dt.Tables[0].Rows)
            {
                n = 0;
                String x = linea["codigo"].ToString();
                //-------------------------------------------//
                foreach (DataRow linea2 in dt.Tables[0].Rows)
                {
                    String y = linea2["codigo"].ToString();
                    if (y != "\"")
                    {
                        if (x == y)
                        {
                            n++;
                            //if (n > 1)
                            //{

                            //}
                        }
                    }
                }
                //-------------------------------------------//
                if (n > 1) { duplicado = true; break; }
            }
            return duplicado;
        }

        void cargarPeriodos()
        {
            try
            {
                //cmb_Period.Properties.DataSource = dp.ODOO_GetSelectData(@"SELECT A.id, A.NAME AS period, B.NAME AS fiscalyear FROM PUBLIC.account_period A INNER JOIN PUBLIC.account_fiscalyear B ON A.fiscalyear_id = B.id WHERE A.STATE = 'draft' order by  right(a.NAME,4) desc, left(a.name,2) desc").Tables[0];
                cmb_Period.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT  id,[descripcion]as period 
                                                                            FROM  [dbo].[MP_PeriodosContables]   
                                                                            where enable = 1  order by id desc").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error\n\nDetalle: {0}\n\nStacktrace: {1}", ex.Message, ex.StackTrace), "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        String getPeriodoName() {
            String periodo = "";
            object row = cmb_Period.Properties.GetDataSourceRowByKeyValue(cmb_Period.EditValue);
            if (row != null)
            {
                periodo= ((DataRowView)row)["period"].ToString();
            }
            return periodo;
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);                
            }
            #endregion
        }

    }
}