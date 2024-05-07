namespace CapaPresentacion.Vistas_Banco
{
    partial class FrmAgregarBanco
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
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.btnGuardarBanco = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBanco = new FontAwesome.Sharp.IconButton();
            this.btnCancelarBanco = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Agregar Banco Nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre";
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Location = new System.Drawing.Point(82, 88);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(255, 20);
            this.txtNombreBanco.TabIndex = 37;
            // 
            // btnGuardarBanco
            // 
            this.btnGuardarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarBanco.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarBanco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarBanco.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarBanco.IconSize = 21;
            this.btnGuardarBanco.Location = new System.Drawing.Point(41, 148);
            this.btnGuardarBanco.Name = "btnGuardarBanco";
            this.btnGuardarBanco.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarBanco.TabIndex = 38;
            this.btnGuardarBanco.Text = "Guardar";
            this.btnGuardarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarBanco.UseVisualStyleBackColor = false;
            this.btnGuardarBanco.Click += new System.EventHandler(this.btnGuardarBanco_Click);
            // 
            // btnLimpiarBanco
            // 
            this.btnLimpiarBanco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiarBanco.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBanco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarBanco.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBanco.IconSize = 21;
            this.btnLimpiarBanco.Location = new System.Drawing.Point(146, 148);
            this.btnLimpiarBanco.Name = "btnLimpiarBanco";
            this.btnLimpiarBanco.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarBanco.TabIndex = 39;
            this.btnLimpiarBanco.Text = "Limpiar";
            this.btnLimpiarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBanco.UseVisualStyleBackColor = false;
            this.btnLimpiarBanco.Click += new System.EventHandler(this.btnLimpiarBanco_Click);
            // 
            // btnCancelarBanco
            // 
            this.btnCancelarBanco.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarBanco.FlatAppearance.BorderSize = 0;
            this.btnCancelarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBanco.ForeColor = System.Drawing.Color.White;
            this.btnCancelarBanco.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarBanco.IconColor = System.Drawing.Color.White;
            this.btnCancelarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarBanco.IconSize = 21;
            this.btnCancelarBanco.Location = new System.Drawing.Point(256, 148);
            this.btnCancelarBanco.Name = "btnCancelarBanco";
            this.btnCancelarBanco.Size = new System.Drawing.Size(81, 34);
            this.btnCancelarBanco.TabIndex = 40;
            this.btnCancelarBanco.Text = "Cancelar";
            this.btnCancelarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarBanco.UseVisualStyleBackColor = false;
            this.btnCancelarBanco.Click += new System.EventHandler(this.btnCancelarBanco_Click);
            // 
            // FrmAgregarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 229);
            this.Controls.Add(this.btnCancelarBanco);
            this.Controls.Add(this.btnLimpiarBanco);
            this.Controls.Add(this.btnGuardarBanco);
            this.Controls.Add(this.txtNombreBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private FontAwesome.Sharp.IconButton btnGuardarBanco;
        private FontAwesome.Sharp.IconButton btnLimpiarBanco;
        private FontAwesome.Sharp.IconButton btnCancelarBanco;
    }
}