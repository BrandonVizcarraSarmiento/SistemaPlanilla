namespace CapaPresentacion.Vistas_Cargo
{
    partial class FrmCargoEditar
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
            this.panelCARGOSE = new System.Windows.Forms.Panel();
            this.txtSueldoECargo = new System.Windows.Forms.TextBox();
            this.txtNombreECargo = new System.Windows.Forms.TextBox();
            this.lblSueldoECargo = new System.Windows.Forms.Label();
            this.lblNombreECargo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarECargo = new FontAwesome.Sharp.IconButton();
            this.btnCancelarECargo = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarECargo = new FontAwesome.Sharp.IconButton();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCARGOSE.SuspendLayout();
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
            this.panelTitulo.Size = new System.Drawing.Size(1037, 106);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCargos.Location = new System.Drawing.Point(391, 33);
            this.lblCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(290, 39);
            this.lblCargos.TabIndex = 0;
            this.lblCargos.Text = "EDITAR CARGO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panelCARGOSE);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 529);
            this.panel1.TabIndex = 15;
            // 
            // panelCARGOSE
            // 
            this.panelCARGOSE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCARGOSE.Controls.Add(this.txtSueldoECargo);
            this.panelCARGOSE.Controls.Add(this.txtNombreECargo);
            this.panelCARGOSE.Controls.Add(this.lblSueldoECargo);
            this.panelCARGOSE.Controls.Add(this.lblNombreECargo);
            this.panelCARGOSE.Location = new System.Drawing.Point(321, 56);
            this.panelCARGOSE.Margin = new System.Windows.Forms.Padding(4);
            this.panelCARGOSE.Name = "panelCARGOSE";
            this.panelCARGOSE.Size = new System.Drawing.Size(432, 198);
            this.panelCARGOSE.TabIndex = 14;
            // 
            // txtSueldoECargo
            // 
            this.txtSueldoECargo.Location = new System.Drawing.Point(130, 109);
            this.txtSueldoECargo.Name = "txtSueldoECargo";
            this.txtSueldoECargo.Size = new System.Drawing.Size(204, 22);
            this.txtSueldoECargo.TabIndex = 3;
            // 
            // txtNombreECargo
            // 
            this.txtNombreECargo.Location = new System.Drawing.Point(130, 39);
            this.txtNombreECargo.Name = "txtNombreECargo";
            this.txtNombreECargo.Size = new System.Drawing.Size(204, 22);
            this.txtNombreECargo.TabIndex = 2;
            // 
            // lblSueldoECargo
            // 
            this.lblSueldoECargo.AutoSize = true;
            this.lblSueldoECargo.Location = new System.Drawing.Point(42, 115);
            this.lblSueldoECargo.Name = "lblSueldoECargo";
            this.lblSueldoECargo.Size = new System.Drawing.Size(50, 16);
            this.lblSueldoECargo.TabIndex = 1;
            this.lblSueldoECargo.Text = "Sueldo";
            // 
            // lblNombreECargo
            // 
            this.lblNombreECargo.AutoSize = true;
            this.lblNombreECargo.Location = new System.Drawing.Point(42, 39);
            this.lblNombreECargo.Name = "lblNombreECargo";
            this.lblNombreECargo.Size = new System.Drawing.Size(56, 16);
            this.lblNombreECargo.TabIndex = 0;
            this.lblNombreECargo.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnGuardarECargo);
            this.panel3.Controls.Add(this.btnCancelarECargo);
            this.panel3.Controls.Add(this.btnLimpiarECargo);
            this.panel3.Location = new System.Drawing.Point(301, 423);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 79);
            this.panel3.TabIndex = 13;
            // 
            // btnGuardarECargo
            // 
            this.btnGuardarECargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarECargo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarECargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarECargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarECargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarECargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarECargo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarECargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarECargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarECargo.IconSize = 21;
            this.btnGuardarECargo.Location = new System.Drawing.Point(59, 17);
            this.btnGuardarECargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarECargo.Name = "btnGuardarECargo";
            this.btnGuardarECargo.Size = new System.Drawing.Size(108, 41);
            this.btnGuardarECargo.TabIndex = 8;
            this.btnGuardarECargo.Text = "Guardar";
            this.btnGuardarECargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarECargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarECargo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarECargo
            // 
            this.btnCancelarECargo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelarECargo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelarECargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarECargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarECargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarECargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarECargo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnCancelarECargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarECargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarECargo.IconSize = 21;
            this.btnCancelarECargo.Location = new System.Drawing.Point(201, 17);
            this.btnCancelarECargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarECargo.Name = "btnCancelarECargo";
            this.btnCancelarECargo.Size = new System.Drawing.Size(108, 41);
            this.btnCancelarECargo.TabIndex = 10;
            this.btnCancelarECargo.Text = "Cancelar";
            this.btnCancelarECargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarECargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarECargo.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarECargo
            // 
            this.btnLimpiarECargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarECargo.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarECargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarECargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarECargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarECargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarECargo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarECargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarECargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarECargo.IconSize = 21;
            this.btnLimpiarECargo.Location = new System.Drawing.Point(344, 17);
            this.btnLimpiarECargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarECargo.Name = "btnLimpiarECargo";
            this.btnLimpiarECargo.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiarECargo.TabIndex = 9;
            this.btnLimpiarECargo.Text = "Limpiar";
            this.btnLimpiarECargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarECargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarECargo.UseVisualStyleBackColor = false;
            // 
            // FrmCargoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmCargoEditar";
            this.Text = "FrmCargoEditar";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelCARGOSE.ResumeLayout(false);
            this.panelCARGOSE.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCARGOSE;
        private System.Windows.Forms.TextBox txtSueldoECargo;
        private System.Windows.Forms.TextBox txtNombreECargo;
        private System.Windows.Forms.Label lblSueldoECargo;
        private System.Windows.Forms.Label lblNombreECargo;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnGuardarECargo;
        private FontAwesome.Sharp.IconButton btnCancelarECargo;
        private FontAwesome.Sharp.IconButton btnLimpiarECargo;
    }
}