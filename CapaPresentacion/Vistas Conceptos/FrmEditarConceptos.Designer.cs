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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarConceptos));
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
            resources.ApplyResources(this.txtCodigoConceptos, "txtCodigoConceptos");
            this.txtCodigoConceptos.Name = "txtCodigoConceptos";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblSueldo
            // 
            resources.ApplyResources(this.lblSueldo, "lblSueldo");
            this.lblSueldo.Name = "lblSueldo";
            // 
            // txtNombreConceptos
            // 
            resources.ApplyResources(this.txtNombreConceptos, "txtNombreConceptos");
            this.txtNombreConceptos.Name = "txtNombreConceptos";
            // 
            // btnCancelarConceptos
            // 
            this.btnCancelarConceptos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarConceptos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnCancelarConceptos, "btnCancelarConceptos");
            this.btnCancelarConceptos.ForeColor = System.Drawing.Color.White;
            this.btnCancelarConceptos.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarConceptos.IconColor = System.Drawing.Color.White;
            this.btnCancelarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarConceptos.IconSize = 21;
            this.btnCancelarConceptos.Name = "btnCancelarConceptos";
            this.btnCancelarConceptos.UseVisualStyleBackColor = false;
            this.btnCancelarConceptos.Click += new System.EventHandler(this.btnCancelarConceptos_Click);
            // 
            // btnLimpiarConceptos
            // 
            this.btnLimpiarConceptos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarConceptos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLimpiarConceptos, "btnLimpiarConceptos");
            this.btnLimpiarConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarConceptos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarConceptos.IconSize = 21;
            this.btnLimpiarConceptos.Name = "btnLimpiarConceptos";
            this.btnLimpiarConceptos.UseVisualStyleBackColor = false;
            this.btnLimpiarConceptos.Click += new System.EventHandler(this.btnLimpiarConceptos_Click);
            // 
            // btnGuardarEditConceptos
            // 
            resources.ApplyResources(this.btnGuardarEditConceptos, "btnGuardarEditConceptos");
            this.btnGuardarEditConceptos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarEditConceptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEditConceptos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarEditConceptos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditConceptos.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarEditConceptos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEditConceptos.IconSize = 21;
            this.btnGuardarEditConceptos.Name = "btnGuardarEditConceptos";
            this.btnGuardarEditConceptos.UseVisualStyleBackColor = false;
            this.btnGuardarEditConceptos.Click += new System.EventHandler(this.btnGuardarEditConceptos_Click);
            // 
            // cmbTipoConceptos
            // 
            this.cmbTipoConceptos.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTipoConceptos, "cmbTipoConceptos");
            this.cmbTipoConceptos.Name = "cmbTipoConceptos";
            // 
            // FrmEditarConceptos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmEditarConceptos";
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