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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvBanco = new System.Windows.Forms.DataGridView();
            this.btnNuevoBanco = new FontAwesome.Sharp.IconButton();
            this.btnEliminarBanco = new FontAwesome.Sharp.IconButton();
            this.btnEditarBanco = new FontAwesome.Sharp.IconButton();
            this.btnBuscarBanco = new FontAwesome.Sharp.IconButton();
            this.txtBuscarBanco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBanco
            // 
            this.dtgvBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvBanco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvBanco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvBanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBanco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBanco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBanco.ColumnHeadersHeight = 30;
            this.dtgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBanco.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBanco.EnableHeadersVisualStyles = false;
            this.dtgvBanco.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvBanco.Location = new System.Drawing.Point(85, 132);
            this.dtgvBanco.Name = "dtgvBanco";
            this.dtgvBanco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBanco.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBanco.RowHeadersWidth = 51;
            this.dtgvBanco.RowTemplate.Height = 24;
            this.dtgvBanco.Size = new System.Drawing.Size(578, 303);
            this.dtgvBanco.TabIndex = 0;
            // 
            // btnNuevoBanco
            // 
            this.btnNuevoBanco.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNuevoBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoBanco.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoBanco.IconSize = 21;
            this.btnNuevoBanco.Location = new System.Drawing.Point(85, 466);
            this.btnNuevoBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoBanco.Name = "btnNuevoBanco";
            this.btnNuevoBanco.Size = new System.Drawing.Size(108, 41);
            this.btnNuevoBanco.TabIndex = 8;
            this.btnNuevoBanco.Text = "Nuevo";
            this.btnNuevoBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoBanco.UseVisualStyleBackColor = false;
            // 
            // btnEliminarBanco
            // 
            this.btnEliminarBanco.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarBanco.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarBanco.IconSize = 21;
            this.btnEliminarBanco.Location = new System.Drawing.Point(520, 466);
            this.btnEliminarBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarBanco.Name = "btnEliminarBanco";
            this.btnEliminarBanco.Size = new System.Drawing.Size(108, 41);
            this.btnEliminarBanco.TabIndex = 9;
            this.btnEliminarBanco.Text = "Eliminar";
            this.btnEliminarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarBanco.UseVisualStyleBackColor = false;
            // 
            // btnEditarBanco
            // 
            this.btnEditarBanco.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarBanco.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarBanco.IconSize = 21;
            this.btnEditarBanco.Location = new System.Drawing.Point(316, 466);
            this.btnEditarBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarBanco.Name = "btnEditarBanco";
            this.btnEditarBanco.Size = new System.Drawing.Size(108, 41);
            this.btnEditarBanco.TabIndex = 10;
            this.btnEditarBanco.Text = "Editar";
            this.btnEditarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarBanco.UseVisualStyleBackColor = false;
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarBanco.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarBanco.IconSize = 21;
            this.btnBuscarBanco.Location = new System.Drawing.Point(485, 44);
            this.btnBuscarBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(72, 34);
            this.btnBuscarBanco.TabIndex = 11;
            this.btnBuscarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarBanco.UseVisualStyleBackColor = false;
            // 
            // txtBuscarBanco
            // 
            this.txtBuscarBanco.Location = new System.Drawing.Point(226, 50);
            this.txtBuscarBanco.Name = "txtBuscarBanco";
            this.txtBuscarBanco.Size = new System.Drawing.Size(232, 22);
            this.txtBuscarBanco.TabIndex = 12;
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtBuscarBanco);
            this.Controls.Add(this.btnBuscarBanco);
            this.Controls.Add(this.btnEditarBanco);
            this.Controls.Add(this.btnEliminarBanco);
            this.Controls.Add(this.btnNuevoBanco);
            this.Controls.Add(this.dtgvBanco);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBanco";
            this.Text = "FrmBanco";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBanco;
        private FontAwesome.Sharp.IconButton btnNuevoBanco;
        private FontAwesome.Sharp.IconButton btnEliminarBanco;
        private FontAwesome.Sharp.IconButton btnEditarBanco;
        private FontAwesome.Sharp.IconButton btnBuscarBanco;
        private System.Windows.Forms.TextBox txtBuscarBanco;
    }
}