using LOSA.MigracionACS.Tickets.Models;
using DevExpress.XtraEditors;
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

namespace LOSA.MigracionACS.Tickets.Admin
{
    public partial class frmViewInfoTicket : DevExpress.XtraEditors.XtraForm
    {
        public frmViewInfoTicket(int pNumTicket)
        {
            InitializeComponent();
            int categoria;
            lblNumTicket.Text = Convert.ToString(pNumTicket);

            TicketInfo ticketInfo = new TicketInfo();
            ticketInfo.RecuperaRegistro(pNumTicket);
            txtUserAsignado.Text = ticketInfo.UsuarioAsignado;
            txtUserCreador.Text = ticketInfo.UsuarioCreador;
            txtEstado.Text = ticketInfo.Estado;
            txtComentario2.Text = ticketInfo.Comentario;
            txtTitulo.Text = ticketInfo.Titulo;
            dtFechaC.EditValue = ticketInfo.FechaCreacion;
            txtProyecto.Text = ticketInfo.Proyecto;
            categoria = ticketInfo.Categoria;
            
            if (categoria== 1)
            {
                labelControl8.Text = "Proyecto:";
            }
            else
            {
                labelControl8.Text = "Equipo:";
            }

            

           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitulo_DoubleClick(object sender, EventArgs e)
        {
            CajaDialogo.Information(txtTitulo.Text);

            
        }

        private void frmViewInfoTicket_Load(object sender, EventArgs e)
        {

        }
    }
}