using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Clases;
using System.Collections;
using LOSA.Calidad.Parametros;

namespace LOSA.Calidad
{
    public partial class frmLotesStatus : Form
    {
        int gridActual = 1;
        UserLogin UsuarioLogeado;
        public string lote;
        public string ingreso;
        public int id_mp;
        public string CodigoP;
        public string Articulo;
        public int tipo_tm;
        public int id_turno;
        public frmLotesStatus(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            LoadTarimasAvailables();
            LoadTarimasObs();
            LoadTarimasRet();
            LoadTarimasRechazadas();
        }

        private void LoadTarimasAvailables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                //bit_muestreo
                SqlCommand cmd = new SqlCommand("sp_get_tarimas_habilitadas_calidad_V3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_disponibles.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_disponibles);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTarimasObs()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_obs_calidad_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_obs.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_obs);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTarimasRet()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_ret_calidad_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_ret.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_ret);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //click en editar

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //habilitado
            UpdateEstado(1);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Observacion
            ArrayList array = Grid_Get_Selected_Items();
            UpdateEstado(2);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Retenido
            //UpdateEstado(3);      
             int  id = 0;

            ArrayList array = Grid_Get_Selected_Items();
            int tipo_tm = 0;
            int contadorTm_MP = 0;
            int contadorTm_PT = 0;
            foreach (DataRow item in array)
            {
                tipo_tm = Convert.ToInt32(item["id_tipotm"]);
                if (tipo_tm == 1)
                {
                    contadorTm_MP = contadorTm_MP + 1;
                }
                else
                {
                    contadorTm_PT = contadorTm_PT + 1;
                }
                if (contadorTm_MP != 0)
                {
                    if (contadorTm_PT != 0)
                    {
                        CajaDialogo.Error("Solo puede seleccionar un tipo de tarima Ya sea producto terminado o Materia Prima");
                        return;
                    }
                }
                

            }
            if (array.Count > 0)
            {
                frm_asiganacion_causas frm = new frm_asiganacion_causas(UsuarioLogeado, array);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();
                    LoadTarimasRechazadas();
                }
            }

         
        }

        void UpdateEstado(int pIdEstadoNew)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                int id = 0;
                 ArrayList array = Grid_Get_Selected_Items();

                if (array.Count > 0)
                {
                    foreach (DataRow item in array)
                    {
                     

                        if (pIdEstadoNew == 1)
                        {
                            SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", con);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_tarima", item["id"]);
                            command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                            command.ExecuteNonQuery();
                        }

                        SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_estado", pIdEstadoNew);
                        cmd.Parameters.AddWithValue("@id", item["id"]);
                        cmd.ExecuteNonQuery();
                    }


