namespace CapaPresentacion.Vistas_Banco
{
    partial class FrmEditarBanco
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
            this.btnGuardarEditBanco = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBanco = new FontAwesome.Sharp.IconButton();
            this.btnCancelarBanco = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Editar Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nombre";
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Location = new System.Drawing.Point(84, 90);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(255, 20);
            this.txtNombreBanco.TabIndex = 45;
            // 
            // btnGuardarEditBanco
            // 
            this.btnGuardarEditBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarEditBanco.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarEditBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEditBanco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarEditBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditBanco.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarEditBanco.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEditBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEditBanco.IconSize = 21;
            this.btnGuardarEditBanco.Location = new System.Drawing.Point(35, 144);
            this.btnGuardarEditBanco.Name = "btnGuardarEditBanco";
            this.btnGuardarEditBanco.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarEditBanco.TabIndex = 46;
            this.btnGuardarEditBanco.Text = "Guardar";
            this.btnGuardarEditBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEditBanco.UseVisualStyleBackColor = false;
            this.btnGuardarEditBanco.Click += new System.EventHandler(this.btnGuardarEditBanco_Click);
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
            this.btnLimpiarBanco.Location = new System.Drawing.Point(144, 143);
            this.btnLimpiarBanco.Name = "btnLimpiarBanco";
            this.btnLimpiarBanco.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarBanco.TabIndex = 47;
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
            this.btnCancelarBanco.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBanco.ForeColor = System.Drawing.Color.White;
            this.btnCancelarBanco.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarBanco.IconColor = System.Drawing.Color.White;
            this.btnCancelarBanco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarBanco.IconSize = 21;
            this.btnCancelarBanco.Location = new System.Drawing.Point(244, 144);
            this.btnCancelarBanco.Name = "btnCancelarBanco";
            this.btnCancelarBanco.Size = new System.Drawing.Size(81, 32);
            this.btnCancelarBanco.TabIndex = 48;
            this.btnCancelarBanco.Text = "Cancelar";
            this.btnCancelarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarBanco.UseVisualStyleBackColor = false;
            this.btnCancelarBanco.Click += new System.EventHandler(this.btnCancelarBanco_Click);
            // 
            // FrmEditarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 229);
            this.Controls.Add(this.btnCancelarBanco);
            this.Controls.Add(this.btnLimpiarBanco);
            this.Controls.Add(this.btnGuardarEditBanco);
            this.Controls.Add(this.txtNombreBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmEditarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private FontAwesome.Sharp.IconButton btnGuardarEditBanco;
        private FontAwesome.Sharp.IconButton btnLimpiarBanco;
        private FontAwesome.Sharp.IconButton btnCancelarBanco;
    }
}