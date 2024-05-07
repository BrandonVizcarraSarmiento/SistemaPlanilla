namespace CapaPresentacion.Vistas_Cargo
{
    partial class FrmCargo
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
            this.lblCargos = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBuscarCargos = new System.Windows.Forms.Panel();
            this.txtBuscarCargo = new System.Windows.Forms.TextBox();
            this.btnBuscarCargos = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoCargo = new FontAwesome.Sharp.IconButton();
            this.btnEditarCargo = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCargo = new FontAwesome.Sharp.IconButton();
            this.panelSegundoCargo = new System.Windows.Forms.Panel();
            this.dtgvCargo = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSegundoCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCargos.Location = new System.Drawing.Point(52, 37);
            this.lblCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(133, 39);
            this.lblCargos.TabIndex = 0;
            this.lblCargos.Text = "Cargos";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.panelTitulo.Controls.Add(this.lblCargos);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(907, 106);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarCargo);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarCargos);
            this.panelBuscarCargos.Location = new System.Drawing.Point(273, 117);
            this.panelBuscarCargos.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(329, 58);
            this.panelBuscarCargos.TabIndex = 15;
            // 
            // txtBuscarCargo
            // 
            this.txtBuscarCargo.Location = new System.Drawing.Point(25, 16);
            this.txtBuscarCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCargo.Name = "txtBuscarCargo";
            this.txtBuscarCargo.Size = new System.Drawing.Size(232, 22);
            this.txtBuscarCargo.TabIndex = 12;
            // 
            // btnBuscarCargos
            // 
            this.btnBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCargos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCargos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCargos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCargos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCargos.IconSize = 21;
            this.btnBuscarCargos.Location = new System.Drawing.Point(267, 12);
            this.btnBuscarCargos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCargos.Name = "btnBuscarCargos";
            this.btnBuscarCargos.Size = new System.Drawing.Size(47, 28);
            this.btnBuscarCargos.TabIndex = 11;
            this.btnBuscarCargos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCargos.UseVisualStyleBackColor = false;
            this.btnBuscarCargos.Click += new System.EventHandler(this.btnBuscarCargos_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnNuevoCargo);
            this.panel3.Controls.Add(this.btnEditarCargo);
            this.panel3.Controls.Add(this.btnEliminarCargo);
            this.panel3.Location = new System.Drawing.Point(193, 454);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 74);
            this.panel3.TabIndex = 16;
            // 
            // btnNuevoCargo
            // 
            this.btnNuevoCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoCargo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCargo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCargo.IconSize = 21;
            this.btnNuevoCargo.Location = new System.Drawing.Point(59, 12);
            this.btnNuevoCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCargo.Name = "btnNuevoCargo";
            this.btnNuevoCargo.Size = new System.Drawing.Size(108, 41);
            this.btnNuevoCargo.TabIndex = 8;
            this.btnNuevoCargo.Text = "Nuevo";
            this.btnNuevoCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCargo.UseVisualStyleBackColor = false;
            this.btnNuevoCargo.Click += new System.EventHandler(this.btnNuevoCargo_Click);
            // 
            // btnEditarCargo
            // 
            this.btnEditarCargo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarCargo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCargo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCargo.IconSize = 21;
            this.btnEditarCargo.Location = new System.Drawing.Point(201, 12);
            this.btnEditarCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCargo.Name = "btnEditarCargo";
            this.btnEditarCargo.Size = new System.Drawing.Size(108, 41);
            this.btnEditarCargo.TabIndex = 10;
            this.btnEditarCargo.Text = "Editar";
            this.btnEditarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCargo.UseVisualStyleBackColor = false;
            this.btnEditarCargo.Click += new System.EventHandler(this.btnEditarCargo_Click);
            // 
            // btnEliminarCargo
            // 
            this.btnEliminarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCargo.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCargo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCargo.IconSize = 21;
            this.btnEliminarCargo.Location = new System.Drawing.Point(344, 12);
            this.btnEliminarCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCargo.Name = "btnEliminarCargo";
            this.btnEliminarCargo.Size = new System.Drawing.Size(108, 41);
            this.btnEliminarCargo.TabIndex = 9;
            this.btnEliminarCargo.Text = "Eliminar";
            this.btnEliminarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCargo.UseVisualStyleBackColor = false;
            this.btnEliminarCargo.Click += new System.EventHandler(this.btnEliminarCargo_Click);
            // 
            // panelSegundoCargo
            // 
            this.panelSegundoCargo.Controls.Add(this.dtgvCargo);
            this.panelSegundoCargo.Controls.Add(this.panelBuscarCargos);
            this.panelSegundoCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSegundoCargo.Location = new System.Drawing.Point(0, 0);
            this.panelSegundoCargo.Margin = new System.Windows.Forms.Padding(4);
            this.panelSegundoCargo.Name = "panelSegundoCargo";
            this.panelSegundoCargo.Size = new System.Drawing.Size(907, 554);
            this.panelSegundoCargo.TabIndex = 17;
            // 
            // dtgvCargo
            // 
            this.dtgvCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCargo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCargo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvCargo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCargo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvCargo.ColumnHeadersHeight = 30;
            this.dtgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCargo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvCargo.EnableHeadersVisualStyles = false;
            this.dtgvCargo.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvCargo.Location = new System.Drawing.Point(175, 181);
            this.dtgvCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCargo.Name = "dtgvCargo";
            this.dtgvCargo.ReadOnly = true;
            this.dtgvCargo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCargo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvCargo.RowHeadersWidth = 51;
            this.dtgvCargo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvCargo.RowTemplate.Height = 24;
            this.dtgvCargo.Size = new System.Drawing.Size(579, 251);
            this.dtgvCargo.TabIndex = 16;
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSegundoCargo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCargo";
            this.Text = "FrmCargo";
            this.Load += new System.EventHandler(this.FrmCargo_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelSegundoCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarCargo;
        private FontAwesome.Sharp.IconButton btnBuscarCargos;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoCargo;
        private FontAwesome.Sharp.IconButton btnEditarCargo;
        private FontAwesome.Sharp.IconButton btnEliminarCargo;
        private System.Windows.Forms.Panel panelSegundoCargo;
        private System.Windows.Forms.DataGridView dtgvCargo;
    }
}