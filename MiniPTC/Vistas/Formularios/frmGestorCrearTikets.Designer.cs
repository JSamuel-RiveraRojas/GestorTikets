namespace Vistas.Formularios
{
    partial class frmGestorCrearTikets
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
            this.gbBotonoesUsuarios = new System.Windows.Forms.Panel();
            this.btnAgragarUsuario = new System.Windows.Forms.Button();
            this.pnLBuscar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbBotonoesUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBotonoesUsuarios
            // 
            this.gbBotonoesUsuarios.BackColor = System.Drawing.Color.Beige;
            this.gbBotonoesUsuarios.Controls.Add(this.btnAgragarUsuario);
            this.gbBotonoesUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBotonoesUsuarios.Location = new System.Drawing.Point(906, 59);
            this.gbBotonoesUsuarios.Name = "gbBotonoesUsuarios";
            this.gbBotonoesUsuarios.Size = new System.Drawing.Size(229, 471);
            this.gbBotonoesUsuarios.TabIndex = 6;
            this.gbBotonoesUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.gbBotonoesUsuarios_Paint);
            // 
            // btnAgragarUsuario
            // 
            this.btnAgragarUsuario.Location = new System.Drawing.Point(64, 79);
            this.btnAgragarUsuario.Name = "btnAgragarUsuario";
            this.btnAgragarUsuario.Size = new System.Drawing.Size(133, 56);
            this.btnAgragarUsuario.TabIndex = 1;
            this.btnAgragarUsuario.Text = "button1";
            this.btnAgragarUsuario.UseVisualStyleBackColor = true;
            // 
            // pnLBuscar
            // 
            this.pnLBuscar.BackColor = System.Drawing.Color.LightYellow;
            this.pnLBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnLBuscar.Name = "pnLBuscar";
            this.pnLBuscar.Size = new System.Drawing.Size(1135, 59);
            this.pnLBuscar.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 325);
            this.dataGridView1.TabIndex = 4;
            // 
            // frmGestorCrearTikets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1135, 530);
            this.Controls.Add(this.gbBotonoesUsuarios);
            this.Controls.Add(this.pnLBuscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestorCrearTikets";
            this.Text = "frmGestorCrearTikets";
            this.gbBotonoesUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gbBotonoesUsuarios;
        private System.Windows.Forms.Button btnAgragarUsuario;
        private System.Windows.Forms.Panel pnLBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}