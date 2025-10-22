namespace pryBaldovinoCabaña
{
    partial class frmCabania
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
            grpTipo = new GroupBox();
            txtDias = new TextBox();
            lblDias = new Label();
            cboPersonas = new ComboBox();
            lblPersonas = new Label();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            btnAceptar = new Button();
            grpAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            dgvDatos = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colPersonas = new DataGridViewTextBoxColumn();
            colDias = new DataGridViewTextBoxColumn();
            grpFormasPago = new GroupBox();
            cboTarjetas = new ComboBox();
            lblTarjetas = new Label();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            grpTitular = new GroupBox();
            txtTelefonos = new TextBox();
            lblTelefonos = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            grpTipo.SuspendLayout();
            grpAdicionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            grpFormasPago.SuspendLayout();
            grpTitular.SuspendLayout();
            SuspendLayout();
            // 
            // grpTipo
            // 
            grpTipo.Controls.Add(txtDias);
            grpTipo.Controls.Add(lblDias);
            grpTipo.Controls.Add(cboPersonas);
            grpTipo.Controls.Add(lblPersonas);
            grpTipo.Controls.Add(cboTipo);
            grpTipo.Controls.Add(lblTipo);
            grpTipo.Location = new Point(29, 28);
            grpTipo.Name = "grpTipo";
            grpTipo.Size = new Size(510, 118);
            grpTipo.TabIndex = 0;
            grpTipo.TabStop = false;
            grpTipo.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(403, 49);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(80, 23);
            txtDias.TabIndex = 5;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(368, 52);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 4;
            lblDias.Text = "Días";
            // 
            // cboPersonas
            // 
            cboPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonas.FormattingEnabled = true;
            cboPersonas.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboPersonas.Location = new Point(261, 49);
            cboPersonas.Name = "cboPersonas";
            cboPersonas.Size = new Size(82, 23);
            cboPersonas.TabIndex = 3;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(201, 52);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Tipo A", "Tipo B ", "Tipo C" });
            cboTipo.Location = new Point(59, 49);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 1;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(23, 52);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(443, 451);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 28);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar ";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // grpAdicionales
            // 
            grpAdicionales.Controls.Add(chkTelevisor);
            grpAdicionales.Controls.Add(chkHeladera);
            grpAdicionales.Controls.Add(chkCocina);
            grpAdicionales.Location = new Point(32, 165);
            grpAdicionales.Name = "grpAdicionales";
            grpAdicionales.Size = new Size(133, 127);
            grpAdicionales.TabIndex = 2;
            grpAdicionales.TabStop = false;
            grpAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(20, 102);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(20, 64);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(20, 29);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipo, colPersonas, colDias });
            dgvDatos.Location = new Point(572, 37);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(343, 387);
            dgvDatos.TabIndex = 3;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            // 
            // colPersonas
            // 
            colPersonas.HeaderText = "Personas";
            colPersonas.Name = "colPersonas";
            // 
            // colDias
            // 
            colDias.HeaderText = "Días";
            colDias.Name = "colDias";
            // 
            // grpFormasPago
            // 
            grpFormasPago.Controls.Add(cboTarjetas);
            grpFormasPago.Controls.Add(lblTarjetas);
            grpFormasPago.Controls.Add(optTarjeta);
            grpFormasPago.Controls.Add(optEfectivo);
            grpFormasPago.Location = new Point(193, 165);
            grpFormasPago.Name = "grpFormasPago";
            grpFormasPago.Size = new Size(346, 127);
            grpFormasPago.TabIndex = 4;
            grpFormasPago.TabStop = false;
            grpFormasPago.Text = "Formas de Pago";
            // 
            // cboTarjetas
            // 
            cboTarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTarjetas.FormattingEnabled = true;
            cboTarjetas.Location = new Point(125, 86);
            cboTarjetas.Name = "cboTarjetas";
            cboTarjetas.Size = new Size(194, 23);
            cboTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(125, 68);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(46, 15);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(24, 64);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(62, 19);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta ";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(24, 29);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // grpTitular
            // 
            grpTitular.Controls.Add(txtTelefonos);
            grpTitular.Controls.Add(lblTelefonos);
            grpTitular.Controls.Add(txtNombre);
            grpTitular.Controls.Add(lblNombre);
            grpTitular.Location = new Point(31, 309);
            grpTitular.Name = "grpTitular";
            grpTitular.Size = new Size(508, 115);
            grpTitular.TabIndex = 5;
            grpTitular.TabStop = false;
            grpTitular.Text = "Titular de la Reserva ";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(98, 74);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(383, 23);
            txtTelefonos.TabIndex = 7;
            txtTelefonos.TextChanged += txtTelefonos_TextChanged;
            // 
            // lblTelefonos
            // 
            lblTelefonos.AutoSize = true;
            lblTelefonos.Location = new Point(21, 77);
            lblTelefonos.Name = "lblTelefonos";
            lblTelefonos.Size = new Size(57, 15);
            lblTelefonos.TabIndex = 4;
            lblTelefonos.Text = "Teléfonos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(383, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // frmCabania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 503);
            Controls.Add(grpTitular);
            Controls.Add(grpFormasPago);
            Controls.Add(dgvDatos);
            Controls.Add(grpAdicionales);
            Controls.Add(btnAceptar);
            Controls.Add(grpTipo);
            Name = "frmCabania";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCabania";
            Load += frmCabania_Load;
            grpTipo.ResumeLayout(false);
            grpTipo.PerformLayout();
            grpAdicionales.ResumeLayout(false);
            grpAdicionales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            grpFormasPago.ResumeLayout(false);
            grpFormasPago.PerformLayout();
            grpTitular.ResumeLayout(false);
            grpTitular.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTipo;
        private TextBox txtDias;
        private Label lblDias;
        private ComboBox cboPersonas;
        private Label lblPersonas;
        private ComboBox cboTipo;
        private Label lblTipo;
        private Button btnAceptar;
        private GroupBox grpAdicionales;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colPersonas;
        private DataGridViewTextBoxColumn colDias;
        private GroupBox grpFormasPago;
        private ComboBox cboTarjetas;
        private Label lblTarjetas;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private GroupBox grpTitular;
        private Label lblTelefonos;
        private Label lblNombre;
        private TextBox txtTelefonos;
        private TextBox txtNombre;
    }
}