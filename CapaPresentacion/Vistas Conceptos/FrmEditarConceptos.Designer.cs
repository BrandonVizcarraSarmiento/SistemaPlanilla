namespace CapaPresentacion.Vistas_Conceptos
{
    partial class FrmEditarConceptos
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
            this.txtCodigoConceptos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombreConceptos = new System.Windows.Forms.TextBox();
            this.btnCancelarConceptos = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarConceptos = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEditConceptos = new FontAwesome.Sharp.IconButton();
            this.cmbTipoConceptos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCodigoConceptos
            // 
            this.txtCodigoConceptos.Location = new System.Drawing.Point(144, 157);
            this.txtCodigoConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoConceptos.Name = "txtCodigoConceptos";
            this.txtCodigoConceptos.Size = new System.Drawing.Size(339, 22);
            this.txtCodigoConceptos.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "Editar Conceptos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nombre";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(141, 270);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(35, 16);
            this.lblSueldo.TabIndex = 57;
            this.lblSueldo.Text = "Tipo";
            // 
            // txtNombreConceptos
            // 
            this.txtNombreConceptos.Location = new System.Drawing.Point(144, 220);
            this.txtNombreConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreConceptos.Name = "txtNombreConceptos";
            this.txtNombreConceptos.Size = new System.Drawing.Size(339, 22);
            this.txtNombreConceptos.TabIndex = 58;
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
            this.btnCancelarConceptos.Location = new System.Drawing.Point(376, 341);
            this.btnCancelarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarConceptos.Name = "btnCancelarConceptos";
            this.btnCancelarConceptos.Size = new System.Drawing.Size(108, 42);
            this.btnCancelarConceptos.TabIndex = 55;
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
            this.btnLimpiarConceptos.Location = new System.Drawing.Point(260, 341);
            this.btnLimpiarConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarConceptos.Name = "btnLimpiarConceptos";
            this.btnLimpiarConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiarConceptos.TabIndex = 54;
            this.btnLimpiarConceptos.Text = "Limpiar";
            this.btnLimpiarConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarConceptos.UseVisualStyleBackColor = false;
            this.btnLimpiarConceptos.Click += new System.EventHandler(this.btnLimpiarConceptos_Click);
            // 
            // btnGuardarEditConceptos
            // 
            this.btnGuardarEditConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarEditConceptos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarEditConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEditConceptos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarEditConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditConceptos.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarEditConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEditConceptos.IconSize = 21;
            this.btnGuardarEditConceptos.Location = new System.Drawing.Point(144, 341);
            this.btnGuardarEditConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarEditConceptos.Name = "btnGuardarEditConceptos";
            this.btnGuardarEditConceptos.Size = new System.Drawing.Size(108, 41);
            this.btnGuardarEditConceptos.TabIndex = 53;
            this.btnGuardarEditConceptos.Text = "Guardar";
            this.btnGuardarEditConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEditConceptos.UseVisualStyleBackColor = false;
            this.btnGuardarEditConceptos.Click += new System.EventHandler(this.btnGuardarEditConceptos_Click);
            // 
            // cmbTipoConceptos
            // 
            this.cmbTipoConceptos.FormattingEnabled = true;
            this.cmbTipoConceptos.Location = new System.Drawing.Point(144, 310);
            this.cmbTipoConceptos.Name = "cmbTipoConceptos";
            this.cmbTipoConceptos.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoConceptos.TabIndex = 63;
            // 
            // FrmEditarConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 435);
            this.Controls.Add(this.cmbTipoConceptos);
            this.Controls.Add(this.txtCodigoConceptos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtNombreConceptos);
            this.Controls.Add(this.btnCancelarConceptos);
            this.Controls.Add(this.btnLimpiarConceptos);
            this.Controls.Add(this.btnGuardarEditConceptos);
            this.Name = "FrmEditarConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarConceptos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoConceptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombreConceptos;
        private FontAwesome.Sharp.IconButton btnCancelarConceptos;
        private FontAwesome.Sharp.IconButton btnLimpiarConceptos;
        private FontAwesome.Sharp.IconButton btnGuardarEditConceptos;
        private System.Windows.Forms.ComboBox cmbTipoConceptos;
    }
}