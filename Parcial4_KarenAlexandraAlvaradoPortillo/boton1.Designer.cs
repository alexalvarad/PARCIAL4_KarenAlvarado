namespace parcial
{
    partial class boton1
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
            this.productos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productos
            // 
            this.productos.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productos.BackColor = System.Drawing.Color.MediumBlue;
            this.productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.productos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productos.FlatAppearance.BorderSize = 0;
            this.productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productos.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productos.Image = global::parcial.Properties.Resources.Recurso_13_3x_8;
            this.productos.Location = new System.Drawing.Point(261, 13);
            this.productos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.productos.Name = "productos";
            this.productos.Padding = new System.Windows.Forms.Padding(10);
            this.productos.Size = new System.Drawing.Size(418, 126);
            this.productos.TabIndex = 1;
            this.productos.Text = "Registro de productos";
            this.productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productos.UseCompatibleTextRendering = true;
            this.productos.UseVisualStyleBackColor = false;
            // 
            // boton1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(958, 682);
            this.Controls.Add(this.productos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "boton1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "boton1";
            this.Load += new System.EventHandler(this.boton1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button productos;
    }
}