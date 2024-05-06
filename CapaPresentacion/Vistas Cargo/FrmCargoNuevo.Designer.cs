namespace CapaPresentacion.Vistas_Cargo
{
    partial class FrmCargoNuevo
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblCargos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCARGOSN = new System.Windows.Forms.Panel();
            this.txtSueldoNCargo = new System.Windows.Forms.TextBox();
            this.txtNombreNCargo = new System.Windows.Forms.TextBox();
            this.lblSueldoNCargo = new System.Windows.Forms.Label();
            this.lblNombreNCargo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarNCargo = new FontAwesome.Sharp.IconButton();
            this.btnCancelarNCargo = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarNCargo = new FontAwesome.Sharp.IconButton();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCARGOSN.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.panelTitulo.Controls.Add(this.lblCargos);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1031, 106);
            this.panelTitulo.TabIndex = 2;
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCargos.Location = new System.Drawing.Point(258, 36);
            this.lblCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(294, 39);
            this.lblCargos.TabIndex = 0;
            this.lblCargos.Text = "NUEVO CARGO ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panelCARGOSN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 469);
            this.panel1.TabIndex = 14;
            // 
            // panelCARGOSN
            // 
            this.panelCARGOSN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCARGOSN.Controls.Add(this.txtSueldoNCargo);
            this.panelCARGOSN.Controls.Add(this.txtNombreNCargo);
            this.panelCARGOSN.Controls.Add(this.lblSueldoNCargo);
            this.panelCARGOSN.Controls.Add(this.lblNombreNCargo);
            this.panelCARGOSN.Location = new System.Drawing.Point(298, 44);
            this.panelCARGOSN.Margin = new System.Windows.Forms.Padding(4);
            this.panelCARGOSN.Name = "panelCARGOSN";
            this.panelCARGOSN.Size = new System.Drawing.Size(432, 198);
            this.panelCARGOSN.TabIndex = 14;
            // 
            // txtSueldoNCargo
            // 
            this.txtSueldoNCargo.Location = new System.Drawing.Point(130, 109);
            this.txtSueldoNCargo.Name = "txtSueldoNCargo";
            this.txtSueldoNCargo.Size = new System.Drawing.Size(204, 22);
            this.txtSueldoNCargo.TabIndex = 3;
            // 
            // txtNombreNCargo
            // 
            this.txtNombreNCargo.Location = new System.Drawing.Point(130, 39);
            this.txtNombreNCargo.Name = "txtNombreNCargo";
            this.txtNombreNCargo.Size = new System.Drawing.Size(204, 22);
            this.txtNombreNCargo.TabIndex = 2;
            // 
            // lblSueldoNCargo
            // 
            this.lblSueldoNCargo.AutoSize = true;
            this.lblSueldoNCargo.Location = new System.Drawing.Point(42, 115);
            this.lblSueldoNCargo.Name = "lblSueldoNCargo";
            this.lblSueldoNCargo.Size = new System.Drawing.Size(50, 16);
            this.lblSueldoNCargo.TabIndex = 1;
            this.lblSueldoNCargo.Text = "Sueldo";
            // 
            // lblNombreNCargo
            // 
            this.lblNombreNCargo.AutoSize = true;
            this.lblNombreNCargo.Location = new System.Drawing.Point(42, 39);
            this.lblNombreNCargo.Name = "lblNombreNCargo";
            this.lblNombreNCargo.Size = new System.Drawing.Size(56, 16);
            this.lblNombreNCargo.TabIndex = 0;
            this.lblNombreNCargo.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnGuardarNCargo);
            this.panel3.Controls.Add(this.btnCancelarNCargo);
            this.panel3.Controls.Add(this.btnLimpiarNCargo);
            this.panel3.Location = new System.Drawing.Point(298, 363);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 79);
            this.panel3.TabIndex = 13;
            // 
            // btnGuardarNCargo
            // 
            this.btnGuardarNCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarNCargo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarNCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarNCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarNCargo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarNCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarNCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarNCargo.IconSize = 21;
            this.btnGuardarNCargo.Location = new System.Drawing.Point(59, 17);
            this.btnGuardarNCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarNCargo.Name = "btnGuardarNCargo";
            this.btnGuardarNCargo.Size = new System.Drawing.Size(108, 41);
            this.btnGuardarNCargo.TabIndex = 8;
            this.btnGuardarNCargo.Text = "Guardar";
            this.btnGuardarNCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarNCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarNCargo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarNCargo
            // 
            this.btnCancelarNCargo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelarNCargo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarNCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarNCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarNCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarNCargo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnCancelarNCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarNCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarNCargo.IconSize = 21;
            this.btnCancelarNCargo.Location = new System.Drawing.Point(201, 17);
            this.btnCancelarNCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarNCargo.Name = "btnCancelarNCargo";
            this.btnCancelarNCargo.Size = new System.Drawing.Size(108, 41);
            this.btnCancelarNCargo.TabIndex = 10;
            this.btnCancelarNCargo.Text = "Cancelar";
            this.btnCancelarNCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarNCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarNCargo.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarNCargo
            // 
            this.btnLimpiarNCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarNCargo.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarNCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarNCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarNCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarNCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarNCargo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarNCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarNCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarNCargo.IconSize = 21;
            this.btnLimpiarNCargo.Location = new System.Drawing.Point(344, 17);
            this.btnLimpiarNCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarNCargo.Name = "btnLimpiarNCargo";
            this.btnLimpiarNCargo.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiarNCargo.TabIndex = 9;
            this.btnLimpiarNCargo.Text = "Limpiar";
            this.btnLimpiarNCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarNCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarNCargo.UseVisualStyleBackColor = false;
            // 
            // FrmCargoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmCargoNuevo";
            this.Text = "NUEVOEDITAR";
            this.Load += new System.EventHandler(this.FrmCargoNUEVOEDITAR_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelCARGOSN.ResumeLayout(false);
            this.panelCARGOSN.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCARGOSN;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnGuardarNCargo;
        private FontAwesome.Sharp.IconButton btnCancelarNCargo;
        private FontAwesome.Sharp.IconButton btnLimpiarNCargo;
        private System.Windows.Forms.Label lblSueldoNCargo;
        private System.Windows.Forms.Label lblNombreNCargo;
        private System.Windows.Forms.TextBox txtSueldoNCargo;
        private System.Windows.Forms.TextBox txtNombreNCargo;
    }
}