﻿namespace WindowsFormsGia2
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cajaDeMensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaDeMensajesToolStripMenuItem,
            this.visorDeImagenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cajaDeMensajesToolStripMenuItem
            // 
            this.cajaDeMensajesToolStripMenuItem.Name = "cajaDeMensajesToolStripMenuItem";
            this.cajaDeMensajesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.cajaDeMensajesToolStripMenuItem.Text = "Caja de Mensajes";
            this.cajaDeMensajesToolStripMenuItem.Click += new System.EventHandler(this.cajaDeMensajesToolStripMenuItem_Click);
            // 
            // visorDeImagenesToolStripMenuItem
            // 
            this.visorDeImagenesToolStripMenuItem.Name = "visorDeImagenesToolStripMenuItem";
            this.visorDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.visorDeImagenesToolStripMenuItem.Text = "Visor de Imagenes";
            this.visorDeImagenesToolStripMenuItem.Click += new System.EventHandler(this.visorDeImagenesToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 567);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cajaDeMensajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visorDeImagenesToolStripMenuItem;
    }
}



