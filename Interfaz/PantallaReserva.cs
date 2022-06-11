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

            dgvRecursos.AutoGenerateColumns = false;
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

        public void PedirSeleccionTRT(List<string> listaTipos)
        {
            cbxTipoRecurso.Enabled = true;
            btnTipoRecurso.Enabled = true;

            cbxTipoRecurso.DataSource = listaTipos;
        }
        private void SeleccionTipoRecurso(object sender, EventArgs e)
        {
            gestorTurnos.TomarSeleccionTRT((string)cbxTipoRecurso.SelectedItem);
        }

        public void PedirSeleccionRT(List<string[]> listaDatosRecursos)
        {
            dgvRecursos.Enabled = true;
            btnRecurso.Enabled = true;

            dgvRecursos.DataSource = listaDatosRecursos;
            for (int i = 0; i < listaDatosRecursos.Count; i++)
            {
                dgvRecursos.Rows[i].Cells[0].Value = listaDatosRecursos[i][0];
                dgvRecursos.Rows[i].Cells[1].Value = listaDatosRecursos[i][1];
                dgvRecursos.Rows[i].Cells[2].Value = listaDatosRecursos[i][2];
                dgvRecursos.Rows[i].Cells[3].Value = listaDatosRecursos[i][3];
                dgvRecursos.Rows[i].Cells[4].Value = listaDatosRecursos[i][4];
            }
        }

        private void SeleccionarRT(object sender, EventArgs e)
        {
            gestorTurnos.TomarSeleccionRT(dgvRecursos.CurrentRow.Index);
        }

        public void PedirSeleccionTurno()
        {
            cldDiasTurnos.Enabled = true;
            dgvHorasTurnos.Enabled = true;
            btnTurno.Enabled = true;
        }

        private void SeleccionarTurno(object sender, EventArgs e)
        {
            gestorTurnos.TomarSeleccionTurno(dgvHorasTurnos.CurrentRow.Index);
        }

        public void PedirConfirmacionTurno()
        {
            cbxEmail.Enabled = true;
            cbxWhatsapp.Enabled = true;
            btnConfirmarReserva.Enabled = true;
        }

        private void ConfirmarReservaTurno(object sender, EventArgs e)
        {
            gestorTurnos.ReservarTurnoRT();
        }

        private void CancelarReservaTurno(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarTurnosDia(object sender, DateRangeEventArgs e)
        {
            gestorTurnos.DisponibilidadPorFecha(cldDiasTurnos.SelectionStart.Date);
        }
    }
}
