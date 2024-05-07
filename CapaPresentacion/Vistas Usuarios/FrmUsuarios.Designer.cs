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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnBuscarUsuario = new FontAwesome.Sharp.IconButton();
            this.txtBusquedaUsuario = new System.Windows.Forms.TextBox();
            this.cboBusquedaUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnLimpiarBuscador);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.txtBusquedaUsuario);
            this.panel1.Controls.Add(this.cboBusquedaUsuario);
            this.panel1.Controls.Add(this.label5);
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
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(923, 25);
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
            this.btnBuscarUsuario.Location = new System.Drawing.Point(882, 25);
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
            this.txtBusquedaUsuario.Location = new System.Drawing.Point(663, 26);
            this.txtBusquedaUsuario.Name = "txtBusquedaUsuario";
            this.txtBusquedaUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtBusquedaUsuario.TabIndex = 24;
            // 
            // cboBusquedaUsuario
            // 
            this.cboBusquedaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaUsuario.FormattingEnabled = true;
            this.cboBusquedaUsuario.Location = new System.Drawing.Point(576, 25);
            this.cboBusquedaUsuario.Name = "cboBusquedaUsuario";
            this.cboBusquedaUsuario.Size = new System.Drawing.Size(81, 21);
            this.cboBusquedaUsuario.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 28);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(796, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 389);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.txtindice);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtConfirmarClave);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cboEstado);
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
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(206, 14);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(29, 20);
            this.txtindice.TabIndex = 28;
            this.txtindice.Text = "-1";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(241, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 20);
            this.txtId.TabIndex = 27;
            this.txtId.Text = "0";
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
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(15, 168);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(255, 20);
            this.txtConfirmarClave.TabIndex = 23;
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
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(15, 247);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(255, 21);
            this.cboEstado.TabIndex = 22;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(15, 90);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(255, 20);
            this.txtCorreo.TabIndex = 13;
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
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(15, 129);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(255, 20);
            this.txtClave.TabIndex = 14;
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
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 74);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
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
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 113);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 16;
            this.lblClave.Text = "Clave";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.btnGuardarUsuario);
            this.panel4.Controls.Add(this.btnLimpiarUsuario);
            this.panel4.Controls.Add(this.btnEliminarUsuario);
            this.panel4.Location = new System.Drawing.Point(8, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 41);
            this.panel4.TabIndex = 25;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarUsuario.IconSize = 21;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(11, 5);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarUsuario.TabIndex = 8;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarUsuario.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarUsuario.IconSize = 21;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(101, 5);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarUsuario.TabIndex = 10;
            this.btnLimpiarUsuario.Text = "Limpiar";
            this.btnLimpiarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
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
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.dtgvUsuario);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 389);
            this.panel3.TabIndex = 2;
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
            // dtgvUsuario
            // 
            this.dtgvUsuario.AllowUserToAddRows = false;
            this.dtgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvUsuario.ColumnHeadersHeight = 30;
            this.dtgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Nombre,
            this.Correo,
            this.Clave,
            this.Rol,
            this.Estado,
            this.IdRol,
            this.EstadoValor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvUsuario.EnableHeadersVisualStyles = false;
            this.dtgvUsuario.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dtgvUsuario.Location = new System.Drawing.Point(31, 49);
            this.dtgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvUsuario.MultiSelect = false;
            this.dtgvUsuario.Name = "dtgvUsuario";
            this.dtgvUsuario.ReadOnly = true;
            this.dtgvUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvUsuario.RowHeadersWidth = 51;
            this.dtgvUsuario.RowTemplate.Height = 28;
            this.dtgvUsuario.Size = new System.Drawing.Size(733, 273);
            this.dtgvUsuario.TabIndex = 1;
            this.dtgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuario_CellContentClick);
            this.dtgvUsuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgvUsuario_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 22;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 52;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 96;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 89;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 82;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 59;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 86;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Width = 74;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Width = 125;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1099, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboEstado;
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
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
        private FontAwesome.Sharp.IconButton btnLimpiarUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvUsuario;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboBusquedaUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaUsuario;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}