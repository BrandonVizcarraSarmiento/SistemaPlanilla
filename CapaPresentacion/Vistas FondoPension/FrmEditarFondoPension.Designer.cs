namespace CapaPresentacion.Vistas_FondoPension
{
    partial class FrmEditarFondoPension
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
            this.txtDescuentoFPension = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombreFPension = new System.Windows.Forms.TextBox();
            this.btnCancelarFPension = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarFPension = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEditFPension = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Editar Fondo de Pension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre";
            // 
            // txtDescuentoFPension
            // 
            this.txtDescuentoFPension.Location = new System.Drawing.Point(56, 117);
            this.txtDescuentoFPension.Name = "txtDescuentoFPension";
            this.txtDescuentoFPension.Size = new System.Drawing.Size(255, 20);
            this.txtDescuentoFPension.TabIndex = 38;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(53, 101);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(37, 13);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "%Dsto";
            // 
            // txtNombreFPension
            // 
            this.txtNombreFPension.Location = new System.Drawing.Point(56, 78);
            this.txtNombreFPension.Name = "txtNombreFPension";
            this.txtNombreFPension.Size = new System.Drawing.Size(255, 20);
            this.txtNombreFPension.TabIndex = 40;
            // 
            // btnCancelarFPension
            // 
            this.btnCancelarFPension.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFPension.FlatAppearance.BorderSize = 0;
            this.btnCancelarFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFPension.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFPension.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarFPension.IconColor = System.Drawing.Color.White;
            this.btnCancelarFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarFPension.IconSize = 21;
            this.btnCancelarFPension.Location = new System.Drawing.Point(230, 174);
            this.btnCancelarFPension.Name = "btnCancelarFPension";
            this.btnCancelarFPension.Size = new System.Drawing.Size(81, 34);
            this.btnCancelarFPension.TabIndex = 37;
            this.btnCancelarFPension.Text = "Cancelar";
            this.btnCancelarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarFPension.UseVisualStyleBackColor = false;
            this.btnCancelarFPension.Click += new System.EventHandler(this.btnCancelarFPension_Click);
            // 
            // btnLimpiarFPension
            // 
            this.btnLimpiarFPension.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiarFPension.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFPension.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarFPension.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarFPension.IconSize = 21;
            this.btnLimpiarFPension.Location = new System.Drawing.Point(143, 174);
            this.btnLimpiarFPension.Name = "btnLimpiarFPension";
            this.btnLimpiarFPension.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarFPension.TabIndex = 36;
            this.btnLimpiarFPension.Text = "Limpiar";
            this.btnLimpiarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarFPension.UseVisualStyleBackColor = false;
            this.btnLimpiarFPension.Click += new System.EventHandler(this.btnLimpiarFPension_Click);
            // 
            // btnGuardarEditFPension
            // 
            this.btnGuardarEditFPension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarEditFPension.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarEditFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEditFPension.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarEditFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditFPension.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarEditFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEditFPension.IconSize = 21;
            this.btnGuardarEditFPension.Location = new System.Drawing.Point(56, 174);
            this.btnGuardarEditFPension.Name = "btnGuardarEditFPension";
            this.btnGuardarEditFPension.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarEditFPension.TabIndex = 35;
            this.btnGuardarEditFPension.Text = "Guardar";
            this.btnGuardarEditFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEditFPension.UseVisualStyleBackColor = false;
            this.btnGuardarEditFPension.Click += new System.EventHandler(this.btnGuardarEditFPension_Click);
            // 
            // FrmEditarFondoPension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescuentoFPension);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNombreFPension);
            this.Controls.Add(this.btnCancelarFPension);
            this.Controls.Add(this.btnLimpiarFPension);
            this.Controls.Add(this.btnGuardarEditFPension);
            this.Name = "FrmEditarFondoPension";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarFondoPension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescuentoFPension;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombreFPension;
        private FontAwesome.Sharp.IconButton btnCancelarFPension;
        private FontAwesome.Sharp.IconButton btnLimpiarFPension;
        private FontAwesome.Sharp.IconButton btnGuardarEditFPension;
    }
}