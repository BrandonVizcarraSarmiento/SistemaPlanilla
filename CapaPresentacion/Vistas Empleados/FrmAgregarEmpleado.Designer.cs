namespace CapaPresentacion.Vistas_Empleados
{
    partial class FrmAgregarEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnCancelarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.dtpFechaIniciContrato = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinContraton = new System.Windows.Forms.DateTimePicker();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFondoPension = new System.Windows.Forms.ComboBox();
            this.lblFondoPension = new System.Windows.Forms.Label();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Agregar empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(73, 154);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(255, 20);
            this.txtApellidos.TabIndex = 38;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(70, 138);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 39;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(73, 115);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(255, 20);
            this.txtNombres.TabIndex = 40;
            // 
            // btnCancelarEmpleado
            // 
            this.btnCancelarEmpleado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnCancelarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarEmpleado.IconColor = System.Drawing.Color.White;
            this.btnCancelarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarEmpleado.IconSize = 21;
            this.btnCancelarEmpleado.Location = new System.Drawing.Point(246, 416);
            this.btnCancelarEmpleado.Name = "btnCancelarEmpleado";
            this.btnCancelarEmpleado.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarEmpleado.TabIndex = 37;
            this.btnCancelarEmpleado.Text = "Cancelar";
            this.btnCancelarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarEmpleado.UseVisualStyleBackColor = false;
            this.btnCancelarEmpleado.Click += new System.EventHandler(this.btnCancelarEmpleado_Click);
            // 
            // btnLimpiarEmpleado
            // 
            this.btnLimpiarEmpleado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarEmpleado.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarEmpleado.IconSize = 21;
            this.btnLimpiarEmpleado.Location = new System.Drawing.Point(159, 416);
            this.btnLimpiarEmpleado.Name = "btnLimpiarEmpleado";
            this.btnLimpiarEmpleado.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarEmpleado.TabIndex = 36;
            this.btnLimpiarEmpleado.Text = "Limpiar";
            this.btnLimpiarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarEmpleado.UseVisualStyleBackColor = false;
            this.btnLimpiarEmpleado.Click += new System.EventHandler(this.btnLimpiarEmpleado_Click);
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarEmpleado.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEmpleado.IconSize = 21;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(72, 416);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarEmpleado.TabIndex = 35;
            this.btnGuardarEmpleado.Text = "Insertar";
            this.btnGuardarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEmpleado.UseVisualStyleBackColor = false;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(73, 79);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(255, 20);
            this.txtDNI.TabIndex = 43;
            // 
            // dtpFechaIniciContrato
            // 
            this.dtpFechaIniciContrato.Location = new System.Drawing.Point(72, 215);
            this.dtpFechaIniciContrato.Name = "dtpFechaIniciContrato";
            this.dtpFechaIniciContrato.Size = new System.Drawing.Size(126, 20);
            this.dtpFechaIniciContrato.TabIndex = 45;
            // 
            // dtpFechaFinContraton
            // 
            this.dtpFechaFinContraton.Location = new System.Drawing.Point(204, 215);
            this.dtpFechaFinContraton.MinDate = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.dtpFechaFinContraton.Name = "dtpFechaFinContraton";
            this.dtpFechaFinContraton.Size = new System.Drawing.Size(126, 20);
            this.dtpFechaFinContraton.TabIndex = 46;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(73, 254);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(255, 20);
            this.txtCuenta.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cuenta";
            // 
            // cboFondoPension
            // 
            this.cboFondoPension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFondoPension.FormattingEnabled = true;
            this.cboFondoPension.Location = new System.Drawing.Point(72, 333);
            this.cboFondoPension.Name = "cboFondoPension";
            this.cboFondoPension.Size = new System.Drawing.Size(255, 21);
            this.cboFondoPension.TabIndex = 52;
            // 
            // lblFondoPension
            // 
            this.lblFondoPension.AutoSize = true;
            this.lblFondoPension.Location = new System.Drawing.Point(72, 317);
            this.lblFondoPension.Name = "lblFondoPension";
            this.lblFondoPension.Size = new System.Drawing.Size(92, 13);
            this.lblFondoPension.TabIndex = 51;
            this.lblFondoPension.Text = "Fondo de pension";
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(72, 293);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(256, 21);
            this.cboBanco.TabIndex = 50;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(72, 277);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 49;
            this.lblBanco.Text = "Banco";
            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(73, 373);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(254, 21);
            this.cboCargo.TabIndex = 54;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(72, 357);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 53;
            this.lblCargo.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Contrato";
            // 
            // FrmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 493);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cboFondoPension);
            this.Controls.Add(this.lblFondoPension);
            this.Controls.Add(this.cboBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaFinContraton);
            this.Controls.Add(this.dtpFechaIniciContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnCancelarEmpleado);
            this.Controls.Add(this.btnLimpiarEmpleado);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private FontAwesome.Sharp.IconButton btnCancelarEmpleado;
        private FontAwesome.Sharp.IconButton btnLimpiarEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DateTimePicker dtpFechaIniciContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaFinContraton;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFondoPension;
        private System.Windows.Forms.Label lblFondoPension;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}