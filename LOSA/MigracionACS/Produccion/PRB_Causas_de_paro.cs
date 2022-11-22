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
using System.Data.SqlClient;
namespace LOSA.MigracionACS.Produccion

{
    public partial class PRB_Causas_de_paro : Form
    {
        DataOperations dp = new DataOperations();
        DateTime fechain;
        DateTime fechafin;
        int idTipoCausa;
        int idmaquina;
        string turnos;
        string Maquinas;
        public PRB_Causas_de_paro(DateTime ini, DateTime fin, int pid_tipoCausa, int Paridmaquina, int parturno)
        {
            InitializeComponent();
            fechafin = fin;
            fechain = ini;
            idTipoCausa = pid_tipoCausa;
            idmaquina = Paridmaquina;

            int turno1 = 1;
            int turno2 = 2;
            int turno3 = 3;


            if (parturno == 1)
            {
                turno2 = 0;
                turno3 = 0;
            }
            
            if (parturno == 2)
            {
                turno1 = 0;
                turno3 = 0;
            }
            
            if (parturno == 3)
            {
                turno1 = 0;
                turno2 = 0;
            }


            //Maquina
            int Pellet1 = 1;
            int Pellet2 = 2;
            int Extruder = 3;


            switch (idmaquina)
            {
                case 1://Pellet 1
                    Pellet2 = 0;
                    Extruder = 0;
                    break;
                case 2://Pellet 2
                    Pellet1 = 0;
                    Extruder = 0;
                    break;
                case 3://Ambas Pellet
                    Extruder = 0;
                    break;
                case 4://Solo extruder
                    Pellet2 = 0;
                    Pellet1 = 0;
                    break;
                case 5://Todas las maquinas
                    //Pellet2
                    //Pellet2 = 0;
                    //Extruder = 0;
                    break;
                default:
                    break;
            }

            turnos = turno1 + "," + turno2 + "," + turno3;
            Maquinas = Pellet1 + "," + Pellet2 + "," + Extruder;
            data_op();
        }

        public void data_op()
        {
            string desde;
             desde = fechain.ToString("yyyy-MM-dd HH:mm");

            string hasta;
            hasta = fechafin.ToString("yyyy-MM-dd HH:mm");
            String query = @"Select  T4.id
	                                ,T0.fecha_ini as fecha
	                                ,T4.horacausa as duracion
	                                ,T5.descripcion
	                                ,T4.comentario
									,T6.nombre
                                from dbo.PRB_Registro_H T0 
								    --join dbo.PRB_Registro_D T1 On T0.id = T1.id_h
									join dbo.PRB_Turno T3 ON T3.id = T0.idturno
									join dbo.PRB_Transac_Regis_Caus T4 ON T4.id_registro = T0.id
									join dbo.PRB_Causa T5 on T4.id_causa = T5.id
									join dbo.conf_usuarios  T6 ON T0.user_code = T6.id 
									join dbo.PRB_Causa_Tipo T7 ON T5.id_tipo = T7.id
                            where T0.fecha_ini >= @fechaini and T0.fecha_ini <= @fechafin
                                  and T4.enable = 1
                                  and T7.id = @idtipo_causa
                                  and T4.id_linea in (" + Maquinas + @") 
                                  and T0.idturno in (" + turnos + ")";

            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = hasta;
                cmd.Parameters.Add("@idtipo_causa", SqlDbType.Int).Value = idTipoCausa;
                cmd.Parameters.Add("@idmaquina", SqlDbType.Int).Value = idmaquina;
                //cmd.Parameters.Add("@turno", SqlDbType.Int).Value = turno;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA2.causasview.Clear();
                da.Fill(pRB_DATA2.causasview);
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

            string query_grafico = @"select tab2.causa,
	                                        tab2.horaint
	                                        ,(cast(tab2.horas as varchar(2)) + ':' + tab2.mins)as horas

                                    from(						
                                    select tab.causa
	                                        ,tab.horaint
	                                        ,case when len(cast(tab.horaint as integer))<2 then
			                                    '0'+ cast(cast(tab.horaint as integer)as varchar)
		                                    else
			                                    cast(cast(tab.horaint as integer)as varchar)
		                                    end as horas
	  
	                                        ,case when len(cast(((tab.horaint- cast(tab.horaint as integer))*60) as integer)) <2 then
			                                    '0'+ cast(cast(((tab.horaint- cast(tab.horaint as integer))*60) as integer) as varchar)
		                                    else
			                                    cast(cast(((tab.horaint- cast(tab.horaint as integer))*60) as integer) as varchar)
		                                    end as mins
                                    from(								
                                    select coalesce(sum(cast((DATEPART(HOUR, T4.[horacausa])) + ((cast(DATEPART(MINUTE, T4.[horacausa]) as decimal)/60)) as decimal(10,2)) ),0) as horaint
		                                    ,T5.causa
                                    from dbo.PRB_Registro_H T0 
	                                    --join dbo.PRB_Registro_D T1 On T0.id = T1.id_h
	                                    join dbo.PRB_Turno T3 ON T3.id = T0.idturno
	                                    join dbo.PRB_Transac_Regis_Caus T4 ON T4.id_registro = T0.id
	                                    join dbo.PRB_Causa T5 on T4.id_causa = T5.id
	                                    join dbo.conf_usuarios  T6 ON T0.user_code = T6.id 
	                                    join dbo.PRB_Causa_Tipo T7 ON T5.id_tipo = T7.id
                                    where T0.fecha_ini >= @fechaini and T0.fecha_ini <= @fechafin
                                        and T7.id = @idtipo_causa
                                        and T4.id_linea in (" + Maquinas + @") 
                                        and T0.idturno in (" + turnos + @") 
                                    group by T5.id, T5.causa)as tab )as tab2 
                                    order by 2 asc";
            try
            {
                //cn.Open();
                SqlCommand cmd = new SqlCommand(query_grafico, cn);
                cmd.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = hasta;
                cmd.Parameters.Add("@idtipo_causa", SqlDbType.Int).Value = idTipoCausa;
                //cmd.Parameters.Add("@idmaquina", SqlDbType.Int).Value = idmaquina;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA2.grafico_fallas.Clear();
                da.Fill(pRB_DATA2.grafico_fallas);
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnclose_ItemClick(object ser, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ItemClick
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grd_main.ExportToXlsx(dialog.FileName);
        }

        private void grdv_main_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenuExcel.ShowPopup(Cursor.Position);
            }
        }
    }
}
