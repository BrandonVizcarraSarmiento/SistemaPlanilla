namespace CapaPresentacion.Vistas_Empleados
{
    partial class FrmEmpleados
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvEmpleado = new System.Windows.Forms.DataGridView();
            this.panelBuscarEmpleado = new System.Windows.Forms.Panel();
            this.cboOpcionBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleado = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnEditarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).BeginInit();
            this.panelBuscarEmpleado.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.lblTituloSeccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 90);
            this.panel2.TabIndex = 16;
            // 
            // lblTituloSeccion
            // 
            this.lblTituloSeccion.AutoSize = true;
            this.lblTituloSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloSeccion.Location = new System.Drawing.Point(36, 29);
            this.lblTituloSeccion.Name = "lblTituloSeccion";
            this.lblTituloSeccion.Size = new System.Drawing.Size(158, 31);
            this.lblTituloSeccion.TabIndex = 0;
            this.lblTituloSeccion.Text = "Empleados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.dtgvEmpleado);
            this.panel1.Controls.Add(this.panelBuscarEmpleado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 360);
            this.panel1.TabIndex = 17;
            // 
            // dtgvEmpleado
            // 
            this.dtgvEmpleado.AllowUserToAddRows = false;
            this.dtgvEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvEmpleado.ColumnHeadersHeight = 30;
            this.dtgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEmpleado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvEmpleado.EnableHeadersVisualStyles = false;
            this.dtgvEmpleado.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvEmpleado.Location = new System.Drawing.Point(81, 65);
            this.dtgvEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvEmpleado.Name = "dtgvEmpleado";
            this.dtgvEmpleado.ReadOnly = true;
            this.dtgvEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvEmpleado.RowHeadersWidth = 51;
            this.dtgvEmpleado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvEmpleado.RowTemplate.Height = 24;
            this.dtgvEmpleado.Size = new System.Drawing.Size(645, 204);
            this.dtgvEmpleado.TabIndex = 16;
            // 
            // panelBuscarEmpleado
            // 
            this.panelBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarEmpleado.Controls.Add(this.cboOpcionBuscar);
            this.panelBuscarEmpleado.Controls.Add(this.txtBuscarEmpleado);
            this.panelBuscarEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.panelBuscarEmpleado.Location = new System.Drawing.Point(248, 8);
            this.panelBuscarEmpleado.Name = "panelBuscarEmpleado";
            this.panelBuscarEmpleado.Size = new System.Drawing.Size(352, 52);
            this.panelBuscarEmpleado.TabIndex = 14;
            // 
            // cboOpcionBuscar
            // 
            this.cboOpcionBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscar.FormattingEnabled = true;
            this.cboOpcionBuscar.Location = new System.Drawing.Point(12, 19);
            this.cboOpcionBuscar.Name = "cboOpcionBuscar";
            this.cboOpcionBuscar.Size = new System.Drawing.Size(102, 21);
            this.cboOpcionBuscar.TabIndex = 74;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(121, 19);
            this.txtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarEmpleado.TabIndex = 12;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEmpleado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarEmpleado.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEmpleado.IconSize = 21;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(301, 17);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarEmpleado.TabIndex = 11;
            this.btnBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnNuevoEmpleado);
            this.panel3.Controls.Add(this.btnEditarEmpleado);
            this.panel3.Controls.Add(this.btnEliminarEmpleado);
            this.panel3.Location = new System.Drawing.Point(237, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 64);
            this.panel3.TabIndex = 13;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEmpleado.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoEmpleado.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoEmpleado.IconSize = 21;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(44, 14);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoEmpleado.TabIndex = 8;
            this.btnNuevoEmpleado.Text = "Nuevo";
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarEmpleado.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarEmpleado.IconSize = 21;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(151, 14);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(81, 33);
            this.btnEditarEmpleado.TabIndex = 10;
            this.btnEditarEmpleado.Text = "Editar";
            this.btnEditarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarEmpleado.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEmpleado.IconSize = 21;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(258, 14);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarEmpleado.TabIndex = 9;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).EndInit();
            this.panelBuscarEmpleado.ResumeLayout(false);
            this.panelBuscarEmpleado.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBuscarEmpleado;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private FontAwesome.Sharp.IconButton btnBuscarEmpleado;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoEmpleado;
        private FontAwesome.Sharp.IconButton btnEditarEmpleado;
        private FontAwesome.Sharp.IconButton btnEliminarEmpleado;
        private System.Windows.Forms.DataGridView dtgvEmpleado;
        private System.Windows.Forms.ComboBox cboOpcionBuscar;
    }
}