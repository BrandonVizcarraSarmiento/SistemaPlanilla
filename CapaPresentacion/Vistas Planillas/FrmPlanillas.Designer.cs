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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lblTituloAsistencias = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvPlanilla = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPDFPlanilla = new FontAwesome.Sharp.IconButton();
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
            this.paneltitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1067, 98);
            this.paneltitulo.TabIndex = 8;
            // 
            // lblTituloAsistencias
            // 
            this.lblTituloAsistencias.AutoSize = true;
            this.lblTituloAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAsistencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloAsistencias.Location = new System.Drawing.Point(36, 31);
            this.lblTituloAsistencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAsistencias.Name = "lblTituloAsistencias";
            this.lblTituloAsistencias.Size = new System.Drawing.Size(137, 39);
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
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 456);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPlanilla.ColumnHeadersHeight = 30;
            this.dtgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPlanilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPlanilla.EnableHeadersVisualStyles = false;
            this.dtgvPlanilla.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvPlanilla.Location = new System.Drawing.Point(156, 75);
            this.dtgvPlanilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPlanilla.Name = "dtgvPlanilla";
            this.dtgvPlanilla.ReadOnly = true;
            this.dtgvPlanilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPlanilla.RowHeadersWidth = 51;
            this.dtgvPlanilla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvPlanilla.RowTemplate.Height = 24;
            this.dtgvPlanilla.Size = new System.Drawing.Size(756, 252);
            this.dtgvPlanilla.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnPDFPlanilla);
            this.panel3.Controls.Add(this.btnGuardarPlanilla);
            this.panel3.Location = new System.Drawing.Point(279, 339);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 63);
            this.panel3.TabIndex = 11;
            // 
            // btnPDFPlanilla
            // 
            this.btnPDFPlanilla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPDFPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDFPlanilla.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDFPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnPDFPlanilla.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnPDFPlanilla.IconColor = System.Drawing.Color.White;
            this.btnPDFPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPDFPlanilla.IconSize = 21;
            this.btnPDFPlanilla.Location = new System.Drawing.Point(292, 10);
            this.btnPDFPlanilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPDFPlanilla.Name = "btnPDFPlanilla";
            this.btnPDFPlanilla.Size = new System.Drawing.Size(132, 44);
            this.btnPDFPlanilla.TabIndex = 9;
            this.btnPDFPlanilla.Text = "PDF";
            this.btnPDFPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDFPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDFPlanilla.UseVisualStyleBackColor = false;
            this.btnPDFPlanilla.Click += new System.EventHandler(this.btnPDFPlanilla_Click);
            // 
            // btnGuardarPlanilla
            // 
            this.btnGuardarPlanilla.BackColor = System.Drawing.Color.Tan;
            this.btnGuardarPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPlanilla.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPlanilla.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnGuardarPlanilla.IconColor = System.Drawing.Color.White;
            this.btnGuardarPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPlanilla.IconSize = 21;
            this.btnGuardarPlanilla.Location = new System.Drawing.Point(76, 10);
            this.btnGuardarPlanilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarPlanilla.Name = "btnGuardarPlanilla";
            this.btnGuardarPlanilla.Size = new System.Drawing.Size(132, 44);
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
            this.panel2.Location = new System.Drawing.Point(279, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 48);
            this.panel2.TabIndex = 10;
            // 
            // lblMesPlanilla
            // 
            this.lblMesPlanilla.AutoSize = true;
            this.lblMesPlanilla.Location = new System.Drawing.Point(23, 17);
            this.lblMesPlanilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesPlanilla.Name = "lblMesPlanilla";
            this.lblMesPlanilla.Size = new System.Drawing.Size(33, 16);
            this.lblMesPlanilla.TabIndex = 2;
            this.lblMesPlanilla.Text = "Mes";
            // 
            // btnCargarPlanilla
            // 
            this.btnCargarPlanilla.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCargarPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPlanilla.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnCargarPlanilla.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.btnCargarPlanilla.IconColor = System.Drawing.Color.White;
            this.btnCargarPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarPlanilla.IconSize = 21;
            this.btnCargarPlanilla.Location = new System.Drawing.Point(352, 7);
            this.btnCargarPlanilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarPlanilla.Name = "btnCargarPlanilla";
            this.btnCargarPlanilla.Size = new System.Drawing.Size(132, 33);
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
            this.cmbBoxMesPlanilla.Location = new System.Drawing.Point(67, 12);
            this.cmbBoxMesPlanilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxMesPlanilla.Name = "cmbBoxMesPlanilla";
            this.cmbBoxMesPlanilla.Size = new System.Drawing.Size(83, 24);
            this.cmbBoxMesPlanilla.TabIndex = 3;
            // 
            // cmbBoxAñoPlanilla
            // 
            this.cmbBoxAñoPlanilla.FormattingEnabled = true;
            this.cmbBoxAñoPlanilla.Location = new System.Drawing.Point(232, 11);
            this.cmbBoxAñoPlanilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxAñoPlanilla.Name = "cmbBoxAñoPlanilla";
            this.cmbBoxAñoPlanilla.Size = new System.Drawing.Size(83, 24);
            this.cmbBoxAñoPlanilla.TabIndex = 5;
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Location = new System.Drawing.Point(189, 18);
            this.lblPlanilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(31, 16);
            this.lblPlanilla.TabIndex = 4;
            this.lblPlanilla.Text = "Año";
            // 
            // FrmPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private FontAwesome.Sharp.IconButton btnPDFPlanilla;
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