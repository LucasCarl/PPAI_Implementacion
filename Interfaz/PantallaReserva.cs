using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_Implementacion.Clases;

namespace PPAI_Implementacion.Interfaz
{
    public partial class PantallaReserva : Form
    {
        private Gestor.GestorTurnos gestorTurnos;

        public PantallaReserva()
        {
            InitializeComponent();
            gestorTurnos = new Gestor.GestorTurnos(this);
        }

        public void ReservarTurnoDeRecurso()
        {
            HabilitarPantalla();
            gestorTurnos.NuevaReservaTurno();
        }

        public void HabilitarPantalla()
        {
            this.Show();
        }

        public void PedirSeleccionTRT(IList<TipoRecursoTecnologico> listaTipos)
        {
            cbxTipoRecurso.Enabled = true;
            btnTipoRecurso.Enabled = true;

            cbxTipoRecurso.DataSource = listaTipos;
            cbxTipoRecurso.DisplayMember = "nombre";
        }
        private void SeleccionTipoRecurso(object sender, EventArgs e)
        {
            gestorTurnos.TomarSeleccionTRT((TipoRecursoTecnologico)cbxTipoRecurso.SelectedItem);
        }

        public void PedirSeleccionRT()
        {
            dgvRecursos.Enabled = true;
            btnRecurso.Enabled = true;
        }

        public void PedirSeleccionTurno()
        {
            cldDiasTurnos.Enabled = true;
            dgvHorasTurnos.Enabled = true;
            btnTurno.Enabled = true;
        }

        public void PedirConfirmacionTurno()
        {
            cbxEmail.Enabled = true;
            cbxWhatsapp.Enabled = true;
            btnConfirmarReserva.Enabled = true;
        }

        private void SeleccionarRT(object sender, EventArgs e)
        {

        }

        private void SeleccionarTurno(object sender, EventArgs e)
        {

        }

        private void ConfirmarReservaTurno(object sender, EventArgs e)
        {

        }

        private void CancelarReservaTurno(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
