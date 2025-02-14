﻿namespace CapaPresentacion.Vistas_FondoPension
{
    partial class FrmFondoPension
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloSeccion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvFPension = new System.Windows.Forms.DataGridView();
            this.panelBuscarFPension = new System.Windows.Forms.Panel();
            this.txtBuscarFPension = new System.Windows.Forms.TextBox();
            this.btnBuscarFPension = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoFPension = new FontAwesome.Sharp.IconButton();
            this.btnEditarFPension = new FontAwesome.Sharp.IconButton();
            this.btnEliminarFPension = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFPension)).BeginInit();
            this.panelBuscarFPension.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.lblTituloSeccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 90);
            this.panel2.TabIndex = 15;
            // 
            // lblTituloSeccion
            // 
            this.lblTituloSeccion.AutoSize = true;
            this.lblTituloSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloSeccion.Location = new System.Drawing.Point(36, 29);
            this.lblTituloSeccion.Name = "lblTituloSeccion";
            this.lblTituloSeccion.Size = new System.Drawing.Size(209, 31);
            this.lblTituloSeccion.TabIndex = 0;
            this.lblTituloSeccion.Text = "Fondo Pension";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.dtgvFPension);
            this.panel1.Controls.Add(this.panelBuscarFPension);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 360);
            this.panel1.TabIndex = 16;
            // 
            // dtgvFPension
            // 
            this.dtgvFPension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvFPension.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFPension.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvFPension.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvFPension.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvFPension.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFPension.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFPension.ColumnHeadersHeight = 30;
            this.dtgvFPension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvFPension.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvFPension.EnableHeadersVisualStyles = false;
            this.dtgvFPension.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvFPension.Location = new System.Drawing.Point(206, 65);
            this.dtgvFPension.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvFPension.Name = "dtgvFPension";
            this.dtgvFPension.ReadOnly = true;
            this.dtgvFPension.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFPension.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvFPension.RowHeadersWidth = 51;
            this.dtgvFPension.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvFPension.RowTemplate.Height = 24;
            this.dtgvFPension.Size = new System.Drawing.Size(434, 204);
            this.dtgvFPension.TabIndex = 15;
            // 
            // panelBuscarFPension
            // 
            this.panelBuscarFPension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarFPension.Controls.Add(this.txtBuscarFPension);
            this.panelBuscarFPension.Controls.Add(this.btnBuscarFPension);
            this.panelBuscarFPension.Location = new System.Drawing.Point(303, 6);
            this.panelBuscarFPension.Name = "panelBuscarFPension";
            this.panelBuscarFPension.Size = new System.Drawing.Size(262, 52);
            this.panelBuscarFPension.TabIndex = 14;
            // 
            // txtBuscarFPension
            // 
            this.txtBuscarFPension.Location = new System.Drawing.Point(19, 19);
            this.txtBuscarFPension.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarFPension.Name = "txtBuscarFPension";
            this.txtBuscarFPension.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarFPension.TabIndex = 12;
            // 
            // btnBuscarFPension
            // 
            this.btnBuscarFPension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarFPension.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFPension.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarFPension.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFPension.IconSize = 21;
            this.btnBuscarFPension.Location = new System.Drawing.Point(208, 17);
            this.btnBuscarFPension.Name = "btnBuscarFPension";
            this.btnBuscarFPension.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarFPension.TabIndex = 11;
            this.btnBuscarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFPension.UseVisualStyleBackColor = false;
            this.btnBuscarFPension.Click += new System.EventHandler(this.btnBuscarFPension_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnNuevoFPension);
            this.panel3.Controls.Add(this.btnEditarFPension);
            this.panel3.Controls.Add(this.btnEliminarFPension);
            this.panel3.Location = new System.Drawing.Point(237, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 64);
            this.panel3.TabIndex = 13;
            // 
            // btnNuevoFPension
            // 
            this.btnNuevoFPension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoFPension.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoFPension.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoFPension.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoFPension.IconSize = 21;
            this.btnNuevoFPension.Location = new System.Drawing.Point(44, 14);
            this.btnNuevoFPension.Name = "btnNuevoFPension";
            this.btnNuevoFPension.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoFPension.TabIndex = 8;
            this.btnNuevoFPension.Text = "Nuevo";
            this.btnNuevoFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoFPension.UseVisualStyleBackColor = false;
            this.btnNuevoFPension.Click += new System.EventHandler(this.btnNuevoFPension_Click);
            // 
            // btnEditarFPension
            // 
            this.btnEditarFPension.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarFPension.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarFPension.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarFPension.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarFPension.IconSize = 21;
            this.btnEditarFPension.Location = new System.Drawing.Point(151, 14);
            this.btnEditarFPension.Name = "btnEditarFPension";
            this.btnEditarFPension.Size = new System.Drawing.Size(81, 33);
            this.btnEditarFPension.TabIndex = 10;
            this.btnEditarFPension.Text = "Editar";
            this.btnEditarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarFPension.UseVisualStyleBackColor = false;
            this.btnEditarFPension.Click += new System.EventHandler(this.btnEditarFPension_Click);
            // 
            // btnEliminarFPension
            // 
            this.btnEliminarFPension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarFPension.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarFPension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFPension.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarFPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFPension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarFPension.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarFPension.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarFPension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarFPension.IconSize = 21;
            this.btnEliminarFPension.Location = new System.Drawing.Point(258, 14);
            this.btnEliminarFPension.Name = "btnEliminarFPension";
            this.btnEliminarFPension.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarFPension.TabIndex = 9;
            this.btnEliminarFPension.Text = "Eliminar";
            this.btnEliminarFPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFPension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarFPension.UseVisualStyleBackColor = false;
            this.btnEliminarFPension.Click += new System.EventHandler(this.btnEliminarFPension_Click);
            // 
            // FrmFondoPension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmFondoPension";
            this.Text = "FrmFondoPension";
            this.Load += new System.EventHandler(this.FrmFondoPension_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFPension)).EndInit();
            this.panelBuscarFPension.ResumeLayout(false);
            this.panelBuscarFPension.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloSeccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBuscarFPension;
        private System.Windows.Forms.TextBox txtBuscarFPension;
        private FontAwesome.Sharp.IconButton btnBuscarFPension;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoFPension;
        private FontAwesome.Sharp.IconButton btnEditarFPension;
        private FontAwesome.Sharp.IconButton btnEliminarFPension;
        private System.Windows.Forms.DataGridView dtgvFPension;
    }
}