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
    public partial class PantallaRegistrarReservaTurnoRT : Form
    {
        private Gestor.GestorRegistrarReservaTurnoRT gestorTurnos;

        public PantallaRegistrarReservaTurnoRT()
        {
            InitializeComponent();
            gestorTurnos = new Gestor.GestorRegistrarReservaTurnoRT(this);

            dgvRecursos.AutoGenerateColumns = false;
        }

        public void OpcionRegistrarReservarDeRT()
        {
            HabilitarPantalla();
            gestorTurnos.RegistrarReservaTurnoRT();
        }

        public void HabilitarPantalla()
        {
            this.Show();
        }

        public void SolicitarSeleccionTipoRT(List<string> listaTipos)
        {
            cbxTipoRecurso.Enabled = true;
            btnTipoRecurso.Enabled = true;

            cbxTipoRecurso.DataSource = listaTipos;
        }
        private void TomarSeleccionTipoRT(object sender, EventArgs e)
        {
            gestorTurnos.TomarSeleccionTipoRT((string)cbxTipoRecurso.SelectedItem);
        }

        public void SolicitarSeleccionRT(List<string[]> listaDatosRecursos)
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

                Color colorEstado = new Color();
                switch (listaDatosRecursos[i][4])
                {
                    case "Disponible":
                        colorEstado = Color.Blue;
                        break;

                    case "En Mantenimiento":
                        colorEstado = Color.LimeGreen;
                        break;

                    case "Inicio Mantenimiento Preventivo":
                        colorEstado = Color.DarkGray;
                        break;

                    default:
                        colorEstado = Color.White;
                        break;
                }
                dgvRecursos.Rows[i].Cells[4].Style.BackColor = colorEstado;
            }
        }

        private void TomarSeleccionRT(object sender, EventArgs e)
        {
            if(dgvRecursos.CurrentRow == null)
            {
                MensajeNadaSeleccionado("Seleccione un Recurso Tecnologico.");
                return;
            }
            gestorTurnos.TomarSeleccionRT(dgvRecursos.CurrentRow.Index);
        }

        public void SolicitarSeleccionTurno(List<string[]> listaTurno)
        {
            cldDiasTurnos.Enabled = true;
            dgvHorasTurnos.Enabled = true;
            btnTurno.Enabled = true;
        }

        private void TomarSeleccionTurno(object sender, EventArgs e)
        {
            if (dgvHorasTurnos.CurrentRow == null)
            {
                MensajeNadaSeleccionado("Seleccione un Turno.");
                return;
            }
            gestorTurnos.TomarSeleccionTurno(dgvHorasTurnos.CurrentRow.Index);
        }

        public void SolicitarConfirmacionReservaRT(string[] datosRecurso, string tipoRecurso, string[] datosTurno)
        {
            txtNroInventario.Text = datosRecurso[0];
            txtTipoRecurso.Text = tipoRecurso;
            txtCentroInvestigacion.Text = datosRecurso[1];
            txtModelo.Text = datosRecurso[2];
            txtMarca.Text = datosRecurso[3];


            cbxEmail.Enabled = true;
            cbxWhatsapp.Enabled = true;
            btnConfirmarReserva.Enabled = true;
        }

        private void TomarConfirmacionReservaRT(object sender, EventArgs e)
        {
            gestorTurnos.TomarConfirmacionReservaRT();
        }

        private void CancelarReservaTurno(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarTurnosDia(object sender, DateRangeEventArgs e)
        {
            List<string[]> datosTurnos = gestorTurnos.DeterminarDisponibilidadPorFecha(cldDiasTurnos.SelectionStart.Date);
            dgvHorasTurnos.DataSource = null;
            dgvHorasTurnos.DataSource = datosTurnos;
        }

        private void MensajeNadaSeleccionado(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
