﻿namespace CapaPresentacion.Vistas_Asistencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloAsistencias = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbBoxMesAsistencia = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cmbBoxAñoAsistencia = new System.Windows.Forms.ComboBox();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvAsistencia = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpiarAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnGuardarAsistencias = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargarAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnPDFAsistencia = new FontAwesome.Sharp.IconButton();
            this.paneltitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsistencia)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloAsistencias
            // 
            this.lblTituloAsistencias.AutoSize = true;
            this.lblTituloAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAsistencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloAsistencias.Location = new System.Drawing.Point(36, 31);
            this.lblTituloAsistencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAsistencias.Name = "lblTituloAsistencias";
            this.lblTituloAsistencias.Size = new System.Drawing.Size(201, 39);
            this.lblTituloAsistencias.TabIndex = 1;
            this.lblTituloAsistencias.Text = "Asistencias";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMes.Location = new System.Drawing.Point(23, 17);
            this.lblMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(33, 16);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "Mes";
            // 
            // cmbBoxMesAsistencia
            // 
            this.cmbBoxMesAsistencia.FormattingEnabled = true;
            this.cmbBoxMesAsistencia.Location = new System.Drawing.Point(67, 12);
            this.cmbBoxMesAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxMesAsistencia.Name = "cmbBoxMesAsistencia";
            this.cmbBoxMesAsistencia.Size = new System.Drawing.Size(83, 24);
            this.cmbBoxMesAsistencia.TabIndex = 3;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAño.Location = new System.Drawing.Point(189, 18);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(31, 16);
            this.lblAño.TabIndex = 4;
            this.lblAño.Text = "Año";
            // 
            // cmbBoxAñoAsistencia
            // 
            this.cmbBoxAñoAsistencia.FormattingEnabled = true;
            this.cmbBoxAñoAsistencia.Location = new System.Drawing.Point(232, 11);
            this.cmbBoxAñoAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxAñoAsistencia.Name = "cmbBoxAñoAsistencia";
            this.cmbBoxAñoAsistencia.Size = new System.Drawing.Size(83, 24);
            this.cmbBoxAñoAsistencia.TabIndex = 5;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.paneltitulo.Controls.Add(this.lblTituloAsistencias);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(756, 98);
            this.paneltitulo.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.dtgvAsistencia);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 456);
            this.panel1.TabIndex = 8;
            // 
            // dtgvAsistencia
            // 
            this.dtgvAsistencia.AllowUserToAddRows = false;
            this.dtgvAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAsistencia.ColumnHeadersHeight = 30;
            this.dtgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAsistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAsistencia.EnableHeadersVisualStyles = false;
            this.dtgvAsistencia.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvAsistencia.Location = new System.Drawing.Point(87, 75);
            this.dtgvAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvAsistencia.Name = "dtgvAsistencia";
            this.dtgvAsistencia.ReadOnly = true;
            this.dtgvAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAsistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAsistencia.RowHeadersWidth = 51;
            this.dtgvAsistencia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvAsistencia.RowTemplate.Height = 24;
            this.dtgvAsistencia.Size = new System.Drawing.Size(579, 252);
            this.dtgvAsistencia.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnPDFAsistencia);
            this.panel3.Controls.Add(this.btnLimpiarAsistencias);
            this.panel3.Controls.Add(this.btnGuardarAsistencias);
            this.panel3.Location = new System.Drawing.Point(54, 333);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 63);
            this.panel3.TabIndex = 11;
            // 
            // btnLimpiarAsistencias
            // 
            this.btnLimpiarAsistencias.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarAsistencias.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarAsistencias.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.btnLimpiarAsistencias.IconColor = System.Drawing.Color.White;
            this.btnLimpiarAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarAsistencias.IconSize = 21;
            this.btnLimpiarAsistencias.Location = new System.Drawing.Point(261, 10);
            this.btnLimpiarAsistencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarAsistencias.Name = "btnLimpiarAsistencias";
            this.btnLimpiarAsistencias.Size = new System.Drawing.Size(132, 44);
            this.btnLimpiarAsistencias.TabIndex = 9;
            this.btnLimpiarAsistencias.Text = "Limpiar";
            this.btnLimpiarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAsistencias.UseVisualStyleBackColor = false;
            this.btnLimpiarAsistencias.Click += new System.EventHandler(this.btnLimpiarAsistencias_Click);
            // 
            // btnGuardarAsistencias
            // 
            this.btnGuardarAsistencias.BackColor = System.Drawing.Color.Tan;
            this.btnGuardarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAsistencias.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAsistencias.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnGuardarAsistencias.IconColor = System.Drawing.Color.White;
            this.btnGuardarAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarAsistencias.IconSize = 21;
            this.btnGuardarAsistencias.Location = new System.Drawing.Point(33, 10);
            this.btnGuardarAsistencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarAsistencias.Name = "btnGuardarAsistencias";
            this.btnGuardarAsistencias.Size = new System.Drawing.Size(132, 44);
            this.btnGuardarAsistencias.TabIndex = 10;
            this.btnGuardarAsistencias.Text = "Guardar";
            this.btnGuardarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarAsistencias.UseVisualStyleBackColor = false;
            this.btnGuardarAsistencias.Click += new System.EventHandler(this.btnGuardarAsistencias_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Controls.Add(this.btnCargarAsistencias);
            this.panel2.Controls.Add(this.cmbBoxMesAsistencia);
            this.panel2.Controls.Add(this.cmbBoxAñoAsistencia);
            this.panel2.Controls.Add(this.lblAño);
            this.panel2.Location = new System.Drawing.Point(123, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 48);
            this.panel2.TabIndex = 10;
            // 
            // btnCargarAsistencias
            // 
            this.btnCargarAsistencias.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCargarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarAsistencias.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnCargarAsistencias.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.btnCargarAsistencias.IconColor = System.Drawing.Color.White;
            this.btnCargarAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarAsistencias.IconSize = 21;
            this.btnCargarAsistencias.Location = new System.Drawing.Point(352, 7);
            this.btnCargarAsistencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarAsistencias.Name = "btnCargarAsistencias";
            this.btnCargarAsistencias.Size = new System.Drawing.Size(132, 33);
            this.btnCargarAsistencias.TabIndex = 9;
            this.btnCargarAsistencias.Text = "Cargar";
            this.btnCargarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarAsistencias.UseVisualStyleBackColor = false;
            this.btnCargarAsistencias.Click += new System.EventHandler(this.btnCargarAsistencias_Click);
            // 
            // btnPDFAsistencia
            // 
            this.btnPDFAsistencia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPDFAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDFAsistencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDFAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnPDFAsistencia.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnPDFAsistencia.IconColor = System.Drawing.Color.White;
            this.btnPDFAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPDFAsistencia.IconSize = 21;
            this.btnPDFAsistencia.Location = new System.Drawing.Point(480, 10);
            this.btnPDFAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDFAsistencia.Name = "btnPDFAsistencia";
            this.btnPDFAsistencia.Size = new System.Drawing.Size(132, 44);
            this.btnPDFAsistencia.TabIndex = 11;
            this.btnPDFAsistencia.Text = "PDF";
            this.btnPDFAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDFAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDFAsistencia.UseVisualStyleBackColor = false;
            this.btnPDFAsistencia.Click += new System.EventHandler(this.btnPDFAsistencia_Click);
            // 
            // FrmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAsistencias";
            this.Text = "FrmAsistencias";
            this.Load += new System.EventHandler(this.FrmAsistencias_Load);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsistencia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAsistencias;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbBoxMesAsistencia;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cmbBoxAñoAsistencia;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCargarAsistencias;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnGuardarAsistencias;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLimpiarAsistencias;
        private System.Windows.Forms.DataGridView dtgvAsistencia;
        private FontAwesome.Sharp.IconButton btnPDFAsistencia;
    }
}