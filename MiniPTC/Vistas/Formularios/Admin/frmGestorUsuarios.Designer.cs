namespace Vistas.Formularios
{
    partial class frmGestorUsuarios
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
            this.dgvVer_Usuarios = new System.Windows.Forms.DataGridView();
            this.pnLBuscar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMostrar1 = new System.Windows.Forms.PictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVer_Usuarios
            // 
            this.dgvVer_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVer_Usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVer_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer_Usuarios.GridColor = System.Drawing.Color.Brown;
            this.dgvVer_Usuarios.Location = new System.Drawing.Point(35, 130);
            this.dgvVer_Usuarios.Name = "dgvVer_Usuarios";
            this.dgvVer_Usuarios.ReadOnly = true;
            this.dgvVer_Usuarios.RowHeadersVisible = false;
            this.dgvVer_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVer_Usuarios.Size = new System.Drawing.Size(572, 325);
            this.dgvVer_Usuarios.TabIndex = 0;
            // 
            // pnLBuscar
            // 
            this.pnLBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnLBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnLBuscar.Name = "pnLBuscar";
            this.pnLBuscar.Size = new System.Drawing.Size(1135, 59);
            this.pnLBuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tipo de cuenta";
            // 
            // pbMostrar1
            // 
            this.pbMostrar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMostrar1.BackColor = System.Drawing.Color.Black;
            this.pbMostrar1.Image = global::Vistas.Properties.Resources.icons8_visible_30__1_;
            this.pbMostrar1.Location = new System.Drawing.Point(1070, 288);
            this.pbMostrar1.Name = "pbMostrar1";
            this.pbMostrar1.Size = new System.Drawing.Size(42, 36);
            this.pbMostrar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar1.TabIndex = 65;
            this.pbMostrar1.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(823, 288);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(247, 35);
            this.txtClave.TabIndex = 64;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(818, 255);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(121, 30);
            this.lblContrasena.TabIndex = 63;
            this.lblContrasena.Text = "Contraseña";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(823, 211);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(271, 28);
            this.cmbRol.TabIndex = 62;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(822, 118);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(272, 35);
            this.txtUsuario.TabIndex = 59;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(817, 85);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(277, 30);
            this.lblNombreUsuario.TabIndex = 58;
            this.lblNombreUsuario.Text = "Nombre de Usuario (Unico)";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(676, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 88);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1135, 530);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMostrar1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.pnLBuscar);
            this.Controls.Add(this.dgvVer_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmGestorUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestorUsuarios";
            this.Load += new System.EventHandler(this.frmGestorUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnLBuscar;
        public System.Windows.Forms.DataGridView dgvVer_Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMostrar1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnGuardar;
    }
}