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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCabania));
            grpTipo = new GroupBox();
            txtDias = new TextBox();
            lblDias = new Label();
            cboPersonas = new ComboBox();
            lblPersonas = new Label();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            btnReservar = new Button();
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
            grpTipo.Location = new Point(33, 37);
            grpTipo.Margin = new Padding(3, 4, 3, 4);
            grpTipo.Name = "grpTipo";
            grpTipo.Padding = new Padding(3, 4, 3, 4);
            grpTipo.Size = new Size(583, 157);
            grpTipo.TabIndex = 0;
            grpTipo.TabStop = false;
            grpTipo.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(461, 65);
            txtDias.Margin = new Padding(3, 4, 3, 4);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(91, 27);
            txtDias.TabIndex = 5;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(421, 69);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(38, 20);
            lblDias.TabIndex = 4;
            lblDias.Text = "Días";
            // 
            // cboPersonas
            // 
            cboPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonas.FormattingEnabled = true;
            cboPersonas.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboPersonas.Location = new Point(298, 65);
            cboPersonas.Margin = new Padding(3, 4, 3, 4);
            cboPersonas.Name = "cboPersonas";
            cboPersonas.Size = new Size(93, 28);
            cboPersonas.TabIndex = 3;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(230, 69);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(66, 20);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Tipo A", "Tipo B ", "Tipo C" });
            cboTipo.Location = new Point(67, 65);
            cboTipo.Margin = new Padding(3, 4, 3, 4);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(138, 28);
            cboTipo.TabIndex = 1;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(26, 69);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(506, 601);
            btnReservar.Margin = new Padding(3, 4, 3, 4);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(110, 37);
            btnReservar.TabIndex = 1;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnAceptar_Click;
            // 
            // grpAdicionales
            // 
            grpAdicionales.Controls.Add(chkTelevisor);
            grpAdicionales.Controls.Add(chkHeladera);
            grpAdicionales.Controls.Add(chkCocina);
            grpAdicionales.Location = new Point(37, 220);
            grpAdicionales.Margin = new Padding(3, 4, 3, 4);
            grpAdicionales.Name = "grpAdicionales";
            grpAdicionales.Padding = new Padding(3, 4, 3, 4);
            grpAdicionales.Size = new Size(152, 169);
            grpAdicionales.TabIndex = 2;
            grpAdicionales.TabStop = false;
            grpAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(23, 136);
            chkTelevisor.Margin = new Padding(3, 4, 3, 4);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(89, 24);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(23, 85);
            chkHeladera.Margin = new Padding(3, 4, 3, 4);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(92, 24);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(23, 39);
            chkCocina.Margin = new Padding(3, 4, 3, 4);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(76, 24);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipo, colPersonas, colDias });
            dgvDatos.Location = new Point(654, 49);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(392, 516);
            dgvDatos.TabIndex = 3;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.Width = 125;
            // 
            // colPersonas
            // 
            colPersonas.HeaderText = "Personas";
            colPersonas.MinimumWidth = 6;
            colPersonas.Name = "colPersonas";
            colPersonas.Width = 125;
            // 
            // colDias
            // 
            colDias.HeaderText = "Días";
            colDias.MinimumWidth = 6;
            colDias.Name = "colDias";
            colDias.Width = 125;
            // 
            // grpFormasPago
            // 
            grpFormasPago.Controls.Add(cboTarjetas);
            grpFormasPago.Controls.Add(lblTarjetas);
            grpFormasPago.Controls.Add(optTarjeta);
            grpFormasPago.Controls.Add(optEfectivo);
            grpFormasPago.Location = new Point(221, 220);
            grpFormasPago.Margin = new Padding(3, 4, 3, 4);
            grpFormasPago.Name = "grpFormasPago";
            grpFormasPago.Padding = new Padding(3, 4, 3, 4);
            grpFormasPago.Size = new Size(395, 169);
            grpFormasPago.TabIndex = 4;
            grpFormasPago.TabStop = false;
            grpFormasPago.Text = "Formas de Pago";
            // 
            // cboTarjetas
            // 
            cboTarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTarjetas.FormattingEnabled = true;
            cboTarjetas.Location = new Point(143, 115);
            cboTarjetas.Margin = new Padding(3, 4, 3, 4);
            cboTarjetas.Name = "cboTarjetas";
            cboTarjetas.Size = new Size(221, 28);
            cboTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(143, 91);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(59, 20);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(27, 85);
            optTarjeta.Margin = new Padding(3, 4, 3, 4);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(78, 24);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta ";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(27, 39);
            optEfectivo.Margin = new Padding(3, 4, 3, 4);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(83, 24);
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
            grpTitular.Location = new Point(35, 412);
            grpTitular.Margin = new Padding(3, 4, 3, 4);
            grpTitular.Name = "grpTitular";
            grpTitular.Padding = new Padding(3, 4, 3, 4);
            grpTitular.Size = new Size(581, 153);
            grpTitular.TabIndex = 5;
            grpTitular.TabStop = false;
            grpTitular.Text = "Titular de la Reserva ";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(112, 99);
            txtTelefonos.Margin = new Padding(3, 4, 3, 4);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(437, 27);
            txtTelefonos.TabIndex = 7;
            txtTelefonos.TextChanged += txtTelefonos_TextChanged;
            // 
            // lblTelefonos
            // 
            lblTelefonos.AutoSize = true;
            lblTelefonos.Location = new Point(24, 103);
            lblTelefonos.Name = "lblTelefonos";
            lblTelefonos.Size = new Size(73, 20);
            lblTelefonos.TabIndex = 4;
            lblTelefonos.Text = "Teléfonos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 47);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(437, 27);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // frmCabania
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 671);
            Controls.Add(grpTitular);
            Controls.Add(grpFormasPago);
            Controls.Add(dgvDatos);
            Controls.Add(grpAdicionales);
            Controls.Add(btnReservar);
            Controls.Add(grpTipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
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
        private Button btnReservar;
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