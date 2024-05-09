namespace CapaPresentacion
{
    partial class Registrase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrase));
            this.label2 = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtClaveRegistrar = new System.Windows.Forms.TextBox();
            this.txtCorreoRegistrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrarte = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarClaveRegistrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(158, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrate";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Image = ((System.Drawing.Image)(resources.GetObject("lblClave.Image")));
            this.lblClave.Location = new System.Drawing.Point(112, 236);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Image = ((System.Drawing.Image)(resources.GetObject("lblCorreo.Image")));
            this.lblCorreo.Location = new System.Drawing.Point(112, 186);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo";
            // 
            // txtClaveRegistrar
            // 
            this.txtClaveRegistrar.Location = new System.Drawing.Point(111, 251);
            this.txtClaveRegistrar.Name = "txtClaveRegistrar";
            this.txtClaveRegistrar.PasswordChar = '*';
            this.txtClaveRegistrar.Size = new System.Drawing.Size(234, 20);
            this.txtClaveRegistrar.TabIndex = 8;
            // 
            // txtCorreoRegistrar
            // 
            this.txtCorreoRegistrar.Location = new System.Drawing.Point(111, 201);
            this.txtCorreoRegistrar.Name = "txtCorreoRegistrar";
            this.txtCorreoRegistrar.Size = new System.Drawing.Size(234, 20);
            this.txtCorreoRegistrar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(111, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // txtNombreRegistrar
            // 
            this.txtNombreRegistrar.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreRegistrar.Location = new System.Drawing.Point(111, 150);
            this.txtNombreRegistrar.Name = "txtNombreRegistrar";
            this.txtNombreRegistrar.Size = new System.Drawing.Size(234, 20);
            this.txtNombreRegistrar.TabIndex = 11;
            // 
            // btnRegistrarte
            // 
            this.btnRegistrarte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarte.BackgroundImage")));
            this.btnRegistrarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarte.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnRegistrarte.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarte.IconSize = 21;
            this.btnRegistrarte.Location = new System.Drawing.Point(170, 358);
            this.btnRegistrarte.Name = "btnRegistrarte";
            this.btnRegistrarte.Size = new System.Drawing.Size(103, 33);
            this.btnRegistrarte.TabIndex = 13;
            this.btnRegistrarte.Text = "Registrarte";
            this.btnRegistrarte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarte.UseVisualStyleBackColor = false;
            this.btnRegistrarte.Click += new System.EventHandler(this.btnRegistrarte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancelar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 21;
            this.btnCancelar.Location = new System.Drawing.Point(396, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(32, 25);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(111, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirmar clave";
            // 
            // txtConfirmarClaveRegistrar
            // 
            this.txtConfirmarClaveRegistrar.Location = new System.Drawing.Point(111, 307);
            this.txtConfirmarClaveRegistrar.Name = "txtConfirmarClaveRegistrar";
            this.txtConfirmarClaveRegistrar.PasswordChar = '*';
            this.txtConfirmarClaveRegistrar.Size = new System.Drawing.Size(234, 20);
            this.txtConfirmarClaveRegistrar.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 453);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Registrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmarClaveRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreRegistrar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtClaveRegistrar);
            this.Controls.Add(this.txtCorreoRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtClaveRegistrar;
        private System.Windows.Forms.TextBox txtCorreoRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRegistrar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarClaveRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnRegistrarte;
    }
}