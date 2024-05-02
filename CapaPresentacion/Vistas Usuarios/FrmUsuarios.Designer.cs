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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cdoEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNuevoUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEditarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvUsuario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuario)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblTituloSeccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(630, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 389);
            this.panel2.TabIndex = 1;
            // 
            // cdoEstado
            // 
            this.cdoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdoEstado.FormattingEnabled = true;
            this.cdoEstado.Location = new System.Drawing.Point(15, 247);
            this.cdoEstado.Name = "cdoEstado";
            this.cdoEstado.Size = new System.Drawing.Size(255, 21);
            this.cdoEstado.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 231);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(15, 207);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(255, 21);
            this.cboRol.TabIndex = 20;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(12, 191);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 19;
            this.lblRol.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 113);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 16;
            this.lblClave.Text = "Clave";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 74);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(15, 129);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(255, 20);
            this.txtClave.TabIndex = 14;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(15, 90);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(255, 20);
            this.txtCorreo.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtgvUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 389);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Confirmar clave";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(15, 168);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(255, 20);
            this.txtConfirmarClave.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.btnNuevoUsuario);
            this.panel4.Controls.Add(this.btnEditarUsuario);
            this.panel4.Controls.Add(this.btnEliminarUsuario);
            this.panel4.Location = new System.Drawing.Point(8, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 41);
            this.panel4.TabIndex = 25;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoUsuario.IconSize = 21;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(11, 5);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoUsuario.TabIndex = 8;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarUsuario.IconSize = 21;
            this.btnEditarUsuario.Location = new System.Drawing.Point(101, 5);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnEditarUsuario.TabIndex = 10;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarUsuario.IconSize = 21;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(190, 5);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Usuario";
            // 
            // dtgvUsuario
            // 
            this.dtgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgvUsuario.ColumnHeadersHeight = 30;
            this.dtgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Clave,
            this.Correo,
            this.IdRol,
            this.Rol,
            this.Estado,
            this.EstadoValor});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvUsuario.DefaultCellStyle = dataGridViewCellStyle26;
            this.dtgvUsuario.EnableHeadersVisualStyles = false;
            this.dtgvUsuario.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvUsuario.Location = new System.Drawing.Point(31, 49);
            this.dtgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvUsuario.Name = "dtgvUsuario";
            this.dtgvUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtgvUsuario.RowHeadersWidth = 51;
            this.dtgvUsuario.RowTemplate.Height = 24;
            this.dtgvUsuario.Size = new System.Drawing.Size(567, 273);
            this.dtgvUsuario.TabIndex = 1;
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
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 49;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 92;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.Visible = false;
            this.Clave.Width = 78;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 85;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.Visible = false;
            this.IdRol.Width = 70;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.Width = 55;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 82;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 121;
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
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtConfirmarClave);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cdoEstado);
            this.panel5.Controls.Add(this.txtCorreo);
            this.panel5.Controls.Add(this.lblEstado);
            this.panel5.Controls.Add(this.txtClave);
            this.panel5.Controls.Add(this.cboRol);
            this.panel5.Controls.Add(this.lblCorreo);
            this.panel5.Controls.Add(this.lblRol);
            this.panel5.Controls.Add(this.lblClave);
            this.panel5.Controls.Add(this.txtNombre);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 286);
            this.panel5.TabIndex = 27;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuario)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cdoEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnNuevoUsuario;
        private FontAwesome.Sharp.IconButton btnEditarUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.Panel panel5;
    }
}