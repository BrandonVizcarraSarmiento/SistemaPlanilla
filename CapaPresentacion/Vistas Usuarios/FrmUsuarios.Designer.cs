namespace CapaPresentacion.Vistas_Usuarios
{
    partial class FrmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnBuscarUsuario = new FontAwesome.Sharp.IconButton();
            this.txtBusquedaUsuario = new System.Windows.Forms.TextBox();
            this.cboBusquedaUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvUsuario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnNuevoUsuario = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuario)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblTituloSeccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 21;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(365, 10);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(35, 23);
            this.btnLimpiarBuscador.TabIndex = 26;
            this.btnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarUsuario.IconSize = 21;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(324, 9);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarUsuario.TabIndex = 25;
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtBusquedaUsuario
            // 
            this.txtBusquedaUsuario.Location = new System.Drawing.Point(188, 11);
            this.txtBusquedaUsuario.Name = "txtBusquedaUsuario";
            this.txtBusquedaUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtBusquedaUsuario.TabIndex = 24;
            // 
            // cboBusquedaUsuario
            // 
            this.cboBusquedaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaUsuario.FormattingEnabled = true;
            this.cboBusquedaUsuario.Location = new System.Drawing.Point(83, 10);
            this.cboBusquedaUsuario.Name = "cboBusquedaUsuario";
            this.cboBusquedaUsuario.Size = new System.Drawing.Size(99, 21);
            this.cboBusquedaUsuario.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Buscar por:";
            // 
            // lblTituloSeccion
            // 
            this.lblTituloSeccion.AutoSize = true;
            this.lblTituloSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloSeccion.Location = new System.Drawing.Point(25, 18);
            this.lblTituloSeccion.Name = "lblTituloSeccion";
            this.lblTituloSeccion.Size = new System.Drawing.Size(130, 31);
            this.lblTituloSeccion.TabIndex = 1;
            this.lblTituloSeccion.Text = "Usuarios";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsuario.IconSize = 21;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(208, 330);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnNuevoUsuario);
            this.panel3.Controls.Add(this.btnEditarUsuario);
            this.panel3.Controls.Add(this.btnEliminarUsuario);
            this.panel3.Controls.Add(this.dtgvUsuario);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 389);
            this.panel3.TabIndex = 2;
            // 
            // dtgvUsuario
            // 
            this.dtgvUsuario.AllowUserToAddRows = false;
            this.dtgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvUsuario.ColumnHeadersHeight = 30;
            this.dtgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvUsuario.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvUsuario.EnableHeadersVisualStyles = false;
            this.dtgvUsuario.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvUsuario.Location = new System.Drawing.Point(31, 46);
            this.dtgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvUsuario.Name = "dtgvUsuario";
            this.dtgvUsuario.ReadOnly = true;
            this.dtgvUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvUsuario.RowHeadersWidth = 51;
            this.dtgvUsuario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvUsuario.RowTemplate.Height = 24;
            this.dtgvUsuario.Size = new System.Drawing.Size(1028, 279);
            this.dtgvUsuario.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Lista de usuarios";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarUsuario.IconSize = 21;
            this.btnEditarUsuario.Location = new System.Drawing.Point(121, 330);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnEditarUsuario.TabIndex = 29;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoUsuario.IconSize = 21;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(31, 330);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoUsuario.TabIndex = 30;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.btnLimpiarBuscador);
            this.panel6.Controls.Add(this.cboBusquedaUsuario);
            this.panel6.Controls.Add(this.btnBuscarUsuario);
            this.panel6.Controls.Add(this.txtBusquedaUsuario);
            this.panel6.Location = new System.Drawing.Point(293, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 41);
            this.panel6.TabIndex = 27;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1099, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuario)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.ComboBox cboBusquedaUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaUsuario;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscarUsuario;
        private System.Windows.Forms.DataGridView dtgvUsuario;
        private FontAwesome.Sharp.IconButton btnEditarUsuario;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btnNuevoUsuario;
    }
}