namespace CapaPresentacion.Vistas_Banco
{
    partial class FrmBanco
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.dtgvBanco = new System.Windows.Forms.DataGridView();
            this.btnEditarBanco = new FontAwesome.Sharp.IconButton();
            this.btnEliminarBanco = new FontAwesome.Sharp.IconButton();
            this.btnNuevoBanco = new FontAwesome.Sharp.IconButton();
            this.btnBuscarBanco = new FontAwesome.Sharp.IconButton();
            this.txtBuscarBanco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanco)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.lblTituloSeccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 90);
            this.panel2.TabIndex = 14;
            // 
            // lblTituloSeccion
            // 
            this.lblTituloSeccion.AutoSize = true;
            this.lblTituloSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloSeccion.Location = new System.Drawing.Point(39, 30);
            this.lblTituloSeccion.Name = "lblTituloSeccion";
            this.lblTituloSeccion.Size = new System.Drawing.Size(111, 31);
            this.lblTituloSeccion.TabIndex = 0;
            this.lblTituloSeccion.Text = "Bancos";
            // 
            // dtgvBanco
            // 
            this.dtgvBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvBanco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvBanco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBanco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBanco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvBanco.ColumnHeadersHeight = 30;
            this.dtgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBanco.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvBanco.EnableHeadersVisualStyles = false;
            this.dtgvBanco.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvBanco.Location = new System.Drawing.Point(149, 63);
            this.dtgvBanco.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvBanco.Name = "dtgvBanco";
            this.dtgvBanco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBanco.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvBanco.RowHeadersWidth = 51;
            this.dtgvBanco.RowTemplate.Height = 24;
            this.dtgvBanco.Size = new System.Drawing.Size(434, 223);
            this.dtgvBanco.TabIndex = 0;
            // 
            // btnEditarBanco
            // 
            this.btnEditarBanco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarBanco.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarBanco.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarBanco.IconSize = 21;
            this.btnEditarBanco.Location = new System.Drawing.Point(151, 14);
            this.btnEditarBanco.Name = "btnEditarBanco";
            this.btnEditarBanco.Size = new System.Drawing.Size(81, 33);
            this.btnEditarBanco.TabIndex = 10;
            this.btnEditarBanco.Text = "Editar";
            this.btnEditarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarBanco.UseVisualStyleBackColor = false;
            // 
            // btnEliminarBanco
            // 
            this.btnEliminarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarBanco.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarBanco.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarBanco.IconSize = 21;
            this.btnEliminarBanco.Location = new System.Drawing.Point(258, 14);
            this.btnEliminarBanco.Name = "btnEliminarBanco";
            this.btnEliminarBanco.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarBanco.TabIndex = 9;
            this.btnEliminarBanco.Text = "Eliminar";
            this.btnEliminarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarBanco.UseVisualStyleBackColor = false;
            // 
            // btnNuevoBanco
            // 
            this.btnNuevoBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoBanco.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoBanco.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoBanco.IconSize = 21;
            this.btnNuevoBanco.Location = new System.Drawing.Point(44, 14);
            this.btnNuevoBanco.Name = "btnNuevoBanco";
            this.btnNuevoBanco.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoBanco.TabIndex = 8;
            this.btnNuevoBanco.Text = "Nuevo";
            this.btnNuevoBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoBanco.UseVisualStyleBackColor = false;
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarBanco.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarBanco.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarBanco.IconSize = 21;
            this.btnBuscarBanco.Location = new System.Drawing.Point(208, 17);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarBanco.TabIndex = 11;
            this.btnBuscarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarBanco.UseVisualStyleBackColor = false;
            // 
            // txtBuscarBanco
            // 
            this.txtBuscarBanco.Location = new System.Drawing.Point(19, 19);
            this.txtBuscarBanco.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarBanco.Name = "txtBuscarBanco";
            this.txtBuscarBanco.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarBanco.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtgvBanco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 393);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.txtBuscarBanco);
            this.panel4.Controls.Add(this.btnBuscarBanco);
            this.panel4.Location = new System.Drawing.Point(239, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 52);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnNuevoBanco);
            this.panel3.Controls.Add(this.btnEditarBanco);
            this.panel3.Controls.Add(this.btnEliminarBanco);
            this.panel3.Location = new System.Drawing.Point(179, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 64);
            this.panel3.TabIndex = 13;
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBanco";
            this.Text = "FrmBanco";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanco)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.DataGridView dtgvBanco;
        private FontAwesome.Sharp.IconButton btnEditarBanco;
        private FontAwesome.Sharp.IconButton btnEliminarBanco;
        private FontAwesome.Sharp.IconButton btnNuevoBanco;
        private FontAwesome.Sharp.IconButton btnBuscarBanco;
        private System.Windows.Forms.TextBox txtBuscarBanco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}