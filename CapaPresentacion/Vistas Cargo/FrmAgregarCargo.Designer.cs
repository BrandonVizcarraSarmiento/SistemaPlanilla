﻿namespace CapaPresentacion.Vistas_Cargo
{
    partial class FrmAgregarCargo
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
            this.txtSueldoMensual = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.btnCancelarCargo = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCargo = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCargo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(130, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Agregar Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre";
            // 
            // txtSueldoMensual
            // 
            this.txtSueldoMensual.Location = new System.Drawing.Point(76, 145);
            this.txtSueldoMensual.Name = "txtSueldoMensual";
            this.txtSueldoMensual.Size = new System.Drawing.Size(255, 20);
            this.txtSueldoMensual.TabIndex = 38;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSueldo.Location = new System.Drawing.Point(73, 129);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(80, 13);
            this.lblSueldo.TabIndex = 39;
            this.lblSueldo.Text = "SueldoMensual";
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(76, 106);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(255, 20);
            this.txtNombreCargo.TabIndex = 40;
            // 
            // btnCancelarCargo
            // 
            this.btnCancelarCargo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCargo.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCargo.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarCargo.IconColor = System.Drawing.Color.White;
            this.btnCancelarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCargo.IconSize = 21;
            this.btnCancelarCargo.Location = new System.Drawing.Point(250, 202);
            this.btnCancelarCargo.Name = "btnCancelarCargo";
            this.btnCancelarCargo.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarCargo.TabIndex = 37;
            this.btnCancelarCargo.Text = "Cancelar";
            this.btnCancelarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCargo.UseVisualStyleBackColor = false;
            this.btnCancelarCargo.Click += new System.EventHandler(this.btnCancelarCargo_Click_1);
            // 
            // btnLimpiarCargo
            // 
            this.btnLimpiarCargo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiarCargo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCargo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarCargo.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCargo.IconSize = 21;
            this.btnLimpiarCargo.Location = new System.Drawing.Point(163, 202);
            this.btnLimpiarCargo.Name = "btnLimpiarCargo";
            this.btnLimpiarCargo.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarCargo.TabIndex = 36;
            this.btnLimpiarCargo.Text = "Limpiar";
            this.btnLimpiarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarCargo.UseVisualStyleBackColor = false;
            this.btnLimpiarCargo.Click += new System.EventHandler(this.btnLimpiarCargo_Click_1);
            // 
            // btnGuardarCargo
            // 
            this.btnGuardarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarCargo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCargo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCargo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCargo.IconSize = 21;
            this.btnGuardarCargo.Location = new System.Drawing.Point(76, 202);
            this.btnGuardarCargo.Name = "btnGuardarCargo";
            this.btnGuardarCargo.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarCargo.TabIndex = 35;
            this.btnGuardarCargo.Text = "Guardar";
            this.btnGuardarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCargo.UseVisualStyleBackColor = false;
            this.btnGuardarCargo.Click += new System.EventHandler(this.btnGuardarCargo_Click_1);
            // 
            // FrmAgregarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(404, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSueldoMensual);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtNombreCargo);
            this.Controls.Add(this.btnCancelarCargo);
            this.Controls.Add(this.btnLimpiarCargo);
            this.Controls.Add(this.btnGuardarCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarCargo";
            this.Load += new System.EventHandler(this.FrmAgregarCargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSueldoMensual;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private FontAwesome.Sharp.IconButton btnCancelarCargo;
        private FontAwesome.Sharp.IconButton btnLimpiarCargo;
        private FontAwesome.Sharp.IconButton btnGuardarCargo;
    }
}