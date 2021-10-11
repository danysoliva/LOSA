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
           
        }

        private void LoadTarimasAvailables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

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

        public void UpdateStatusIngreso(int Estado)
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
                        if (row.id_tipotm == 2)
                        {
                            CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                            return;
                        }
                        lote = row.lote;
                        ingreso = row.ingreso;
                        id_mp = row.id_mp;
                        CodigoP = row.codigomp;
                        Articulo = row.mp;
                        tipo_tm = row.id_tipotm;
                        
                        break;
                    case 2:
                        var gridView1 = (GridView)gridObservacion.FocusedView;
                        var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        if (row1.id_tipotm == 2)
                        {
                            CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                            return;
                        }
                        lote = row1.lote;
                        ingreso = row1.ingreso;
                        id_mp = row1.id_mp;
                        CodigoP = row1.codigomp;
                        Articulo = row1.mp;

                        tipo_tm = row1.id_tipotm;

                        break;
                    case 3:
                        var gridView2 = (GridView)gridRetenidos.FocusedView;
                        var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                        if (row2.id_tipotm == 2)
                        {
                            CajaDialogo.Information("Los movimientos por ingreso en producto terminado no estan habilitados.");
                            return;
                        }
                        lote = row2.lote;
                        ingreso = row2.ingreso;
                        id_mp = row2.id_mp;
                        CodigoP = row2.codigomp;
                        Articulo = row2.mp;

                        tipo_tm = row2.id_tipotm;


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
                            cmd.Parameters.AddWithValue("@bitloi", 0);
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
                            cmd.Parameters.AddWithValue("@bitloi", 0);
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

                        }
                        break;
                    case 3: // Retenido
                        if (gridActual != 3)
                        {
                            frmcausasRetencion frm = new frmcausasRetencion(UsuarioLogeado
                                                                    , CodigoP
                                                                    , id_mp
                                                                    , ingreso
                                                                    , lote
                                                                    , Articulo
                                                                    , frmcausasRetencion.Tipo_Reten.Ingreso
                                                                    , 1);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadTarimasAvailables();
                                LoadTarimasObs();
                                LoadTarimasRet();
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

        private void btnRetenerIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusIngreso(3);
        }

        private void btnhabilitarIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusIngreso(1);
        }

        private void btnObservacionIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusIngreso(2);
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
    }
}
