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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblCargos.Location = new System.Drawing.Point(39, 30);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(108, 31);
            this.lblCargos.TabIndex = 0;
            this.lblCargos.Text = "Cargos";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panelTitulo.Controls.Add(this.lblCargos);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(680, 86);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarCargo);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarCargos);
            this.panelBuscarCargos.Location = new System.Drawing.Point(205, 95);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 15;
            // 
            // txtBuscarCargo
            // 
            this.txtBuscarCargo.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCargo.Name = "txtBuscarCargo";
            this.txtBuscarCargo.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarCargo.TabIndex = 12;
            // 
            // btnBuscarCargos
            // 
            this.btnBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCargos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCargos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCargos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCargos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCargos.IconSize = 21;
            this.btnBuscarCargos.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarCargos.Name = "btnBuscarCargos";
            this.btnBuscarCargos.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarCargos.TabIndex = 11;
            this.btnBuscarCargos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCargos.UseVisualStyleBackColor = false;
            this.btnBuscarCargos.Click += new System.EventHandler(this.btnBuscarCargos_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.btnNuevoCargo);
            this.panel3.Controls.Add(this.btnEditarCargo);
            this.panel3.Controls.Add(this.btnEliminarCargo);
            this.panel3.Location = new System.Drawing.Point(145, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 60);
            this.panel3.TabIndex = 16;
            // 
            // btnNuevoCargo
            // 
            this.btnNuevoCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoCargo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCargo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCargo.IconSize = 21;
            this.btnNuevoCargo.Location = new System.Drawing.Point(44, 10);
            this.btnNuevoCargo.Name = "btnNuevoCargo";
            this.btnNuevoCargo.Size = new System.Drawing.Size(81, 33);
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
            this.btnEditarCargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCargo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCargo.IconSize = 21;
            this.btnEditarCargo.Location = new System.Drawing.Point(151, 10);
            this.btnEditarCargo.Name = "btnEditarCargo";
            this.btnEditarCargo.Size = new System.Drawing.Size(81, 33);
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
            this.btnEliminarCargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCargo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCargo.IconSize = 21;
            this.btnEliminarCargo.Location = new System.Drawing.Point(258, 10);
            this.btnEliminarCargo.Name = "btnEliminarCargo";
            this.btnEliminarCargo.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarCargo.TabIndex = 9;
            this.btnEliminarCargo.Text = "Eliminar";
            this.btnEliminarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCargo.UseVisualStyleBackColor = false;
            this.btnEliminarCargo.Click += new System.EventHandler(this.btnEliminarCargo_Click);
            // 
            // panelSegundoCargo
            // 
            this.panelSegundoCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panelSegundoCargo.Controls.Add(this.dtgvCargo);
            this.panelSegundoCargo.Controls.Add(this.panelBuscarCargos);
            this.panelSegundoCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSegundoCargo.Location = new System.Drawing.Point(0, 0);
            this.panelSegundoCargo.Name = "panelSegundoCargo";
            this.panelSegundoCargo.Size = new System.Drawing.Size(680, 450);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCargo.ColumnHeadersHeight = 30;
            this.dtgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCargo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCargo.EnableHeadersVisualStyles = false;
            this.dtgvCargo.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvCargo.Location = new System.Drawing.Point(131, 147);
            this.dtgvCargo.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvCargo.Name = "dtgvCargo";
            this.dtgvCargo.ReadOnly = true;
            this.dtgvCargo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCargo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCargo.RowHeadersWidth = 51;
            this.dtgvCargo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvCargo.RowTemplate.Height = 24;
            this.dtgvCargo.Size = new System.Drawing.Size(434, 204);
            this.dtgvCargo.TabIndex = 16;
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSegundoCargo);
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