﻿namespace CapaPresentacion.Vistas_FondoPension
{
    partial class FrmAgregarFondoPension
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
            this.btnGuardarFPension = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Agregar Fondo de Pension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre";
            // 
            // txtDescuentoFPension
            // 
            this.txtDescuentoFPension.Location = new System.Drawing.Point(71, 143);
            this.txtDescuentoFPension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescuentoFPension.Name = "txtDescuentoFPension";
            this.txtDescuentoFPension.Size = new System.Drawing.Size(339, 22);
            this.txtDescuentoFPension.TabIndex = 29;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(67, 123);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 16);
            this.lblCorreo.TabIndex = 30;
            this.lblCorreo.Text = "%Dsto";
            // 
            // txtNombreFPension
            // 
            this.txtNombreFPension.Location = new System.Drawing.Point(71, 95);
            this.txtNombreFPension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreFPension.Name = "txtNombreFPension";
            this.txtNombreFPension.Size = new System.Drawing.Size(339, 22);
            this.txtNombreFPension.TabIndex = 32;
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
            this.btnCancelarFPension.Location = new System.Drawing.Point(303, 213);
            this.btnCancelarFPension.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFPension.Name = "btnCancelarFPension";
            this.btnCancelarFPension.Size = new System.Drawing.Size(108, 42);
            this.btnCancelarFPension.TabIndex = 12;
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
            this.btnLimpiarFPension.Location = new System.Drawing.Point(187, 213);
            this.btnLimpiarFPension.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFPension.Name = "btnLimpiarFPension";
            this.btnLimpiarFPension.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiarFPension.TabIndex = 11;
            this.btnLimpiarFPension.Text = "Limpiar";
            this.btnLimpiarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarFPension.UseVisualStyleBackColor = false;
            this.btnLimpiarFPension.Click += new System.EventHandler(this.btnLimpiarFPension_Click);
            // 
            // btnGuardarFPension
            // 
            this.btnGuardarFPension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarFPension.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarFPension.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarFPension.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarFPension.IconSize = 21;
            this.btnGuardarFPension.Location = new System.Drawing.Point(71, 213);
            this.btnGuardarFPension.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarFPension.Name = "btnGuardarFPension";
            this.btnGuardarFPension.Size = new System.Drawing.Size(108, 41);
            this.btnGuardarFPension.TabIndex = 9;
            this.btnGuardarFPension.Text = "Guardar";
            this.btnGuardarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarFPension.UseVisualStyleBackColor = false;
            this.btnGuardarFPension.Click += new System.EventHandler(this.btnGuardarFPension_Click);
            // 
            // FrmAgregarFondoPension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescuentoFPension);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNombreFPension);
            this.Controls.Add(this.btnCancelarFPension);
            this.Controls.Add(this.btnLimpiarFPension);
            this.Controls.Add(this.btnGuardarFPension);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAgregarFondoPension";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarFondoPension";
            this.Load += new System.EventHandler(this.FrmAgregarFondoPension_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardarFPension;
        private FontAwesome.Sharp.IconButton btnLimpiarFPension;
        private FontAwesome.Sharp.IconButton btnCancelarFPension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescuentoFPension;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombreFPension;
    }
}