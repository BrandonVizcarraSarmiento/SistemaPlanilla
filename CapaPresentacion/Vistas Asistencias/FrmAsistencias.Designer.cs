namespace CapaPresentacion.Vistas_Asistencias
{
    partial class FrmAsistencias
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
            this.lblTituloAsistencias = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbBoxMes = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cmbBoxAño = new System.Windows.Forms.ComboBox();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpiarAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnGuardarAsistencias = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargarAsistencias = new FontAwesome.Sharp.IconButton();
            this.dtgvAsistencia = new System.Windows.Forms.DataGridView();
            this.paneltitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAsistencias
            // 
            this.lblTituloAsistencias.AutoSize = true;
            this.lblTituloAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAsistencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloAsistencias.Location = new System.Drawing.Point(27, 25);
            this.lblTituloAsistencias.Name = "lblTituloAsistencias";
            this.lblTituloAsistencias.Size = new System.Drawing.Size(115, 24);
            this.lblTituloAsistencias.TabIndex = 1;
            this.lblTituloAsistencias.Text = "Asistencias";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(17, 14);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "Mes";
            // 
            // cmbBoxMes
            // 
            this.cmbBoxMes.FormattingEnabled = true;
            this.cmbBoxMes.Location = new System.Drawing.Point(50, 10);
            this.cmbBoxMes.Name = "cmbBoxMes";
            this.cmbBoxMes.Size = new System.Drawing.Size(63, 21);
            this.cmbBoxMes.TabIndex = 3;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(142, 15);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 4;
            this.lblAño.Text = "Año";
            // 
            // cmbBoxAño
            // 
            this.cmbBoxAño.FormattingEnabled = true;
            this.cmbBoxAño.Location = new System.Drawing.Point(174, 9);
            this.cmbBoxAño.Name = "cmbBoxAño";
            this.cmbBoxAño.Size = new System.Drawing.Size(63, 21);
            this.cmbBoxAño.TabIndex = 5;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.IndianRed;
            this.paneltitulo.Controls.Add(this.lblTituloAsistencias);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(800, 80);
            this.paneltitulo.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgvAsistencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 370);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnLimpiarAsistencias);
            this.panel3.Controls.Add(this.btnGuardarAsistencias);
            this.panel3.Location = new System.Drawing.Point(182, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 51);
            this.panel3.TabIndex = 11;
            // 
            // btnLimpiarAsistencias
            // 
            this.btnLimpiarAsistencias.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarAsistencias.FlatAppearance.BorderSize = 0;
            this.btnLimpiarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarAsistencias.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.btnLimpiarAsistencias.IconColor = System.Drawing.Color.White;
            this.btnLimpiarAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarAsistencias.IconSize = 21;
            this.btnLimpiarAsistencias.Location = new System.Drawing.Point(219, 8);
            this.btnLimpiarAsistencias.Name = "btnLimpiarAsistencias";
            this.btnLimpiarAsistencias.Size = new System.Drawing.Size(99, 36);
            this.btnLimpiarAsistencias.TabIndex = 9;
            this.btnLimpiarAsistencias.Text = "Limpiar";
            this.btnLimpiarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAsistencias.UseVisualStyleBackColor = false;
            // 
            // btnGuardarAsistencias
            // 
            this.btnGuardarAsistencias.BackColor = System.Drawing.Color.Tan;
            this.btnGuardarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAsistencias.FlatAppearance.BorderSize = 0;
            this.btnGuardarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAsistencias.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnGuardarAsistencias.IconColor = System.Drawing.Color.White;
            this.btnGuardarAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarAsistencias.IconSize = 21;
            this.btnGuardarAsistencias.Location = new System.Drawing.Point(57, 8);
            this.btnGuardarAsistencias.Name = "btnGuardarAsistencias";
            this.btnGuardarAsistencias.Size = new System.Drawing.Size(99, 36);
            this.btnGuardarAsistencias.TabIndex = 10;
            this.btnGuardarAsistencias.Text = "Guardar";
            this.btnGuardarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarAsistencias.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Controls.Add(this.btnCargarAsistencias);
            this.panel2.Controls.Add(this.cmbBoxMes);
            this.panel2.Controls.Add(this.cmbBoxAño);
            this.panel2.Controls.Add(this.lblAño);
            this.panel2.Location = new System.Drawing.Point(182, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 39);
            this.panel2.TabIndex = 10;
            // 
            // btnCargarAsistencias
            // 
            this.btnCargarAsistencias.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCargarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarAsistencias.FlatAppearance.BorderSize = 0;
            this.btnCargarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnCargarAsistencias.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.btnCargarAsistencias.IconColor = System.Drawing.Color.White;
            this.btnCargarAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarAsistencias.IconSize = 21;
            this.btnCargarAsistencias.Location = new System.Drawing.Point(264, 6);
            this.btnCargarAsistencias.Name = "btnCargarAsistencias";
            this.btnCargarAsistencias.Size = new System.Drawing.Size(99, 27);
            this.btnCargarAsistencias.TabIndex = 9;
            this.btnCargarAsistencias.Text = "Cargar";
            this.btnCargarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarAsistencias.UseVisualStyleBackColor = false;
            // 
            // dtgvAsistencia
            // 
            this.dtgvAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsistencia.Location = new System.Drawing.Point(182, 62);
            this.dtgvAsistencia.Name = "dtgvAsistencia";
            this.dtgvAsistencia.Size = new System.Drawing.Size(387, 198);
            this.dtgvAsistencia.TabIndex = 9;
            // 
            // FrmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltitulo);
            this.Name = "FrmAsistencias";
            this.Text = "FrmAsistencias";
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAsistencias;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbBoxMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cmbBoxAño;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvAsistencia;
        private FontAwesome.Sharp.IconButton btnCargarAsistencias;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnGuardarAsistencias;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLimpiarAsistencias;
    }
}