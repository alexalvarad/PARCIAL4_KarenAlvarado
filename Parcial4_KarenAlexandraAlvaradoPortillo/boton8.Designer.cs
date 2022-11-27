namespace parcial
{
    partial class boton8
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
            this.compras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compras
            // 
            this.compras.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.compras.BackColor = System.Drawing.Color.DarkMagenta;
            this.compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.compras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.compras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.compras.FlatAppearance.BorderSize = 0;
            this.compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compras.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compras.Image = global::parcial.Properties.Resources.Recurso_16_3x_8;
            this.compras.Location = new System.Drawing.Point(337, 13);
            this.compras.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.compras.Name = "compras";
            this.compras.Padding = new System.Windows.Forms.Padding(10);
            this.compras.Size = new System.Drawing.Size(259, 129);
            this.compras.TabIndex = 8;
            this.compras.Text = "Compras";
            this.compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.compras.UseVisualStyleBackColor = false;
            // 
            // boton8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(941, 564);
            this.Controls.Add(this.compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "boton8";
            this.Text = "boton8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compras;
    }
}