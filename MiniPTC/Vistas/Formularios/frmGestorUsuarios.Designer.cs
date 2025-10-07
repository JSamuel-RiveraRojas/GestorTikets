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
            this.lblBuscar_Usuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.gbBotonoesUsuarios = new System.Windows.Forms.Panel();
            this.btnAgragarUsuario = new System.Windows.Forms.Button();
            this.BTNEditarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer_Usuarios)).BeginInit();
            this.pnLBuscar.SuspendLayout();
            this.gbBotonoesUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVer_Usuarios
            // 
            this.dgvVer_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVer_Usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVer_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer_Usuarios.GridColor = System.Drawing.Color.Brown;
            this.dgvVer_Usuarios.Location = new System.Drawing.Point(51, 138);
            this.dgvVer_Usuarios.Name = "dgvVer_Usuarios";
            this.dgvVer_Usuarios.ReadOnly = true;
            this.dgvVer_Usuarios.RowHeadersVisible = false;
            this.dgvVer_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVer_Usuarios.Size = new System.Drawing.Size(806, 325);
            this.dgvVer_Usuarios.TabIndex = 0;
            // 
            // pnLBuscar
            // 
            this.pnLBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnLBuscar.Controls.Add(this.lblBuscar_Usuario);
            this.pnLBuscar.Controls.Add(this.txtBuscarUsuario);
            this.pnLBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnLBuscar.Name = "pnLBuscar";
            this.pnLBuscar.Size = new System.Drawing.Size(1135, 59);
            this.pnLBuscar.TabIndex = 2;
            // 
            // lblBuscar_Usuario
            // 
            this.lblBuscar_Usuario.AutoSize = true;
            this.lblBuscar_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBuscar_Usuario.Location = new System.Drawing.Point(176, 21);
            this.lblBuscar_Usuario.Name = "lblBuscar_Usuario";
            this.lblBuscar_Usuario.Size = new System.Drawing.Size(65, 20);
            this.lblBuscar_Usuario.TabIndex = 1;
            this.lblBuscar_Usuario.Text = "Buscar";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBuscarUsuario.Location = new System.Drawing.Point(264, 21);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(418, 23);
            this.txtBuscarUsuario.TabIndex = 0;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbBotonoesUsuarios
            // 
            this.gbBotonoesUsuarios.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gbBotonoesUsuarios.Controls.Add(this.BTNEditarUsuario);
            this.gbBotonoesUsuarios.Controls.Add(this.btnAgragarUsuario);
            this.gbBotonoesUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBotonoesUsuarios.Location = new System.Drawing.Point(906, 59);
            this.gbBotonoesUsuarios.Name = "gbBotonoesUsuarios";
            this.gbBotonoesUsuarios.Size = new System.Drawing.Size(229, 471);
            this.gbBotonoesUsuarios.TabIndex = 3;
            // 
            // btnAgragarUsuario
            // 
            this.btnAgragarUsuario.Location = new System.Drawing.Point(17, 122);
            this.btnAgragarUsuario.Name = "btnAgragarUsuario";
            this.btnAgragarUsuario.Size = new System.Drawing.Size(176, 72);
            this.btnAgragarUsuario.TabIndex = 1;
            this.btnAgragarUsuario.Text = "Nuevo Usuario";
            this.btnAgragarUsuario.UseVisualStyleBackColor = true;
            this.btnAgragarUsuario.Click += new System.EventHandler(this.btnAgragarUsuario_Click);
            // 
            // BTNEditarUsuario
            // 
            this.BTNEditarUsuario.Location = new System.Drawing.Point(17, 278);
            this.BTNEditarUsuario.Name = "BTNEditarUsuario";
            this.BTNEditarUsuario.Size = new System.Drawing.Size(176, 73);
            this.BTNEditarUsuario.TabIndex = 2;
            this.BTNEditarUsuario.Text = "Editar Usuario";
            this.BTNEditarUsuario.UseVisualStyleBackColor = true;
            this.BTNEditarUsuario.Click += new System.EventHandler(this.BTNEditarUsuario_Click_1);
            // 
            // frmGestorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1135, 530);
            this.Controls.Add(this.gbBotonoesUsuarios);
            this.Controls.Add(this.pnLBuscar);
            this.Controls.Add(this.dgvVer_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmGestorUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestorUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer_Usuarios)).EndInit();
            this.pnLBuscar.ResumeLayout(false);
            this.pnLBuscar.PerformLayout();
            this.gbBotonoesUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLBuscar;
        private System.Windows.Forms.Panel gbBotonoesUsuarios;
        public System.Windows.Forms.DataGridView dgvVer_Usuarios;
        private System.Windows.Forms.Label lblBuscar_Usuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button BTNEditarUsuario;
        private System.Windows.Forms.Button btnAgragarUsuario;
    }
}