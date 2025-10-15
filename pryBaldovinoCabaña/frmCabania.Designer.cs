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
            grpTipo.SuspendLayout();
            grpAdicionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
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
            btnAceptar.Location = new Point(443, 410);
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
            grpAdicionales.Size = new Size(134, 144);
            grpAdicionales.TabIndex = 2;
            grpAdicionales.TabStop = false;
            grpAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(23, 108);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(23, 70);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(23, 35);
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
            dgvDatos.Location = new Point(185, 165);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(354, 219);
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
            // frmCabania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(dgvDatos);
            Controls.Add(grpAdicionales);
            Controls.Add(btnAceptar);
            Controls.Add(grpTipo);
            Name = "frmCabania";
            Text = "frmCabania";
            Load += frmCabania_Load;
            grpTipo.ResumeLayout(false);
            grpTipo.PerformLayout();
            grpAdicionales.ResumeLayout(false);
            grpAdicionales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
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
    }
}