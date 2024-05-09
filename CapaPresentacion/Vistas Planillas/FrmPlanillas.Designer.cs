namespace CapaPresentacion.Vistas_Planillas
{
    partial class FrmPlanillas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lblTituloAsistencias = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvPlanilla = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpiarPlanilla = new FontAwesome.Sharp.IconButton();
            this.btnGuardarPlanilla = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMesPlanilla = new System.Windows.Forms.Label();
            this.btnCargarPlanilla = new FontAwesome.Sharp.IconButton();
            this.cmbBoxMesPlanilla = new System.Windows.Forms.ComboBox();
            this.cmbBoxAñoPlanilla = new System.Windows.Forms.ComboBox();
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.paneltitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanilla)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.paneltitulo.Controls.Add(this.lblTituloAsistencias);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(800, 80);
            this.paneltitulo.TabIndex = 8;
            // 
            // lblTituloAsistencias
            // 
            this.lblTituloAsistencias.AutoSize = true;
            this.lblTituloAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAsistencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloAsistencias.Location = new System.Drawing.Point(27, 25);
            this.lblTituloAsistencias.Name = "lblTituloAsistencias";
            this.lblTituloAsistencias.Size = new System.Drawing.Size(109, 31);
            this.lblTituloAsistencias.TabIndex = 1;
            this.lblTituloAsistencias.Text = "Planilla";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.dtgvPlanilla);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 370);
            this.panel1.TabIndex = 9;
            // 
            // dtgvPlanilla
            // 
            this.dtgvPlanilla.AllowUserToAddRows = false;
            this.dtgvPlanilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPlanilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPlanilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvPlanilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvPlanilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvPlanilla.ColumnHeadersHeight = 30;
            this.dtgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPlanilla.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvPlanilla.EnableHeadersVisualStyles = false;
            this.dtgvPlanilla.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvPlanilla.Location = new System.Drawing.Point(117, 61);
            this.dtgvPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvPlanilla.Name = "dtgvPlanilla";
            this.dtgvPlanilla.ReadOnly = true;
            this.dtgvPlanilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvPlanilla.RowHeadersWidth = 51;
            this.dtgvPlanilla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvPlanilla.RowTemplate.Height = 24;
            this.dtgvPlanilla.Size = new System.Drawing.Size(567, 204);
            this.dtgvPlanilla.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnLimpiarPlanilla);
            this.panel3.Controls.Add(this.btnGuardarPlanilla);
            this.panel3.Location = new System.Drawing.Point(209, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 51);
            this.panel3.TabIndex = 11;
            // 
            // btnLimpiarPlanilla
            // 
            this.btnLimpiarPlanilla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarPlanilla.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPlanilla.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnLimpiarPlanilla.IconColor = System.Drawing.Color.White;
            this.btnLimpiarPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarPlanilla.IconSize = 21;
            this.btnLimpiarPlanilla.Location = new System.Drawing.Point(219, 8);
            this.btnLimpiarPlanilla.Name = "btnLimpiarPlanilla";
            this.btnLimpiarPlanilla.Size = new System.Drawing.Size(99, 36);
            this.btnLimpiarPlanilla.TabIndex = 9;
            this.btnLimpiarPlanilla.Text = "Cancelar";
            this.btnLimpiarPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarPlanilla.UseVisualStyleBackColor = false;
            // 
            // btnGuardarPlanilla
            // 
            this.btnGuardarPlanilla.BackColor = System.Drawing.Color.Tan;
            this.btnGuardarPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPlanilla.FlatAppearance.BorderSize = 0;
            this.btnGuardarPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPlanilla.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnGuardarPlanilla.IconColor = System.Drawing.Color.White;
            this.btnGuardarPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPlanilla.IconSize = 21;
            this.btnGuardarPlanilla.Location = new System.Drawing.Point(57, 8);
            this.btnGuardarPlanilla.Name = "btnGuardarPlanilla";
            this.btnGuardarPlanilla.Size = new System.Drawing.Size(99, 36);
            this.btnGuardarPlanilla.TabIndex = 10;
            this.btnGuardarPlanilla.Text = "Guardar";
            this.btnGuardarPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPlanilla.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lblMesPlanilla);
            this.panel2.Controls.Add(this.btnCargarPlanilla);
            this.panel2.Controls.Add(this.cmbBoxMesPlanilla);
            this.panel2.Controls.Add(this.cmbBoxAñoPlanilla);
            this.panel2.Controls.Add(this.lblPlanilla);
            this.panel2.Location = new System.Drawing.Point(209, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 39);
            this.panel2.TabIndex = 10;
            // 
            // lblMesPlanilla
            // 
            this.lblMesPlanilla.AutoSize = true;
            this.lblMesPlanilla.Location = new System.Drawing.Point(17, 14);
            this.lblMesPlanilla.Name = "lblMesPlanilla";
            this.lblMesPlanilla.Size = new System.Drawing.Size(27, 13);
            this.lblMesPlanilla.TabIndex = 2;
            this.lblMesPlanilla.Text = "Mes";
            // 
            // btnCargarPlanilla
            // 
            this.btnCargarPlanilla.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCargarPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPlanilla.FlatAppearance.BorderSize = 0;
            this.btnCargarPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnCargarPlanilla.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.btnCargarPlanilla.IconColor = System.Drawing.Color.White;
            this.btnCargarPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarPlanilla.IconSize = 21;
            this.btnCargarPlanilla.Location = new System.Drawing.Point(264, 6);
            this.btnCargarPlanilla.Name = "btnCargarPlanilla";
            this.btnCargarPlanilla.Size = new System.Drawing.Size(99, 27);
            this.btnCargarPlanilla.TabIndex = 9;
            this.btnCargarPlanilla.Text = "Cargar";
            this.btnCargarPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarPlanilla.UseVisualStyleBackColor = false;
            this.btnCargarPlanilla.Click += new System.EventHandler(this.btnCargarPlanilla_Click);
            // 
            // cmbBoxMesPlanilla
            // 
            this.cmbBoxMesPlanilla.FormattingEnabled = true;
            this.cmbBoxMesPlanilla.Location = new System.Drawing.Point(50, 10);
            this.cmbBoxMesPlanilla.Name = "cmbBoxMesPlanilla";
            this.cmbBoxMesPlanilla.Size = new System.Drawing.Size(63, 21);
            this.cmbBoxMesPlanilla.TabIndex = 3;
            // 
            // cmbBoxAñoPlanilla
            // 
            this.cmbBoxAñoPlanilla.FormattingEnabled = true;
            this.cmbBoxAñoPlanilla.Location = new System.Drawing.Point(174, 9);
            this.cmbBoxAñoPlanilla.Name = "cmbBoxAñoPlanilla";
            this.cmbBoxAñoPlanilla.Size = new System.Drawing.Size(63, 21);
            this.cmbBoxAñoPlanilla.TabIndex = 5;
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Location = new System.Drawing.Point(142, 15);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(26, 13);
            this.lblPlanilla.TabIndex = 4;
            this.lblPlanilla.Text = "Año";
            // 
            // FrmPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltitulo);
            this.Name = "FrmPlanillas";
            this.Text = "FrmPlanillas";
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanilla)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label lblTituloAsistencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLimpiarPlanilla;
        private FontAwesome.Sharp.IconButton btnGuardarPlanilla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMesPlanilla;
        private FontAwesome.Sharp.IconButton btnCargarPlanilla;
        private System.Windows.Forms.ComboBox cmbBoxMesPlanilla;
        private System.Windows.Forms.ComboBox cmbBoxAñoPlanilla;
        private System.Windows.Forms.Label lblPlanilla;
        private System.Windows.Forms.DataGridView dtgvPlanilla;
    }
}