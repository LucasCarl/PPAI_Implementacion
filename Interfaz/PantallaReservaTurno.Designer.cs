﻿
namespace PPAI_Implementacion.Interfaz
{
    partial class PantallaReservaTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxTipoRecurso = new System.Windows.Forms.ComboBox();
            this.lblTipoRecurso = new System.Windows.Forms.Label();
            this.gbxTipoRecurso = new System.Windows.Forms.GroupBox();
            this.btnTipoRecurso = new System.Windows.Forms.Button();
            this.gbxRecurso = new System.Windows.Forms.GroupBox();
            this.btnRecurso = new System.Windows.Forms.Button();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.NroInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroInvestigacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.btnTurno = new System.Windows.Forms.Button();
            this.dgvHorasTurnos = new System.Windows.Forms.DataGridView();
            this.cldDiasTurnos = new System.Windows.Forms.MonthCalendar();
            this.gbxConfirmacion = new System.Windows.Forms.GroupBox();
            this.gbxNotificacion = new System.Windows.Forms.GroupBox();
            this.cbxWhatsapp = new System.Windows.Forms.CheckBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDatosNroInv = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDatosTipoRecurso = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDatosCentroInv = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblDatosMarca = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblDatosModelo = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblDatosFechaTurno = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblDatosHoraTurno = new System.Windows.Forms.Label();
            this.lblDatosTurno = new System.Windows.Forms.Label();
            this.lblDatosRecurso = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.gbxTipoRecurso.SuspendLayout();
            this.gbxRecurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.gbxTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasTurnos)).BeginInit();
            this.gbxConfirmacion.SuspendLayout();
            this.gbxNotificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTipoRecurso
            // 
            this.cbxTipoRecurso.FormattingEnabled = true;
            this.cbxTipoRecurso.Location = new System.Drawing.Point(101, 25);
            this.cbxTipoRecurso.Name = "cbxTipoRecurso";
            this.cbxTipoRecurso.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoRecurso.TabIndex = 0;
            // 
            // lblTipoRecurso
            // 
            this.lblTipoRecurso.AutoSize = true;
            this.lblTipoRecurso.Location = new System.Drawing.Point(6, 28);
            this.lblTipoRecurso.Name = "lblTipoRecurso";
            this.lblTipoRecurso.Size = new System.Drawing.Size(89, 13);
            this.lblTipoRecurso.TabIndex = 1;
            this.lblTipoRecurso.Text = "Tipo de Recurso:";
            // 
            // gbxTipoRecurso
            // 
            this.gbxTipoRecurso.Controls.Add(this.btnTipoRecurso);
            this.gbxTipoRecurso.Controls.Add(this.lblTipoRecurso);
            this.gbxTipoRecurso.Controls.Add(this.cbxTipoRecurso);
            this.gbxTipoRecurso.Location = new System.Drawing.Point(12, 12);
            this.gbxTipoRecurso.Name = "gbxTipoRecurso";
            this.gbxTipoRecurso.Size = new System.Drawing.Size(557, 68);
            this.gbxTipoRecurso.TabIndex = 2;
            this.gbxTipoRecurso.TabStop = false;
            this.gbxTipoRecurso.Text = "Seleccionar Tipo de Recurso";
            // 
            // btnTipoRecurso
            // 
            this.btnTipoRecurso.Location = new System.Drawing.Point(241, 23);
            this.btnTipoRecurso.Name = "btnTipoRecurso";
            this.btnTipoRecurso.Size = new System.Drawing.Size(124, 23);
            this.btnTipoRecurso.TabIndex = 2;
            this.btnTipoRecurso.Text = "Buscar Recursos Tipo";
            this.btnTipoRecurso.UseVisualStyleBackColor = true;
            // 
            // gbxRecurso
            // 
            this.gbxRecurso.Controls.Add(this.btnRecurso);
            this.gbxRecurso.Controls.Add(this.dgvRecursos);
            this.gbxRecurso.Location = new System.Drawing.Point(12, 86);
            this.gbxRecurso.Name = "gbxRecurso";
            this.gbxRecurso.Size = new System.Drawing.Size(557, 213);
            this.gbxRecurso.TabIndex = 3;
            this.gbxRecurso.TabStop = false;
            this.gbxRecurso.Text = "Seleccionar Recurso";
            // 
            // btnRecurso
            // 
            this.btnRecurso.Location = new System.Drawing.Point(8, 176);
            this.btnRecurso.Name = "btnRecurso";
            this.btnRecurso.Size = new System.Drawing.Size(119, 23);
            this.btnRecurso.TabIndex = 1;
            this.btnRecurso.Text = "Seleccionar Recurso";
            this.btnRecurso.UseVisualStyleBackColor = true;
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroInventario,
            this.CentroInvestigacion,
            this.Marca,
            this.Modelo,
            this.Estado});
            this.dgvRecursos.Location = new System.Drawing.Point(8, 19);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.Size = new System.Drawing.Size(543, 150);
            this.dgvRecursos.TabIndex = 0;
            // 
            // NroInventario
            // 
            this.NroInventario.HeaderText = "Nro Inventario";
            this.NroInventario.Name = "NroInventario";
            // 
            // CentroInvestigacion
            // 
            this.CentroInvestigacion.HeaderText = "Centro Investigacion";
            this.CentroInvestigacion.Name = "CentroInvestigacion";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.btnTurno);
            this.gbxTurno.Controls.Add(this.dgvHorasTurnos);
            this.gbxTurno.Controls.Add(this.cldDiasTurnos);
            this.gbxTurno.Location = new System.Drawing.Point(12, 306);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(557, 196);
            this.gbxTurno.TabIndex = 4;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Seleccionar Turno";
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(442, 160);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(109, 24);
            this.btnTurno.TabIndex = 2;
            this.btnTurno.Text = "Seleccionar Turno";
            this.btnTurno.UseVisualStyleBackColor = true;
            // 
            // dgvHorasTurnos
            // 
            this.dgvHorasTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasTurnos.Location = new System.Drawing.Point(278, 22);
            this.dgvHorasTurnos.Name = "dgvHorasTurnos";
            this.dgvHorasTurnos.Size = new System.Drawing.Size(158, 162);
            this.dgvHorasTurnos.TabIndex = 1;
            // 
            // cldDiasTurnos
            // 
            this.cldDiasTurnos.BackColor = System.Drawing.SystemColors.Window;
            this.cldDiasTurnos.Location = new System.Drawing.Point(9, 22);
            this.cldDiasTurnos.Name = "cldDiasTurnos";
            this.cldDiasTurnos.TabIndex = 0;
            // 
            // gbxConfirmacion
            // 
            this.gbxConfirmacion.Controls.Add(this.btnCancelarReserva);
            this.gbxConfirmacion.Controls.Add(this.btnConfirmarReserva);
            this.gbxConfirmacion.Controls.Add(this.lblDatosRecurso);
            this.gbxConfirmacion.Controls.Add(this.lblDatosTurno);
            this.gbxConfirmacion.Controls.Add(this.textBox7);
            this.gbxConfirmacion.Controls.Add(this.lblDatosHoraTurno);
            this.gbxConfirmacion.Controls.Add(this.textBox6);
            this.gbxConfirmacion.Controls.Add(this.lblDatosFechaTurno);
            this.gbxConfirmacion.Controls.Add(this.textBox5);
            this.gbxConfirmacion.Controls.Add(this.lblDatosModelo);
            this.gbxConfirmacion.Controls.Add(this.textBox4);
            this.gbxConfirmacion.Controls.Add(this.lblDatosMarca);
            this.gbxConfirmacion.Controls.Add(this.textBox3);
            this.gbxConfirmacion.Controls.Add(this.lblDatosCentroInv);
            this.gbxConfirmacion.Controls.Add(this.textBox2);
            this.gbxConfirmacion.Controls.Add(this.lblDatosTipoRecurso);
            this.gbxConfirmacion.Controls.Add(this.textBox1);
            this.gbxConfirmacion.Controls.Add(this.lblDatosNroInv);
            this.gbxConfirmacion.Controls.Add(this.gbxNotificacion);
            this.gbxConfirmacion.Location = new System.Drawing.Point(575, 12);
            this.gbxConfirmacion.Name = "gbxConfirmacion";
            this.gbxConfirmacion.Size = new System.Drawing.Size(300, 489);
            this.gbxConfirmacion.TabIndex = 5;
            this.gbxConfirmacion.TabStop = false;
            this.gbxConfirmacion.Text = "Confirmacion Turno";
            // 
            // gbxNotificacion
            // 
            this.gbxNotificacion.Controls.Add(this.cbxWhatsapp);
            this.gbxNotificacion.Controls.Add(this.cbxEmail);
            this.gbxNotificacion.Location = new System.Drawing.Point(19, 278);
            this.gbxNotificacion.Name = "gbxNotificacion";
            this.gbxNotificacion.Size = new System.Drawing.Size(200, 66);
            this.gbxNotificacion.TabIndex = 2;
            this.gbxNotificacion.TabStop = false;
            this.gbxNotificacion.Text = "Notificacion: ";
            // 
            // cbxWhatsapp
            // 
            this.cbxWhatsapp.AutoSize = true;
            this.cbxWhatsapp.Location = new System.Drawing.Point(6, 42);
            this.cbxWhatsapp.Name = "cbxWhatsapp";
            this.cbxWhatsapp.Size = new System.Drawing.Size(75, 17);
            this.cbxWhatsapp.TabIndex = 1;
            this.cbxWhatsapp.Text = "Whatsapp";
            this.cbxWhatsapp.UseVisualStyleBackColor = true;
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.Location = new System.Drawing.Point(6, 19);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(55, 17);
            this.cbxEmail.TabIndex = 0;
            this.cbxEmail.Text = "E-Mail";
            this.cbxEmail.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblDatosNroInv
            // 
            this.lblDatosNroInv.AutoSize = true;
            this.lblDatosNroInv.Location = new System.Drawing.Point(14, 51);
            this.lblDatosNroInv.Name = "lblDatosNroInv";
            this.lblDatosNroInv.Size = new System.Drawing.Size(74, 13);
            this.lblDatosNroInv.TabIndex = 3;
            this.lblDatosNroInv.Text = "Nro Inventario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblDatosTipoRecurso
            // 
            this.lblDatosTipoRecurso.AutoSize = true;
            this.lblDatosTipoRecurso.Location = new System.Drawing.Point(14, 77);
            this.lblDatosTipoRecurso.Name = "lblDatosTipoRecurso";
            this.lblDatosTipoRecurso.Size = new System.Drawing.Size(71, 13);
            this.lblDatosTipoRecurso.TabIndex = 5;
            this.lblDatosTipoRecurso.Text = "Tipo Recurso";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // lblDatosCentroInv
            // 
            this.lblDatosCentroInv.AutoSize = true;
            this.lblDatosCentroInv.Location = new System.Drawing.Point(14, 103);
            this.lblDatosCentroInv.Name = "lblDatosCentroInv";
            this.lblDatosCentroInv.Size = new System.Drawing.Size(104, 13);
            this.lblDatosCentroInv.TabIndex = 7;
            this.lblDatosCentroInv.Text = "Centro Investigacion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // lblDatosMarca
            // 
            this.lblDatosMarca.AutoSize = true;
            this.lblDatosMarca.Location = new System.Drawing.Point(14, 129);
            this.lblDatosMarca.Name = "lblDatosMarca";
            this.lblDatosMarca.Size = new System.Drawing.Size(37, 13);
            this.lblDatosMarca.TabIndex = 9;
            this.lblDatosMarca.Text = "Marca";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // lblDatosModelo
            // 
            this.lblDatosModelo.AutoSize = true;
            this.lblDatosModelo.Location = new System.Drawing.Point(14, 155);
            this.lblDatosModelo.Name = "lblDatosModelo";
            this.lblDatosModelo.Size = new System.Drawing.Size(42, 13);
            this.lblDatosModelo.TabIndex = 11;
            this.lblDatosModelo.Text = "Modelo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(119, 207);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // lblDatosFechaTurno
            // 
            this.lblDatosFechaTurno.AutoSize = true;
            this.lblDatosFechaTurno.Location = new System.Drawing.Point(14, 210);
            this.lblDatosFechaTurno.Name = "lblDatosFechaTurno";
            this.lblDatosFechaTurno.Size = new System.Drawing.Size(68, 13);
            this.lblDatosFechaTurno.TabIndex = 13;
            this.lblDatosFechaTurno.Text = "Fecha Turno";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(119, 233);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 16;
            // 
            // lblDatosHoraTurno
            // 
            this.lblDatosHoraTurno.AutoSize = true;
            this.lblDatosHoraTurno.Location = new System.Drawing.Point(14, 236);
            this.lblDatosHoraTurno.Name = "lblDatosHoraTurno";
            this.lblDatosHoraTurno.Size = new System.Drawing.Size(61, 13);
            this.lblDatosHoraTurno.TabIndex = 15;
            this.lblDatosHoraTurno.Text = "Hora Turno";
            // 
            // lblDatosTurno
            // 
            this.lblDatosTurno.AutoSize = true;
            this.lblDatosTurno.Location = new System.Drawing.Point(16, 186);
            this.lblDatosTurno.Name = "lblDatosTurno";
            this.lblDatosTurno.Size = new System.Drawing.Size(69, 13);
            this.lblDatosTurno.TabIndex = 17;
            this.lblDatosTurno.Text = "Datos Turno:";
            // 
            // lblDatosRecurso
            // 
            this.lblDatosRecurso.AutoSize = true;
            this.lblDatosRecurso.Location = new System.Drawing.Point(16, 33);
            this.lblDatosRecurso.Name = "lblDatosRecurso";
            this.lblDatosRecurso.Size = new System.Drawing.Size(81, 13);
            this.lblDatosRecurso.TabIndex = 18;
            this.lblDatosRecurso.Text = "Datos Recurso:";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.Location = new System.Drawing.Point(19, 370);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(105, 23);
            this.btnConfirmarReserva.TabIndex = 19;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(19, 411);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(105, 23);
            this.btnCancelarReserva.TabIndex = 20;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // PantallaReservaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 513);
            this.Controls.Add(this.gbxConfirmacion);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxRecurso);
            this.Controls.Add(this.gbxTipoRecurso);
            this.Name = "PantallaReservaTurno";
            this.Text = "PantallaReservaTurno";
            this.gbxTipoRecurso.ResumeLayout(false);
            this.gbxTipoRecurso.PerformLayout();
            this.gbxRecurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.gbxTurno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasTurnos)).EndInit();
            this.gbxConfirmacion.ResumeLayout(false);
            this.gbxConfirmacion.PerformLayout();
            this.gbxNotificacion.ResumeLayout(false);
            this.gbxNotificacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoRecurso;
        private System.Windows.Forms.Label lblTipoRecurso;
        private System.Windows.Forms.GroupBox gbxTipoRecurso;
        private System.Windows.Forms.Button btnTipoRecurso;
        private System.Windows.Forms.GroupBox gbxRecurso;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.Button btnRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroInvestigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.DataGridView dgvHorasTurnos;
        private System.Windows.Forms.MonthCalendar cldDiasTurnos;
        private System.Windows.Forms.GroupBox gbxConfirmacion;
        private System.Windows.Forms.GroupBox gbxNotificacion;
        private System.Windows.Forms.CheckBox cbxWhatsapp;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.Label lblDatosRecurso;
        private System.Windows.Forms.Label lblDatosTurno;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblDatosHoraTurno;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblDatosFechaTurno;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblDatosModelo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblDatosMarca;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDatosCentroInv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDatosTipoRecurso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDatosNroInv;
    }
}