﻿namespace CapaPresentacion.Vistas_Conceptos
{
    partial class FrmAgregarConceptos
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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombreConceptos = new System.Windows.Forms.TextBox();
            this.btnCancelarConceptos = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarConceptos = new FontAwesome.Sharp.IconButton();
            this.btnGuardarConceptos = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoConceptos = new System.Windows.Forms.TextBox();
            this.cmbTipoConceptos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Agregar Conceptos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nombre";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(143, 251);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(35, 16);
            this.lblSueldo.TabIndex = 47;
            this.lblSueldo.Text = "Tipo";
            // 
            // txtNombreConceptos
            // 
            this.txtNombreConceptos.Location = new System.Drawing.Point(146, 201);
            this.txtNombreConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreConceptos.Name = "txtNombreConceptos";
            this.txtNombreConceptos.Size = new System.Drawing.Size(339, 22);
            this.txtNombreConceptos.TabIndex = 48;
            // 
            // btnCancelarConceptos
            // 
            this.btnCancelarConceptos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarConceptos.FlatAppearance.BorderSize = 0;
            this.btnCancelarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarConceptos.ForeColor = System.Drawing.Color.White;
            this.btnCancelarConceptos.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarConceptos.IconColor = System.Drawing.Color.White;
            this.btnCancelarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarConceptos.IconSize = 21;
            this.btnCancelarConceptos.Location = new System.Drawing.Point(378, 322);
            this.btnCancelarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarConceptos.Name = "btnCancelarConceptos";
            this.btnCancelarConceptos.Size = new System.Drawing.Size(108, 42);
            this.btnCancelarConceptos.TabIndex = 45;
            this.btnCancelarConceptos.Text = "Cancelar";
            this.btnCancelarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarConceptos.UseVisualStyleBackColor = false;
            this.btnCancelarConceptos.Click += new System.EventHandler(this.btnCancelarConceptos_Click);
            // 
            // btnLimpiarConceptos
            // 
            this.btnLimpiarConceptos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiarConceptos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarConceptos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarConceptos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarConceptos.IconSize = 21;
            this.btnLimpiarConceptos.Location = new System.Drawing.Point(262, 322);
            this.btnLimpiarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarConceptos.Name = "btnLimpiarConceptos";
            this.btnLimpiarConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiarConceptos.TabIndex = 44;
            this.btnLimpiarConceptos.Text = "Limpiar";
            this.btnLimpiarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarConceptos.UseVisualStyleBackColor = false;
            this.btnLimpiarConceptos.Click += new System.EventHandler(this.btnLimpiarConceptos_Click);
            // 
            // btnGuardarConceptos
            // 
            this.btnGuardarConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarConceptos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarConceptos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarConceptos.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarConceptos.IconSize = 21;
            this.btnGuardarConceptos.Location = new System.Drawing.Point(146, 322);
            this.btnGuardarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarConceptos.Name = "btnGuardarConceptos";
            this.btnGuardarConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnGuardarConceptos.TabIndex = 43;
            this.btnGuardarConceptos.Text = "Guardar";
            this.btnGuardarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarConceptos.UseVisualStyleBackColor = false;
            this.btnGuardarConceptos.Click += new System.EventHandler(this.btnGuardarConceptos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Codigo";
            // 
            // txtCodigoConceptos
            // 
            this.txtCodigoConceptos.Location = new System.Drawing.Point(146, 138);
            this.txtCodigoConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoConceptos.Name = "txtCodigoConceptos";
            this.txtCodigoConceptos.Size = new System.Drawing.Size(339, 22);
            this.txtCodigoConceptos.TabIndex = 52;
            // 
            // cmbTipoConceptos
            // 
            this.cmbTipoConceptos.FormattingEnabled = true;
            this.cmbTipoConceptos.Location = new System.Drawing.Point(146, 271);
            this.cmbTipoConceptos.Name = "cmbTipoConceptos";
            this.cmbTipoConceptos.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoConceptos.TabIndex = 53;
            // 
            // FrmAgregarConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 404);
            this.Controls.Add(this.cmbTipoConceptos);
            this.Controls.Add(this.txtCodigoConceptos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtNombreConceptos);
            this.Controls.Add(this.btnCancelarConceptos);
            this.Controls.Add(this.btnLimpiarConceptos);
            this.Controls.Add(this.btnGuardarConceptos);
            this.Name = "FrmAgregarConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarConceptos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombreConceptos;
        private FontAwesome.Sharp.IconButton btnCancelarConceptos;
        private FontAwesome.Sharp.IconButton btnLimpiarConceptos;
        private FontAwesome.Sharp.IconButton btnGuardarConceptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoConceptos;
        private System.Windows.Forms.ComboBox cmbTipoConceptos;
    }
}