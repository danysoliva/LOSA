using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.Logistica
{
    public partial class frm_nuevaSemanaPlan : DevExpress.XtraEditors.XtraForm
    {
        Plan_Semanal Plan = new Plan_Semanal();
        int id_created;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frm_nuevaSemanaPlan(UserLogin Puser)
        {
            UsuarioLogeado = Puser;
            InitializeComponent();
        }

        public int Id_created { get => id_created; set => id_created = value; }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Plan.Week == 0)
            {
                CajaDialogo.Error("Debe seleccionar una fecha en la cual este dentro de la semana que se desea configurar.");
                return;
            }
            Plan.User_sing = UsuarioLogeado.Id;
            id_created = Plan.set_new_plan(); 
            this.DialogResult = DialogResult.OK;

        }

        private void dt_fecha_pick_EditValueChanged(object sender, EventArgs e)
        {
            if (Plan.Get_Week_Before_set(dt_fecha_pick.DateTime))
            {
                txtsemana.Text = Plan.Week.ToString();
                dt_inicio.DateTime = Plan.Date_begin;
                dt_fin.DateTime = Plan.Date_end;
            }


        }
    }
}