                    con.Close();
                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();
                    LoadTarimasRechazadas();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gvMateriaPrima_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 1;
            }
        }

        private void gvMateriaPrima_DoubleClick(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 1;
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 2;
            }
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 3;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 2;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 3;
        }

        private ArrayList Grid_Get_Selected_Items()
        {

            switch (gridActual)
            {
                case 1:
                    if (gvMateriaPrima.SelectedRowsCount > 0)
                    {
                        ArrayList rows = new ArrayList();

                        for (int i = 0; i < gvMateriaPrima.SelectedRowsCount; i++)
                        {
                            if (gvMateriaPrima.GetSelectedRows()[i] >= 0)
                            {
                                rows.Add(gvMateriaPrima.GetDataRow(gvMateriaPrima.GetSelectedRows()[i]));
                            }
                        }

                        return rows;
                    }
                    else
                    {
                        return null;
                    }
                case 2:
                        if (gridView1.SelectedRowsCount > 0)
                        {
                            ArrayList rows = new ArrayList();

                            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                            {
                                if (gridView1.GetSelectedRows()[i] >= 0)
                                {
                                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                                }
                            }

                            return rows;
                        }
                        else
                        {
                            return null;
                        }
                case 3:
                        if (gridView2.SelectedRowsCount > 0)
                        {
                            ArrayList rows = new ArrayList();

                            for (int i = 0; i < gridView2.SelectedRowsCount; i++)
                            {
                                if (gridView2.GetSelectedRows()[i] >= 0)
                                {
                                    rows.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[i]));
                                }
                            }

                            return rows;
                        }
                        else
                        {
                            return null;
                        }
                default:
                    return null;
            }


           
        }
        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView2 = (GridView)gridRetenidos.FocusedView;
                var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                frmview frm = new frmview(row2.id, row2.mp, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();
                    LoadTarimasRechazadas();
                }
            }
            catch (Exception ex)
            {
                
            }

        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView2 = (GridView)grDisponibles.FocusedView;
                var row2 = (dsCalidad.tarimas_disponiblesRow)gridView2.GetFocusedDataRow();
                frmview frm = new frmview(row2.id, row2.mp, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                   

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btndetalle3_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView2 = (GridView)gridObservacion.FocusedView;
                var row2 = (dsCalidad.tarimas_obsRow)gridView2.GetFocusedDataRow();
                frmview frm = new frmview(row2.id, row2.mp, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();
                    LoadTarimasRechazadas();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnhabilitarL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusLote(1);
        }

        private void btnObservarL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusLote(2);
        }

        private void btnRetenerL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusLote(3);
        }
        public void UpdateStatusLote( int Estado)
        {

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();  
                switch (gridActual)
                {
                    case 1:
                            var gridView = (GridView)grDisponibles.FocusedView;
                            var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
                        if (row.id_tipotm == 1)
                        {
                            lote = row.lote;
                            ingreso = row.ingreso;
                            id_mp = row.id_mp;
                            CodigoP = row.codigomp;
                            Articulo = row.mp;
                            tipo_tm = row.id_tipotm;
                        }
                        else
                        {
                            lote = row.lote;
                            ingreso = " ";
                            id_mp = row.id_mp;
                            CodigoP = row.codigomp;
                            Articulo = row.mp;
                            tipo_tm = row.id_tipotm;
                        }
                             
                        break;
                    case 2:
                            var gridView1 = (GridView)gridObservacion.FocusedView;
                            var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        if (row1.id_tipotm == 1)
                        {
                            lote = row1.lote;
                            ingreso = row1.ingreso;
                            id_mp = row1.id_mp;
                            CodigoP = row1.codigomp;
                            Articulo = row1.mp;   
                            tipo_tm = row1.id_tipotm;
                        }
                        else
                        {
                            lote = row1.lote;
                            ingreso = " ";
                            id_mp = row1.id_mp;
                            CodigoP = row1.codigomp;
                            Articulo = row1.mp;
                            tipo_tm = row1.id_tipotm;
                        }
                        break;
                    case 3:
                            var gridView2 = (GridView)gridRetenidos.FocusedView;
                            var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                        if (row2.id_tipotm == 1)
                        {
                            lote = row2.lote;
                            ingreso = row2.ingreso;
                            id_mp = row2.id_mp;
                            CodigoP = row2.codigomp;
                            Articulo = row2.mp;
                            tipo_tm = row2.id_tipotm;
                        }
                        else
                        {
                            lote = row2.lote;
                            ingreso = " ";
                            id_mp = row2.id_mp;
                            CodigoP = row2.codigomp;
                            Articulo = row2.mp;
                            tipo_tm = row2.id_tipotm;
                        }
                        break;
                    default:
                        break;
                }
                switch (Estado)
                {
                    case 1: // Habilitado

                        if (gridActual != 1)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@lote", lote);
                            cmd.Parameters.AddWithValue("@bitloi", 1);
                            cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            cmd.Parameters.AddWithValue("@ingreso", ingreso);
                            cmd.Parameters.AddWithValue("@tipo_tm", tipo_tm);
                            dsCalidad1.Tarimas.Clear();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dsCalidad1.Tarimas);
                            foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            {

                                SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", cn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_tarima", row.IdTM);
                                command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                                command.ExecuteNonQuery();


                                cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", row.IdTM);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }
                        break;
                    case 2: //Observacion      
                        if (gridActual != 2)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@lote", lote);
                            cmd.Parameters.AddWithValue("@bitloi", 1);
                            cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            cmd.Parameters.AddWithValue("@ingreso", ingreso);
                            cmd.Parameters.AddWithValue("@tipo_tm", tipo_tm);
                            dsCalidad1.Tarimas.Clear();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dsCalidad1.Tarimas);
                            foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            {

                                 
                                cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", row.IdTM);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }  
                        break;
                    case 3: // Retenido
                        if (gridActual !=3)
                        {
                            frmcausasRetencion frm = new frmcausasRetencion(UsuarioLogeado
                                                                    , CodigoP
                                                                    , id_mp
                                                                    , ingreso
                                                                    , lote
                                                                    , Articulo
                                                                    , frmcausasRetencion.Tipo_Reten.Lote
                                                                    , tipo_tm);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadTarimasAvailables();
                                LoadTarimasObs();
                                LoadTarimasRet();
                                LoadTarimasRechazadas();
                            }
                        }


                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 1=Habilitado
        /// 2=Observacion
        /// 3=Retenido
        /// 4=Rechazado
        /// </summary>
        /// <param name="Estado"></param>
        public void UpdateStatusTarimas(int Estado)
        {
            try
            {
                DataOperations dp = new DataOperations();
                //SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                //con.Open();
                var gridViewHabilitado= (GridView)grDisponibles.FocusedView;
                var gridViewObservacion = (GridView)gridObservacion.FocusedView;
                var gridViewRetenido = (GridView)gridRetenidos.FocusedView;
                var gridViewRechazado = (GridView)gridRechazado.FocusedView;
                ArrayList ListaTarimas = null;
                bool existeMuestra = false;
                string lotePar = "";
                switch (gridActual)
                {
                    case 1://habilitado
                        
                        var row = (dsCalidad.tarimas_disponiblesRow)gridViewHabilitado.GetFocusedDataRow();
                        //if (row.id_tipotm == 2)
                        //{
                        //    CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                        //    return;
                        //}
                        //lote = row.lote;
                        //ingreso = row.ingreso;
                        //id_mp = row.id_mp;
                        //CodigoP = row.codigomp;
                        //Articulo = row.mp;
                        existeMuestra = row.bit_muestreo;
                        if (ListaTarimas == null)
                            ListaTarimas = new ArrayList();

                        tipo_tm = row.id_tipotm;
                        if (tipo_tm == 2)
                        {
                            lotePar = row.lote;
                        }

                        foreach (dsCalidad.tarimas_disponiblesRow rowHab in dsCalidad1.tarimas_disponibles.Rows)
                        {
                            if (rowHab.seleccionado)
                            {

                                if (rowHab.lote != lotePar && tipo_tm == 2)
                                {
                                    CajaDialogo.Error("En Producto terminado, no puede liberar varios lotes a la vez.");
                                    return;
                                }
                                ListaTarimas.Add(rowHab.id);
                            }
                        }
                       
                        break;
                    case 2://observacion
                        
                        var row1 = (dsCalidad.tarimas_obsRow)gridViewObservacion.GetFocusedDataRow();
                        //if (row1.id_tipotm == 2)
                        //{
                        //    CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                        //    return;
                        //}
                        //lote = row1.lote;
                        //ingreso = row1.ingreso;
                        //id_mp = row1.id_mp;
                        //CodigoP = row1.codigomp;
                        //Articulo = row1.mp;
                        if (ListaTarimas == null)
                            ListaTarimas = new ArrayList();
                        tipo_tm = row1.id_tipotm;
                        if (tipo_tm == 2)
                        {
                            lotePar = row1.lote;
                        }

                        foreach (dsCalidad.tarimas_obsRow rowHab in dsCalidad1.tarimas_obs.Rows)
                        {
                            if (rowHab.seleccionado)
                            {
                                if (rowHab.lote != lotePar && tipo_tm == 2)
                                {
                                    CajaDialogo.Error("En Producto terminado, no puede liberar varios lotes a la vez.");
                                    return;
                                }
                            }
                        }

                        existeMuestra = row1.bit_muestreo;
                        tipo_tm = row1.id_tipotm;

                        break;
                    case 3://Retenido
                        
                        var row2 = (dsCalidad.tarimas_retRow)gridViewRetenido.GetFocusedDataRow();
                        //if (row2.id_tipotm == 2)
                        //{
                        //    CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                        //    return;
                        //}
                        //lote = row2.lote;
                        //ingreso = row2.ingreso;
                        //id_mp = row2.id_mp;
                        //CodigoP = row2.codigomp;
                        //Articulo = row2.mp;
                       
                        if (ListaTarimas == null)
                            ListaTarimas = new ArrayList();
                        tipo_tm = row2.id_tipotm;
                        if (tipo_tm == 2)
                        {
                            lotePar = row2.lote;
                        }

                        foreach (dsCalidad.tarimas_retRow rowHab in dsCalidad1.tarimas_ret.Rows)
                        {
                            if (rowHab.seleccionado)
                            {
                                if (rowHab.lote != lotePar && tipo_tm == 2)
                                {
                                    CajaDialogo.Error("En Producto terminado, no puede liberar varios lotes a la vez.");
                                    return;
                                }
                                ListaTarimas.Add(rowHab.id);
                            }
                        }

                        existeMuestra = row2.bit_muestreo;
                        tipo_tm = row2.id_tipotm;
                        break;
                    case 4://Rechazado
                        
                        var row3 = (dsCalidad.tarimas_rechazadasRow)gridViewRechazado.GetFocusedDataRow();
                        //if (row3.id_tipotm == 2)
                        //{
                        //    CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                        //    return;
                        //}
                        //lote = row3.lote;
                        //ingreso = row3.ingreso;
                        //id_mp = row3.id_mp;
                        //CodigoP = row3.codigomp;
                        //Articulo = row3.mp;
                        
                        if (ListaTarimas == null)
                            ListaTarimas = new ArrayList();

                        foreach (dsCalidad.tarimas_rechazadasRow rowHab in dsCalidad1.tarimas_rechazadas.Rows)
                        {
                            if (rowHab.seleccionado)
                            {
                                ListaTarimas.Add(rowHab.id);
                            }
                        }

                        existeMuestra = row3.bit_muestreo;
                        tipo_tm = row3.id_tipotm;

                        break;
                    default:
                        break;
                }

                if (ListaTarimas != null)
                {
                    if (ListaTarimas.Count <= 0)
                    {
                        CajaDialogo.Error("Debe seleccionar el registro para poder aplicar el cambio!");
                        return;
                    }
                }

                if(tipo_tm == 1)//MP no tenemos el tipo MP, aun.
                {
                    UpdateStatusMPByTarima(Estado, ListaTarimas);
                }
                else if (tipo_tm == 2)
                {
                    if (!existeMuestra)
                    {
                        bool AgregarMuestras = false;
                        if (Estado == 1)
                        {
                            AgregarMuestras = true;
                        }
                        else
                        {
                            if (MessageBox.Show("No existe muestreo a la tarima seleccionada, deseas ingresar la informacion?", "Pregunta sobre Muestreo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                AgregarMuestras = true;
                            }
                            else
                            {
                                AgregarMuestras = false;
                            }
                        }
                        if (AgregarMuestras)
                        {
                            FrmRegistroMuestreo frm = new FrmRegistroMuestreo(ListaTarimas, lotePar, UsuarioLogeado);
                            switch (frm.ShowDialog())
                            {
                                case DialogResult.Yes:

                                    UpdateStatusTarimaPT(1, ListaTarimas);
                                    break;
                                case DialogResult.No:
                                    // VA A rechazado.
                                    UpdateStatusTarimaPT(4, ListaTarimas);
                                    break;
                                case DialogResult.Cancel:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {

                            UpdateStatusTarimaPT(Estado, ListaTarimas);
                        }
                    }
                    else
                    {

                        UpdateStatusTarimaPT(Estado, ListaTarimas);
                    }
                }
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void UpdateStatusTarimaPT(int pEstado, ArrayList ListaTarimas)
        {
            int Estado = pEstado;
            try
            {
                DataOperations dp = new DataOperations();
                //SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                //con.Open();
                
                switch (Estado)
                {
                    case 1:     // Estamos Habilitando
                        if (gridActual != 1)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            foreach (int idtarima in ListaTarimas)
                            {

                                SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", cn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_tarima", idtarima);
                                command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                                command.ExecuteNonQuery();


                                SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", idtarima);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }
                        break;
                    case 2:        // Estamos Mandando a Observacion

                        if (gridActual != 2)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            //SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote_v2", cn);
                            //cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            //cmd.Parameters.AddWithValue("@id_turno", id_turno);
                            //cmd.Parameters.AddWithValue("@lote", lote);
                            //dsCalidad1.Tarimas.Clear();
                            //SqlDataAdapter da = new SqlDataAdapter(cmd);
                            //da.Fill(dsCalidad1.Tarimas);
                            //foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            foreach (int idtarima in ListaTarimas)
                            {

                                SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", idtarima);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }
                        break;
                    case 3:        // Estamos reteniendo
                        if (gridActual != 3)
                        {
                            frm_retencionesPT frm = new frm_retencionesPT(UsuarioLogeado
                                                                    , ListaTarimas
                                                                    , 3
                                                                    //, id_mp
                                                                    //, ingreso
                                                                    //, lote
                                                                    //, Articulo
                                                                    //, 1
                                                                    //, id_turno
                                                                    );
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadTarimasAvailables();
                                LoadTarimasObs();
                                LoadTarimasRet();
                                LoadTarimasRechazadas();
                            }
                        }
                        break;
                    case 4:
                        if (gridActual != 4)
                        {
                            frm_retencionesPT frm = new frm_retencionesPT(UsuarioLogeado
                                                                    , ListaTarimas
                                                                    , 4
                                                                    //, id_mp
                                                                    //, ingreso
                                                                    //, lote
                                                                    //, Articulo
                                                                    //, 1
                                                                    //, id_turno
                                                                    );
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadTarimasAvailables();
                                LoadTarimasObs();
                                LoadTarimasRet();
                                LoadTarimasRechazadas();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void UpdateStatusMPByTarima(int Estado, ArrayList ListaTarimas)
        {
            DataOperations dp = new DataOperations();
            switch (Estado)
            {
                case 1: // Habilitado

                    if (gridActual != 1)
                    {
                        #region OldCodigo Estado=Hablitado
                        //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        //cn.Open();

                        //SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote", cn);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@lote", lote);
                        //cmd.Parameters.AddWithValue("@bitloi", 0);
                        //cmd.Parameters.AddWithValue("@id_mp", id_mp);
                        //cmd.Parameters.AddWithValue("@ingreso", ingreso); 
                        //cmd.Parameters.AddWithValue("@tipo_tm", tipo_tm);
                        //dsCalidad1.Tarimas.Clear();
                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //da.Fill(dsCalidad1.Tarimas);
                        //foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                        //{

                        //    SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", cn);
                        //    command.CommandType = CommandType.StoredProcedure;
                        //    command.Parameters.AddWithValue("@id_tarima", row.IdTM);
                        //    command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                        //    command.ExecuteNonQuery();


                        //    cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("@id_estado", Estado);
                        //    cmd.Parameters.AddWithValue("@id", row.IdTM);
                        //    cmd.ExecuteNonQuery();

                        //}
                        #endregion
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        foreach (int idTarima in ListaTarimas)
                        {

                            SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", cn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_tarima", idTarima);
                            command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                            command.ExecuteNonQuery();

                            SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estado", Estado);//1=Habilitado
                            cmd.Parameters.AddWithValue("@id", idTarima);
                            cmd.ExecuteNonQuery();

                        }

                        cn.Close();
                        LoadTarimasAvailables();
                        LoadTarimasObs();
                        LoadTarimasRet();
                        LoadTarimasRechazadas();
                    }
                    break;
                case 2: //Observacion      
                    if (gridActual != 2)
                    {
                        #region Old Code Observacion
                        //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        //cn.Open();

                        //SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote", cn);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@lote", lote);
                        //cmd.Parameters.AddWithValue("@bitloi", 0);
                        //cmd.Parameters.AddWithValue("@id_mp", id_mp);
                        //cmd.Parameters.AddWithValue("@ingreso", ingreso);
                        //cmd.Parameters.AddWithValue("@tipo_tm", tipo_tm);
                        //dsCalidad1.Tarimas.Clear();
                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //da.Fill(dsCalidad1.Tarimas);
                        //foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                        //{

                        //    cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("@id_estado", Estado);
                        //    cmd.Parameters.AddWithValue("@id", row.IdTM);
                        //    cmd.ExecuteNonQuery();

                        //}
                        #endregion

                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        //foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                        foreach (int idTarima in ListaTarimas)
                        {
                            SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_estado", 2);//observacion
                            cmd.Parameters.AddWithValue("@id", idTarima);
                            cmd.ExecuteNonQuery();

                        }
                        cn.Close();
                        LoadTarimasAvailables();
                        LoadTarimasObs();
                        LoadTarimasRet();
                        LoadTarimasRechazadas();
                    }
                    break;
                case 3: // Retenido
                    #region Old Code Retenido
                    //if (gridActual != 3)
                    //{
                    //    frmcausasRetencion frm = new frmcausasRetencion(UsuarioLogeado
                    //                                            , CodigoP
                    //                                            , id_mp
                    //                                            , ingreso
                    //                                            , lote
                    //                                            , Articulo
                    //                                            , frmcausasRetencion.Tipo_Reten.Ingreso
                    //                                            , 1);
                    //    if (frm.ShowDialog() == DialogResult.OK)
                    //    {
                    //        LoadTarimasAvailables();
                    //        LoadTarimasObs();
                    //        LoadTarimasRet();
                    //        LoadTarimasRechazadas();
                    //    }
                    //}
                    #endregion
                    if (gridActual != 3)
                    {


                        if (ListaTarimas != null)
                        {
                            if (ListaTarimas.Count > 0)
                            {
                                frmcausasRetencionComplete frm = new frmcausasRetencionComplete(UsuarioLogeado,
                                                                                                ListaTarimas
                                                                                                //, CodigoP
                                                                                                //, id_mp
                                                                                                //, ingreso
                                                                                                //, lote
                                                                                                //, Articulo
                                                                                                //, frmcausasRechazo.Tipo_Reten.Ingreso
                                                                                                , 1);
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    LoadTarimasAvailables();
                                    LoadTarimasObs();
                                    LoadTarimasRet();
                                    LoadTarimasRechazadas();
                                }
                            }
                        }
                    }

                    break;
                case 4: // Rechazado
                    if (gridActual != 4)
                    {
                        if (ListaTarimas != null)
                        {
                            if (ListaTarimas.Count > 0)
                            {
                                frmcausasRechazo frm = new frmcausasRechazo(UsuarioLogeado,
                                                                            ListaTarimas
                                                                            //, CodigoP
                                                                            //, id_mp
                                                                            //, ingreso
                                                                            //, lote
                                                                            //, Articulo
                                                                            //, frmcausasRechazo.Tipo_Reten.Ingreso
                                                                            , 1);
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    LoadTarimasAvailables();
                                    LoadTarimasObs();
                                    LoadTarimasRet();
                                    LoadTarimasRechazadas();
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }


        private void LoadTarimasRechazadas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_rechazadas_calidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_rechazadas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_rechazadas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnRetenerIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusTarimas(3);
        }

        private void btnhabilitarIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusTarimas(1);
        }

        private void btnObservacionIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusTarimas(2);
        }

        public void UpdataeStatusPT(int Estado)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                switch (gridActual)
                {
                    case 1:   // Habilitado.
                        var gridView = (GridView)grDisponibles.FocusedView;
                        var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
                        if (row.id_tipotm == 1)
                        {
                            CajaDialogo.Information("No se puede habilitar materia prima por turno.");
                            return;
                        }
                        if (row.id_turno == 0)
                        {
                            CajaDialogo.Information("La tarima seleccionada no se le configuro el turno.");
                            return;
                        }
                        lote = row.lote;
                        id_mp = row.id_mp;
                        CodigoP = row.codigomp;
                        Articulo = row.mp;
                        tipo_tm = row.id_tipotm;
                        id_turno = row.id_turno;


                        break;
                    case 2:   // Observacion.
                        var gridView1 = (GridView)gridObservacion.FocusedView;
                        var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        if (row1.id_tipotm == 1)
                        {
                            CajaDialogo.Information("No se puede habilitar materia prima por turno.");
                            return;
                        }
                        if (row1.id_turno == 0)
                        {
                            CajaDialogo.Information("La tarima seleccionada no se le configuro el turno.");
                            return;
                        }
                        lote = row1.lote;
                        id_mp = row1.id_mp;
                        CodigoP = row1.codigomp;
                        Articulo = row1.mp;
                        tipo_tm = row1.id_tipotm;
                        id_turno = row1.id_turno;
                        break;
                    case 3:   // Bloqueado.
                        var gridView2 = (GridView)gridRetenidos.FocusedView;
                        var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                        if (row2.id_tipotm == 1)
                        {
                            CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                            return;
                        }
                        if (row2.id_turno == 0)
                        {
                            CajaDialogo.Information("La tarima seleccionada no se le configuro el turno.");
                            return;
                        }
                        lote = row2.lote;
                        id_mp = row2.id_mp;
                        CodigoP = row2.codigomp;
                        Articulo = row2.mp;

                        tipo_tm = row2.id_tipotm;
                        id_turno = row2.id_turno;

                        break;
                    default:
                        break;


                }

                switch (Estado)
                {
                    case 1:     // Estamos Habilitando
                        if (gridActual != 1)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote_v2", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            cmd.Parameters.AddWithValue("@id_turno", id_turno);
                            cmd.Parameters.AddWithValue("@lote", lote);
                            dsCalidad1.Tarimas.Clear();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dsCalidad1.Tarimas);
                            foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            {

                                SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", cn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_tarima", row.IdTM);
                                command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                                command.ExecuteNonQuery();


                                cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", row.IdTM);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }
                        break;
                    case 2:        // Estamos Mandando a Observacion

                        if (gridActual != 2)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote_v2", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            cmd.Parameters.AddWithValue("@id_turno", id_turno);
                            cmd.Parameters.AddWithValue("@lote", lote);
                            dsCalidad1.Tarimas.Clear();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dsCalidad1.Tarimas);
                            foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            {

                                cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", row.IdTM);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }
                        break;
                    case 3:        // Estamos reteniendo

                        if (gridActual != 3)
                        {
                            frm_retenciones frm = new frm_retenciones(UsuarioLogeado
                                                                    , CodigoP
                                                                    , id_mp
                                                                    , ingreso
                                                                    , lote
                                                                    , Articulo
                                                                    , 1
                                                                    , id_turno);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadTarimasAvailables();
                                LoadTarimasObs();
                                LoadTarimasRet();
                                LoadTarimasRechazadas();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void UpdataeStatusByTurno(int Estado) 
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                switch (gridActual)
                {
                    case 1:   // Habilitado.
                        var gridView = (GridView)grDisponibles.FocusedView;
                        var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
                        if (row.id_tipotm == 1)
                        {
                            CajaDialogo.Information("No se puede habilitar materia prima por turno.");
                            return;
                        }
                        if (row.id_turno == 0)
                        {
                            CajaDialogo.Information("La tarima seleccionada no se le configuro el turno.");
                            return;
                        }
                        lote = row.lote;
                        id_mp = row.id_mp;
                        CodigoP = row.codigomp;
                        Articulo = row.mp;
                        tipo_tm = row.id_tipotm;
                        id_turno = row.id_turno;


                        break;
                    case 2:   // Observacion.
                        var gridView1 = (GridView)gridObservacion.FocusedView;
                        var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        if (row1.id_tipotm == 1)
                        {
                            CajaDialogo.Information("No se puede habilitar materia prima por turno.");
                            return;
                        }
                        if (row1.id_turno == 0)
                        {
                            CajaDialogo.Information("La tarima seleccionada no se le configuro el turno.");
                            return;
                        }
                        lote = row1.lote;
                        id_mp = row1.id_mp;
                        CodigoP = row1.codigomp;
                        Articulo = row1.mp;
                        tipo_tm = row1.id_tipotm;
                        id_turno = row1.id_turno;
                        break;
                    case 3:   // Bloqueado.
                                var gridView2 = (GridView)gridRetenidos.FocusedView;
                                var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                                if (row2.id_tipotm == 1)
                                {
                                    CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                                    return;
                                }
                                if (row2.id_turno == 0)
                                {
                                    CajaDialogo.Information("La tarima seleccionada no se le configuro el turno.");
                                    return;
                                }
                        lote = row2.lote;
                                id_mp = row2.id_mp;
                                CodigoP = row2.codigomp;
                                Articulo = row2.mp;

                                tipo_tm = row2.id_tipotm;
                                 id_turno = row2.id_turno;

                        break;
                    default:
                        break;

                      
                }

                switch (Estado)
                {
                    case 1:     // Estamos Habilitando
                        if (gridActual != 1)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote_v2", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            cmd.Parameters.AddWithValue("@id_turno", id_turno);
                            cmd.Parameters.AddWithValue("@lote", lote);
                            dsCalidad1.Tarimas.Clear();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dsCalidad1.Tarimas);
                            foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            {

                                SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", cn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@id_tarima", row.IdTM);
                                command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                                command.ExecuteNonQuery();


                                cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", row.IdTM);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }
                        break;
                    case 2:        // Estamos Mandando a Observacion

                        if (gridActual != 2)
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("sp_load_idtm_from_lote_v2", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_mp", id_mp);
                            cmd.Parameters.AddWithValue("@id_turno", id_turno);
                            cmd.Parameters.AddWithValue("@lote", lote);
                            dsCalidad1.Tarimas.Clear();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dsCalidad1.Tarimas);
                            foreach (dsCalidad.TarimasRow row in dsCalidad1.Tarimas.Rows)
                            {

                                cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_estado", Estado);
                                cmd.Parameters.AddWithValue("@id", row.IdTM);
                                cmd.ExecuteNonQuery();

                            }
                            cn.Close();
                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                            LoadTarimasRechazadas();
                        }   
                        break;
                    case 3:        // Estamos reteniendo

                        if (gridActual != 3)
                        {
                            frm_retenciones frm = new frm_retenciones(UsuarioLogeado
                                                                    , CodigoP
                                                                    , id_mp
                                                                    , ingreso
                                                                    , lote
                                                                    , Articulo
                                                                    , 1
                                                                    , id_turno);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadTarimasAvailables();
                                LoadTarimasObs();
                                LoadTarimasRet();
                                LoadTarimasRechazadas();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btn_Habilitar_turno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdataeStatusByTurno(1);
        }

        private void btnObservacionTurno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdataeStatusByTurno(2);
        }

        private void btnRetenidoTurno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdataeStatusByTurno(3);
        }

        private void barButtonRechazarIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusTarimas(4);
        }

        private void gridView3_RowClick(object sender, RowClickEventArgs e)
        {
            //Row Click Rechazado
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 4;
            }
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            //Double Click Rechazado
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 4;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //UpdateEstado(1);

         
            UpdateStatusTarimas(1);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Observacion
            //ArrayList array = Grid_Get_Selected_Items();
            //UpdateEstado(2);
            UpdateStatusTarimas(2);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ////Retenido
            ////UpdateEstado(3);      
            //int id = 0;

            //ArrayList array = Grid_Get_Selected_Items();
            //int tipo_tm = 0;
            //int contadorTm_MP = 0;
            //int contadorTm_PT = 0;
            //foreach (DataRow item in array)
            //{
            //    tipo_tm = Convert.ToInt32(item["id_tipotm"]);
            //    if (tipo_tm == 1)
            //    {
            //        contadorTm_MP = contadorTm_MP + 1;
            //    }
            //    else
            //    {
            //        contadorTm_PT = contadorTm_PT + 1;
            //    }
            //    if (contadorTm_MP != 0)
            //    {
            //        if (contadorTm_PT != 0)
            //        {
            //            CajaDialogo.Error("Solo puede seleccionar un tipo de tarima Ya sea producto terminado o Materia Prima");
            //            return;
            //        }
            //    }


            //}
            //if (array.Count > 0)
            //{
            //    frm_asiganacion_causas frm = new frm_asiganacion_causas(UsuarioLogeado, array);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {

            //        LoadTarimasAvailables();
            //        LoadTarimasObs();
            //        LoadTarimasRet();
            //        LoadTarimasRechazadas();
            //    }
            //}
            UpdateStatusTarimas(3);
        }

        private void checkDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            int contaHab = dsCalidad1.tarimas_disponibles.Count;
            var gridViewHabilitado = (GridView)grDisponibles.FocusedView;
            for (int i = 0; i < contaHab; i++)
            {
                dsCalidad.tarimas_disponiblesRow rowHab = (dsCalidad.tarimas_disponiblesRow)gridViewHabilitado.GetDataRow(i);
                int r = gridViewHabilitado.GetVisibleRowHandle(i + 1);
                if (r >= 0)
                {
                    if (rowHab != null)
                    {
                        rowHab.seleccionado = checkDisponibles.Checked;
                        //ListaTarimas.Add(rowHab.id);
                    }
                }
                else
                {
                    if (rowHab != null)
                        rowHab.seleccionado = false;
                }
            }
        }

        private void checkObservacion_CheckedChanged(object sender, EventArgs e)
        {
            var gridViewObservacion = (GridView)gridObservacion.FocusedView;
            int contaObs = dsCalidad1.tarimas_obs.Count;
            for (int i = 0; i < contaObs; i++)
            {
                dsCalidad.tarimas_obsRow rowObs = (dsCalidad.tarimas_obsRow)gridViewObservacion.GetDataRow(i);
                int r = gridViewObservacion.GetVisibleRowHandle(i + 1);
                if (r >= 0)
                {
                    if (rowObs != null)
                    {
                        rowObs.seleccionado = checkObservacion.Checked;
                        //ListaTarimas.Add(rowObs.id);
                    }
                }
                else
                {
                    if (rowObs != null)
                        rowObs.seleccionado = false;
                }
            }
        }

        private void checkRetenido_CheckedChanged(object sender, EventArgs e)
        {
            var gridViewRetenido = (GridView)gridRetenidos.FocusedView;
            int conta = dsCalidad1.tarimas_ret.Count;
            for (int i = 0; i < conta; i++)
            {
                dsCalidad.tarimas_retRow rowRet = (dsCalidad.tarimas_retRow)gridViewRetenido.GetDataRow(i);
                int r = gridViewRetenido.GetVisibleRowHandle(i + 1);
                if (r >= 0)
                {
                    if (rowRet != null)
                    {
                        rowRet.seleccionado = checkRetenido.Checked;
                        //ListaTarimas.Add(rowRet.id);
                    }
                }
                else
                {
                    if (rowRet != null)
                        rowRet.seleccionado = false;
                }
            }
        }

        private void checkRechazado_CheckedChanged(object sender, EventArgs e)
        {
            var gridViewRechazado = (GridView)gridRechazado.FocusedView;
            int contaRec = dsCalidad1.tarimas_rechazadas.Count;
            for (int i = 0; i < contaRec; i++)
            {
                dsCalidad.tarimas_rechazadasRow rowRec = (dsCalidad.tarimas_rechazadasRow)gridViewRechazado.GetDataRow(i);
                int r = gridViewRechazado.GetVisibleRowHandle(i + 1);
                if (r >= 0)
                {
                    if (rowRec != null)
                    {
                        rowRec.seleccionado = checkRechazado.Checked;
                        //ListaTarimas.Add(rowRec.id);
                    }
                }
                else
                {
                    if (rowRec != null)
                        rowRec.seleccionado = false;
                }
            }
        }

        private void gvMateriaPrima_ColumnFilterChanged(object sender, EventArgs e)
        {
            checkDisponibles.CheckedChanged -= new EventHandler(checkDisponibles_CheckedChanged);
            checkDisponibles.Checked = false;
            checkDisponibles.CheckedChanged += new EventHandler(checkDisponibles_CheckedChanged);
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            checkObservacion.CheckedChanged -= new EventHandler(checkObservacion_CheckedChanged);
            checkObservacion.Checked = false;
            checkObservacion.CheckedChanged += new EventHandler(checkObservacion_CheckedChanged);
        }

        private void gridView2_ColumnFilterChanged(object sender, EventArgs e)
        {
            checkRetenido.CheckedChanged -= new EventHandler(checkRetenido_CheckedChanged);
            checkRetenido.Checked = false;
            checkRetenido.CheckedChanged += new EventHandler(checkRetenido_CheckedChanged);
        }

        private void gridView3_ColumnFilterChanged(object sender, EventArgs e)
        {
            checkRechazado.CheckedChanged -= new EventHandler(checkRechazado_CheckedChanged);
            checkRechazado.Checked = false;
            checkRechazado.CheckedChanged += new EventHandler(checkRechazado_CheckedChanged);
        }
    }
}
