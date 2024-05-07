namespace CapaPresentacion.Vistas_Cargo
{
    partial class FrmEditarCargo
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
            this.lblSueldoCargo = new System.Windows.Forms.Label();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.btnCancelarCargo = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCargo = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEditCargo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Editar Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nombre";
            // 
            // txtSueldoMensual
            // 
            this.txtSueldoMensual.Location = new System.Drawing.Point(232, 229);
            this.txtSueldoMensual.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldoMensual.Name = "txtSueldoMensual";
            this.txtSueldoMensual.Size = new System.Drawing.Size(339, 22);
            this.txtSueldoMensual.TabIndex = 46;
            //this.txtSueldoMensual.TextChanged += new System.EventHandler(this.txtSueldoMensual_TextChanged);
            // 
            // lblSueldoCargo
            // 
            this.lblSueldoCargo.AutoSize = true;
            this.lblSueldoCargo.Location = new System.Drawing.Point(228, 209);
            this.lblSueldoCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldoCargo.Name = "lblSueldoCargo";
            this.lblSueldoCargo.Size = new System.Drawing.Size(47, 16);
            this.lblSueldoCargo.TabIndex = 47;
            this.lblSueldoCargo.Text = "%Dsto";
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(232, 181);
            this.txtNombreCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(339, 22);
            this.txtNombreCargo.TabIndex = 48;
            //this.txtNombreCargo.TextChanged += new System.EventHandler(this.txtNombreCargo_TextChanged);
            // 
            // btnCancelarCargo
            // 
            this.btnCancelarCargo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCargo.FlatAppearance.BorderSize = 0;
            this.btnCancelarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCargo.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCargo.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarCargo.IconColor = System.Drawing.Color.White;
            this.btnCancelarCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCargo.IconSize = 21;
            this.btnCancelarCargo.Location = new System.Drawing.Point(464, 299);
            this.btnCancelarCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarCargo.Name = "btnCancelarCargo";
            this.btnCancelarCargo.Size = new System.Drawing.Size(108, 42);
            this.btnCancelarCargo.TabIndex = 45;
            this.btnCancelarCargo.Text = "Cancelar";
            this.btnCancelarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCargo.UseVisualStyleBackColor = false;
            this.btnCancelarCargo.Click += new System.EventHandler(this.btnCancelarCargo_Click);
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
            this.btnLimpiarCargo.Location = new System.Drawing.Point(348, 299);
            this.btnLimpiarCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCargo.Name = "btnLimpiarCargo";
            this.btnLimpiarCargo.Size = new System.Drawing.Size(108, 41);
            this.btnLimpiarCargo.TabIndex = 44;
            this.btnLimpiarCargo.Text = "Limpiar";
            this.btnLimpiarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarCargo.UseVisualStyleBackColor = false;
            this.btnLimpiarCargo.Click += new System.EventHandler(this.btnLimpiarCargo_Click);
            // 
            // btnGuardarEditCargo
            // 
            this.btnGuardarEditCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarEditCargo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarEditCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEditCargo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarEditCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditCargo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarEditCargo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEditCargo.IconSize = 21;
            this.btnGuardarEditCargo.Location = new System.Drawing.Point(232, 299);
            this.btnGuardarEditCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarEditCargo.Name = "btnGuardarEditCargo";
            this.btnGuardarEditCargo.Size = new System.Drawing.Size(108, 41);
            this.btnGuardarEditCargo.TabIndex = 43;
            this.btnGuardarEditCargo.Text = "Guardar";
            this.btnGuardarEditCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEditCargo.UseVisualStyleBackColor = false;
            this.btnGuardarEditCargo.Click += new System.EventHandler(this.btnGuardarEditCargo_Click);
            // 
            // FrmEditarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSueldoMensual);
            this.Controls.Add(this.lblSueldoCargo);
            this.Controls.Add(this.txtNombreCargo);
            this.Controls.Add(this.btnCancelarCargo);
            this.Controls.Add(this.btnLimpiarCargo);
            this.Controls.Add(this.btnGuardarEditCargo);
            this.Name = "FrmEditarCargo";
            this.Text = "FrmEditarCargo";
            //this.Load += new System.EventHandler(this.FrmEditarCargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSueldoMensual;
        private System.Windows.Forms.Label lblSueldoCargo;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private FontAwesome.Sharp.IconButton btnCancelarCargo;
        private FontAwesome.Sharp.IconButton btnLimpiarCargo;
        private FontAwesome.Sharp.IconButton btnGuardarEditCargo;
    }
}