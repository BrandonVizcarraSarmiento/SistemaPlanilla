namespace CapaPresentacion.Vistas_Conceptos
{
    partial class FrmConceptos
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.panelSegundoCargo = new System.Windows.Forms.Panel();
            this.dtgvConceptos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevosConceptos = new FontAwesome.Sharp.IconButton();
            this.btnEditarConceptos = new FontAwesome.Sharp.IconButton();
            this.btnEliminarConceptos = new FontAwesome.Sharp.IconButton();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.txtBuscarConceptos = new System.Windows.Forms.TextBox();
            this.btnBuscarConceptos = new FontAwesome.Sharp.IconButton();
            this.panelTitulo.SuspendLayout();
            this.panelSegundoCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConceptos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.panelTitulo.Controls.Add(this.lblConcepto);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(912, 107);
            this.panelTitulo.TabIndex = 2;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConcepto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblConcepto.Location = new System.Drawing.Point(52, 37);
            this.lblConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(189, 39);
            this.lblConcepto.TabIndex = 0;
            this.lblConcepto.Text = "Conceptos";
            // 
            // panelSegundoCargo
            // 
            this.panelSegundoCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSegundoCargo.Controls.Add(this.dtgvConceptos);
            this.panelSegundoCargo.Controls.Add(this.panel3);
            this.panelSegundoCargo.Controls.Add(this.panelBuscar);
            this.panelSegundoCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSegundoCargo.Location = new System.Drawing.Point(0, 107);
            this.panelSegundoCargo.Margin = new System.Windows.Forms.Padding(4);
            this.panelSegundoCargo.Name = "panelSegundoCargo";
            this.panelSegundoCargo.Size = new System.Drawing.Size(912, 447);
            this.panelSegundoCargo.TabIndex = 18;
            // 
            // dtgvConceptos
            // 
            this.dtgvConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvConceptos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvConceptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvConceptos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvConceptos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvConceptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvConceptos.ColumnHeadersHeight = 30;
            this.dtgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvConceptos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvConceptos.EnableHeadersVisualStyles = false;
            this.dtgvConceptos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvConceptos.Location = new System.Drawing.Point(187, 90);
            this.dtgvConceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvConceptos.Name = "dtgvConceptos";
            this.dtgvConceptos.ReadOnly = true;
            this.dtgvConceptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvConceptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvConceptos.RowHeadersWidth = 51;
            this.dtgvConceptos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvConceptos.RowTemplate.Height = 24;
            this.dtgvConceptos.Size = new System.Drawing.Size(507, 251);
            this.dtgvConceptos.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnNuevosConceptos);
            this.panel3.Controls.Add(this.btnEditarConceptos);
            this.panel3.Controls.Add(this.btnEliminarConceptos);
            this.panel3.Location = new System.Drawing.Point(187, 347);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 74);
            this.panel3.TabIndex = 20;
            // 
            // btnNuevosConceptos
            // 
            this.btnNuevosConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevosConceptos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevosConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevosConceptos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevosConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevosConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevosConceptos.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevosConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevosConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevosConceptos.IconSize = 21;
            this.btnNuevosConceptos.Location = new System.Drawing.Point(59, 12);
            this.btnNuevosConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevosConceptos.Name = "btnNuevosConceptos";
            this.btnNuevosConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnNuevosConceptos.TabIndex = 8;
            this.btnNuevosConceptos.Text = "Nuevo";
            this.btnNuevosConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevosConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevosConceptos.UseVisualStyleBackColor = false;
            this.btnNuevosConceptos.Click += new System.EventHandler(this.btnNuevosConceptos_Click);
            // 
            // btnEditarConceptos
            // 
            this.btnEditarConceptos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarConceptos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarConceptos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarConceptos.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarConceptos.IconSize = 21;
            this.btnEditarConceptos.Location = new System.Drawing.Point(201, 12);
            this.btnEditarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarConceptos.Name = "btnEditarConceptos";
            this.btnEditarConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnEditarConceptos.TabIndex = 10;
            this.btnEditarConceptos.Text = "Editar";
            this.btnEditarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarConceptos.UseVisualStyleBackColor = false;
            this.btnEditarConceptos.Click += new System.EventHandler(this.btnEditarConceptos_Click);
            // 
            // btnEliminarConceptos
            // 
            this.btnEliminarConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarConceptos.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarConceptos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarConceptos.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarConceptos.IconSize = 21;
            this.btnEliminarConceptos.Location = new System.Drawing.Point(344, 12);
            this.btnEliminarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarConceptos.Name = "btnEliminarConceptos";
            this.btnEliminarConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnEliminarConceptos.TabIndex = 9;
            this.btnEliminarConceptos.Text = "Eliminar";
            this.btnEliminarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarConceptos.UseVisualStyleBackColor = false;
            this.btnEliminarConceptos.Click += new System.EventHandler(this.btnEliminarConceptos_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.Controls.Add(this.txtBuscarConceptos);
            this.panelBuscar.Controls.Add(this.btnBuscarConceptos);
            this.panelBuscar.Location = new System.Drawing.Point(273, 10);
            this.panelBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(329, 58);
            this.panelBuscar.TabIndex = 19;
            // 
            // txtBuscarConceptos
            // 
            this.txtBuscarConceptos.Location = new System.Drawing.Point(25, 16);
            this.txtBuscarConceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarConceptos.Name = "txtBuscarConceptos";
            this.txtBuscarConceptos.Size = new System.Drawing.Size(232, 22);
            this.txtBuscarConceptos.TabIndex = 12;
            // 
            // btnBuscarConceptos
            // 
            this.btnBuscarConceptos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarConceptos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConceptos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarConceptos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarConceptos.IconSize = 21;
            this.btnBuscarConceptos.Location = new System.Drawing.Point(267, 12);
            this.btnBuscarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarConceptos.Name = "btnBuscarConceptos";
            this.btnBuscarConceptos.Size = new System.Drawing.Size(47, 28);
            this.btnBuscarConceptos.TabIndex = 11;
            this.btnBuscarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarConceptos.UseVisualStyleBackColor = false;
            this.btnBuscarConceptos.Click += new System.EventHandler(this.btnBuscarConceptos_Click);
            // 
            // FrmConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 554);
            this.Controls.Add(this.panelSegundoCargo);
            this.Controls.Add(this.panelTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConceptos";
            this.Text = "FrmConceptos";
            this.Load += new System.EventHandler(this.FrmConceptos_Load_1);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSegundoCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConceptos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Panel panelSegundoCargo;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscarConceptos;
        private FontAwesome.Sharp.IconButton btnBuscarConceptos;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevosConceptos;
        private FontAwesome.Sharp.IconButton btnEditarConceptos;
        private FontAwesome.Sharp.IconButton btnEliminarConceptos;
        private System.Windows.Forms.DataGridView dtgvConceptos;
    }
}