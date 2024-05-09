namespace CapaPresentacion.Vistas_Usuarios
{
    partial class FrmEditarUsuario
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
            this.btnEditarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarUsuario = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Confirmar clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Editar usuario";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(33, 188);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(255, 20);
            this.txtConfirmarClave.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(33, 267);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(255, 21);
            this.cboEstado.TabIndex = 36;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(33, 110);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(255, 20);
            this.txtCorreo.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 251);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(33, 149);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(255, 20);
            this.txtClave.TabIndex = 28;
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(33, 227);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(255, 21);
            this.cboRol.TabIndex = 34;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(30, 94);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 29;
            this.lblCorreo.Text = "Correo";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(30, 211);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 33;
            this.lblRol.Text = "Rol";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(30, 133);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 30;
            this.lblClave.Text = "Clave";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarUsuario.IconSize = 21;
            this.btnEditarUsuario.Location = new System.Drawing.Point(32, 309);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnEditarUsuario.TabIndex = 40;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 21;
            this.btnCancelar.Location = new System.Drawing.Point(206, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 33);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarUsuario.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarUsuario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarUsuario.IconSize = 21;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(119, 309);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarUsuario.TabIndex = 41;
            this.btnLimpiarUsuario.Text = "Limpiar";
            this.btnLimpiarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarUsuario.UseVisualStyleBackColor = false;
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 364);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmEditarUsuario";
            this.Text = "FrmEditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnEditarUsuario;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiarUsuario;
    }
}