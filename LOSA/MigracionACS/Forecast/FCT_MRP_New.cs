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
using DevExpress.XtraSplashScreen;
using ACS.Classes;
using LOSA.Clases;

namespace ACS.Forecast
{
    public partial class FCT_MRP_New : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables

        DataOperations dp = new DataOperations();

        public string ActiveUserCode;

        DataSet proy_a;
        DataSet proy_s;

        string selDID;
        string selSID;

        DataSet OutputData = new DataSet();
        UserLogin UsuarioLogeado;

        #endregion

        #region Developer Defined Methods

        private DataSet GetIngredientes(string IDFormula)
        {
            try
            {
                decimal PesoFormula = 0;
                string FixedQuery = @" SELECT  A.[local_rm] AS 'mpid'
		                                        ,A.[source_inc_kg] AS 'pesokg'
		                                        ,0.0000 AS 'parte_formula'
	                                        FROM [dbo].[FML_Formulas_FF_D] A
                                            INNER JOIN [dbo].[MP_MateriasPrimas] B
	                                            ON COALESCE(A.[local_rm], 0) = B.[id]
	                                        WHERE [id_h] = " + IDFormula + "";

                DataSet mp = new DataSet();
                mp = dp.ACS_GetSelectData(FixedQuery);

                foreach (DataRow row in mp.Tables[0].Rows)
                {
                    PesoFormula += Convert.ToDecimal(row["pesokg"].ToString());
                }

                foreach (DataRow row in mp.Tables[0].Rows)
                {
                    decimal Percentage = (Convert.ToDecimal(row["pesokg"].ToString()) / PesoFormula);
                    row["parte_formula"] = Percentage.ToString();
                }

                return mp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataSet GetProyeccionDetail_Kg(string IDProyeccion)
        {
            try
            {
                DataSet Proyeccion = dp.ACS_GetSelectData(@"  SELECT A.[id]
                                                                ,A.[id_form]
                                                                ,(A.[ene] * 1000) AS ene
                                                                ,(A.[feb] * 1000) AS feb
                                                                ,(A.[mar] * 1000) AS mar
                                                                ,(A.[abr] * 1000) AS abr
                                                                ,(A.[may] * 1000) AS may
                                                                ,(A.[jun] * 1000) AS jun
                                                                ,(A.[jul] * 1000) AS jul
                                                                ,(A.[ago] * 1000) AS ago
                                                                ,(A.[sep] * 1000) AS sep
                                                                ,(A.[oct] * 1000) AS oct
                                                                ,(A.[nov] * 1000) AS nov
                                                                ,(A.[dic] * 1000) AS dic
                                                            FROM [dbo].[FCT_Proyecciones_Venta_D_v2] A
                                                            WHERE A.[id_proy] = " + IDProyeccion + @"");

                return Proyeccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataSet GetConsumos(DataSet  proyecciones)
        {
            try
            {
                OutputData = dp.ACS_GetSelectData(@"  SELECT A.[id]
                                                        ,A.[codigo]
                                                        ,A.[material]
                                                        ,B.[tipo]
	                                                    ,0.00000000 AS ene
	                                                    ,0.00000000 AS feb
	                                                    ,0.00000000 AS mar
	                                                    ,0.00000000 AS abr
	                                                    ,0.00000000 AS may
	                                                    ,0.00000000 AS jun
	                                                    ,0.00000000 AS jul
	                                                    ,0.00000000 AS ago
	                                                    ,0.00000000 AS sep
	                                                    ,0.00000000 AS oct
	                                                    ,0.00000000 AS nov
	                                                    ,0.00000000 AS dic
	                                                    ,0.00000000 AS total
                                                    FROM [dbo].[MP_MateriasPrimas] A
                                            INNER JOIN [dbo].[MP_TipoMateriaPrima] B ON A.[tipo] = B.[id]
                                            WHERE A.estado= 'a' ");

                foreach (DataRow rowProy in proyecciones.Tables[0].Rows) 
                {
                    DataSet DatosProyeccion = GetProyeccionDetail_Kg(rowProy["id"].ToString());

                    foreach (DataRow rowP in DatosProyeccion.Tables[0].Rows)
                    {
                        DataSet Ingredientes = GetIngredientes(rowP["id_form"].ToString());
                        foreach (DataRow rowI in Ingredientes.Tables[0].Rows)
                        {
                            foreach (DataRow rowO in OutputData.Tables[0].Rows)
                            {
                                if (rowI["mpid"].ToString() == rowO["id"].ToString())
                                {
                                    rowO["ene"] = (Convert.ToDecimal(rowO["ene"].ToString()) + ((Convert.ToDecimal(rowP["ene"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["feb"] = (Convert.ToDecimal(rowO["feb"].ToString()) + ((Convert.ToDecimal(rowP["feb"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["mar"] = (Convert.ToDecimal(rowO["mar"].ToString()) + ((Convert.ToDecimal(rowP["mar"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["abr"] = (Convert.ToDecimal(rowO["abr"].ToString()) + ((Convert.ToDecimal(rowP["abr"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["may"] = (Convert.ToDecimal(rowO["may"].ToString()) + ((Convert.ToDecimal(rowP["may"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["jun"] = (Convert.ToDecimal(rowO["jun"].ToString()) + ((Convert.ToDecimal(rowP["jun"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["jul"] = (Convert.ToDecimal(rowO["jul"].ToString()) + ((Convert.ToDecimal(rowP["jul"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["ago"] = (Convert.ToDecimal(rowO["ago"].ToString()) + ((Convert.ToDecimal(rowP["ago"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["sep"] = (Convert.ToDecimal(rowO["sep"].ToString()) + ((Convert.ToDecimal(rowP["sep"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["oct"] = (Convert.ToDecimal(rowO["oct"].ToString()) + ((Convert.ToDecimal(rowP["oct"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["nov"] = (Convert.ToDecimal(rowO["nov"].ToString()) + ((Convert.ToDecimal(rowP["nov"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));
                                    rowO["dic"] = (Convert.ToDecimal(rowO["dic"].ToString()) + ((Convert.ToDecimal(rowP["dic"].ToString()) * Convert.ToDecimal(rowI["parte_formula"].ToString())) / 1000));

                                    //break;
                                }
                            }
                        }
                    }   
                }

                if (OutputData.Tables[0].Rows.Count > 0)
                {
                    //if (rgrp_Todo.SelectedIndex == 1)
                    //{
                    //    for (int i = 1; i < int.Parse(System.DateTime.Now.Month.ToString()); i++)
                    //    {
                    //        foreach (DataRow row in OutputData.Tables[0].Rows)
                    //        {
                    //            row[GetMes(i)] = "0.00";
                    //        }

                    //    }

                    //    Decimal Diario;

                    //    foreach (DataRow row in OutputData.Tables[0].Rows)
                    //    {
                    //        Diario = (Convert.ToDecimal(row[GetMes(int.Parse(DateTime.Now.Month.ToString()))].ToString()) / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                    //        row[GetMes(int.Parse(DateTime.Now.Month.ToString()))] = (Convert.ToDecimal(row[GetMes(int.Parse(DateTime.Now.Month.ToString()))].ToString()) - (Diario * DateTime.Now.Day));
                    //    }
                    //}

                    foreach (DataRow row in OutputData.Tables[0].Rows)
                    {
                        row["total"] = (Convert.ToDecimal(row["ene"].ToString()) + Convert.ToDecimal(row["feb"].ToString()) + Convert.ToDecimal(row["mar"].ToString()) + Convert.ToDecimal(row["abr"].ToString()) + Convert.ToDecimal(row["may"].ToString()) + Convert.ToDecimal(row["jun"].ToString()) + Convert.ToDecimal(row["jul"].ToString()) + Convert.ToDecimal(row["ago"].ToString()) + Convert.ToDecimal(row["sep"].ToString()) + Convert.ToDecimal(row["oct"].ToString()) + Convert.ToDecimal(row["nov"].ToString()) + Convert.ToDecimal(row["dic"].ToString()));
                    }

                    foreach (DataRow row in OutputData.Tables[0].Rows)
                    {
                        if (row["total"].ToString() == "0.00000000")
                        {
                            //OutputData.Tables[0].Rows.Remove(row);
                            row.Delete();
                        }
                    }
                }

                return OutputData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información. \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string GetMes(int MesNum)
        {
            string mes = "";

            switch (MesNum)
            {
                case 1:
                    mes = "ene";
                    break;
                case 2:
                    mes = "feb";
                    break;
                case 3:
                    mes = "mar";
                    break;
                case 4:
                    mes = "abr";
                    break;
                case 5:
                    mes = "may";
                    break;
                case 6:
                    mes = "jun";
                    break;
                case 7:
                    mes = "jul";
                    break;
                case 8:
                    mes = "ago";
                    break;
                case 9:
                    mes = "sep";
                    break;
                case 10:
                    mes = "oct";
                    break;
                case 11:
                    mes = "nov";
                    break;
                case 12:
                    mes = "dic";
                    break;
            }

            return mes;
        }

        #endregion

        #region Constructors

        public FCT_MRP_New(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            comboBox1.Text = DateTime.Now.Year.ToString();
        }

        #endregion

        #region Form Events

        private void FCT_MRP_New_Load(object sender, EventArgs e)
        {
            #region Load Formulas Data

            try
            {
                proy_a = new DataSet();
                string query = @"   SELECT A.[id]
                                          ,A.[code] AS codigo
                                          ,A.[name] AS nombre
                                          ,B.[nombre] AS usuario
                                      FROM [dbo].[FCT_Proyecciones_Ventas_v2] A
                                      INNER JOIN [dbo].[conf_usuarios] B ON A.[created_by] = B.[id]
                                     WHERE A.[status] >= 40 AND A.[status] < 80";

                proy_a = dp.ACS_GetSelectData(query);

                grd_disponibles.DataSource = proy_a.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            #region Build Selected Formulas DS

            proy_s = new DataSet();

            proy_s.Tables.Add();

            proy_s.Tables[0].Columns.Add("id");
            proy_s.Tables[0].Columns.Add("codigo");
            proy_s.Tables[0].Columns.Add("nombre");
            proy_s.Tables[0].Columns.Add("usuario");

            grd_seleccionadas.DataSource = proy_s.Tables[0];

            #endregion
        }

        private void grdv_disponibles_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selDID = grdv_disponibles.GetRowCellValue(e.FocusedRowHandle, "id").ToString();
            }
            catch { }
        }

        private void grdv_seleccionadas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selSID = grdv_seleccionadas.GetRowCellValue(e.FocusedRowHandle, "id").ToString();
            }
            catch { }
        }

        private void grdv_disponibles_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataRow arow in proy_a.Tables[0].Rows)
            {
                if (arow["id"].ToString() == selDID)
                {
                    DataRow row = proy_s.Tables[0].Rows.Add();

                    row["id"] = arow["id"];
                    row["codigo"] = arow["codigo"];
                    row["nombre"] = arow["nombre"];
                    row["usuario"] = arow["usuario"];

                    proy_a.Tables[0].Rows.Remove(arow);

                    break;
                }
            }

            grd_disponibles.DataSource = proy_a.Tables[0];
            grd_seleccionadas.DataSource = proy_s.Tables[0];
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_Accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txt_name.Text != "")
                {
                    if(string.IsNullOrEmpty(comboBox1.Text))
                    {
                        CajaDialogo.Error("Es necesario especificar el año donde estará vigente el MRP!");
                        return;
                    }

                    int anio = 0;
                    try
                    {
                        anio = Convert.ToInt32(comboBox1.Text);
                    }
                    catch { }

                    if(anio == 0)
                    {
                        CajaDialogo.Error("Es necesario especificar el año donde estará vigente el MRP!");
                        return;
                    }

                    if (proy_s.Tables[0].Rows.Count > 0)
                    {
                        //SplashScreenManager.ShowForm(typeof(WaitForm1));

                        string insertedMRP = dp.ACS_InsertAndReturnID(@"   INSERT INTO [dbo].[FCT_MRP]
			                                                                      ([nombre]
			                                                                      ,[fecha_c]
			                                                                      ,[status]
			                                                                      ,[usuario_c]
                                                                                  ,[year])
		                                                                    VALUES('" + txt_name.Text.ToString() + @"'
			                                                                      ,SYSDATETIME()
			                                                                      ,'a'
			                                                                      ," +  this.UsuarioLogeado.UserId + 
                                                                                  "," + anio.ToString() + 
                                                                                  @"); SELECT SCOPE_IDENTITY();").ToString();

                        foreach (DataRow row in proy_s.Tables[0].Rows)
                        {
                            dp.ACS_DoSmallDBOperation(@"  INSERT INTO [dbo].[FCT_MRP_Proyecciones_v2]
			                                                     ([id_mrp]
			                                                     ,[id_pro])
	                                                      VALUES (" + insertedMRP + @"
			                                                     ," + row["id"].ToString() + @")");
                        }

                        DataSet Consumos = GetConsumos(proy_s);

                        foreach (DataRow row in Consumos.Tables[0].Rows) 
                        {
                            if (row.RowState != DataRowState.Deleted) 
                            {
                                for (int i = 1; i <= 4; i++)
                                {
                                    dp.ACS_DoSmallDBOperation(@" INSERT INTO [dbo].[FCT_MRP_D]
			                                                    ([id_mrp]
			                                                    ,[id_mp]
			                                                    ,[kind]
			                                                    ,[ene]
			                                                    ,[feb]
			                                                    ,[mar]
			                                                    ,[abr]
			                                                    ,[may]
			                                                    ,[jun]
			                                                    ,[jul]
			                                                    ,[ago]
			                                                    ,[sep]
			                                                    ,[oct]
			                                                    ,[nov]
			                                                    ,[dic])
		                                                  VALUES(" + insertedMRP + @"
			                                                    ," + row["id"].ToString() + @"
			                                                    ," + i.ToString() + @"
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000
			                                                    ,0.0000)");
                                }
                            }
                        }

                        //SplashScreenManager.CloseForm();

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al menos una proyección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe colocar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la Planeación de Requerimientos de Materiales\nDetalle del Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void grp_Nombre_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}