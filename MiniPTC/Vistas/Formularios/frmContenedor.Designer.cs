namespace Vistas.Formularios
{
    partial class frmContenedor
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnminimizar2 = new System.Windows.Forms.PictureBox();
            this.btncerrar2 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestroUsuarios = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCrearTikets = new System.Windows.Forms.Button();
            this.btinTikets = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnTicketsAsignados = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Controls.Add(this.lblUsuario);
            this.panel6.Controls.Add(this.lblRol);
            this.panel6.Controls.Add(this.btnmaximizar);
            this.panel6.Controls.Add(this.btnminimizar2);
            this.panel6.Controls.Add(this.btncerrar2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(384, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1323, 54);
            this.panel6.TabIndex = 1;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(69, 18);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(31, 18);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnmaximizar.Image = global::Vistas.Properties.Resources.icons8_maximizar_50;
            this.btnmaximizar.Location = new System.Drawing.Point(1244, 4);
            this.btnmaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(33, 31);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 2;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnminimizar2
            // 
            this.btnminimizar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnminimizar2.Image = global::Vistas.Properties.Resources.icons8_minimizar_50;
            this.btnminimizar2.Location = new System.Drawing.Point(1203, 4);
            this.btnminimizar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnminimizar2.Name = "btnminimizar2";
            this.btnminimizar2.Size = new System.Drawing.Size(33, 31);
            this.btnminimizar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar2.TabIndex = 2;
            this.btnminimizar2.TabStop = false;
            this.btnminimizar2.Click += new System.EventHandler(this.btnminimizar2_Click);
            // 
            // btncerrar2
            // 
            this.btncerrar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncerrar2.Image = global::Vistas.Properties.Resources.icons8_x_48;
            this.btncerrar2.Location = new System.Drawing.Point(1285, 4);
            this.btncerrar2.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar2.Name = "btncerrar2";
            this.btncerrar2.Size = new System.Drawing.Size(33, 31);
            this.btncerrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar2.TabIndex = 2;
            this.btncerrar2.TabStop = false;
            this.btncerrar2.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(384, 54);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1323, 881);
            this.pnlContenedor.TabIndex = 2;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::Vistas.Properties.Resources.icons8_salida_50;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(4, 846);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(385, 79);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnGestroUsuarios
            // 
            this.btnGestroUsuarios.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGestroUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestroUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestroUsuarios.Location = new System.Drawing.Point(-3, 206);
            this.btnGestroUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestroUsuarios.Name = "btnGestroUsuarios";
            this.btnGestroUsuarios.Size = new System.Drawing.Size(383, 94);
            this.btnGestroUsuarios.TabIndex = 3;
            this.btnGestroUsuarios.Text = "         USUARIOS";
            this.btnGestroUsuarios.UseVisualStyleBackColor = false;
            this.btnGestroUsuarios.Click += new System.EventHandler(this.btnGestorUsuarios_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vistas.Properties.Resources.icons8_boleto_48;
            this.pictureBox3.Location = new System.Drawing.Point(31, 124);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnCrearTikets
            // 
            this.btnCrearTikets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCrearTikets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTikets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTikets.Location = new System.Drawing.Point(-3, 105);
            this.btnCrearTikets.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearTikets.Name = "btnCrearTikets";
            this.btnCrearTikets.Size = new System.Drawing.Size(383, 94);
            this.btnCrearTikets.TabIndex = 2;
            this.btnCrearTikets.Text = "                 CREAR TICKET";
            this.btnCrearTikets.UseVisualStyleBackColor = false;
            this.btnCrearTikets.Click += new System.EventHandler(this.btnCrearTikets_Click);
            this.btnCrearTikets.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnCrearTikets_ChangeUICues);
            // 
            // btinTikets
            // 
            this.btinTikets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btinTikets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinTikets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinTikets.Image = global::Vistas.Properties.Resources.icons8_boleto_60;
            this.btinTikets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btinTikets.Location = new System.Drawing.Point(-4, 4);
            this.btinTikets.Margin = new System.Windows.Forms.Padding(4);
            this.btinTikets.Name = "btinTikets";
            this.btinTikets.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btinTikets.Size = new System.Drawing.Size(383, 94);
            this.btinTikets.TabIndex = 2;
            this.btinTikets.Text = "         MIS TICKETS";
            this.btinTikets.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 192);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = global::Vistas.Properties.Resources.Logo_soporte_de_tickets;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(383, 204);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnCerrarSesion);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 935);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTicketsAsignados);
            this.panel1.Controls.Add(this.btnCategoria);
            this.panel1.Controls.Add(this.btnTecnicos);
            this.panel1.Controls.Add(this.btinTikets);
            this.panel1.Controls.Add(this.btnCrearTikets);
            this.panel1.Controls.Add(this.btnGestroUsuarios);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 634);
            this.panel1.TabIndex = 3;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(-4, 410);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(383, 94);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnicos.Location = new System.Drawing.Point(-3, 308);
            this.btnTecnicos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(383, 94);
            this.btnTecnicos.TabIndex = 5;
            this.btnTecnicos.Text = "Tecnicos";
            this.btnTecnicos.UseVisualStyleBackColor = false;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnTicketsAsignados
            // 
            this.btnTicketsAsignados.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTicketsAsignados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketsAsignados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsAsignados.Location = new System.Drawing.Point(-3, 512);
            this.btnTicketsAsignados.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicketsAsignados.Name = "btnTicketsAsignados";
            this.btnTicketsAsignados.Size = new System.Drawing.Size(383, 94);
            this.btnTicketsAsignados.TabIndex = 7;
            this.btnTicketsAsignados.Text = "TicketsAsignados";
            this.btnTicketsAsignados.UseVisualStyleBackColor = false;
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 935);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContenedor";
            this.Load += new System.EventHandler(this.frmContenedor_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btnminimizar2;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnGestroUsuarios;
        private System.Windows.Forms.Button btnCrearTikets;
        private System.Windows.Forms.Button btinTikets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox btncerrar2;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnTicketsAsignados;
    }
}