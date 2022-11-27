namespace parcial
{
    partial class boton12
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
            this.vmensuales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vmensuales
            // 
            this.vmensuales.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.vmensuales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmensuales.BackColor = System.Drawing.Color.Maroon;
            this.vmensuales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vmensuales.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.vmensuales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vmensuales.FlatAppearance.BorderSize = 0;
            this.vmensuales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.vmensuales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.vmensuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vmensuales.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmensuales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vmensuales.Image = global::parcial.Properties.Resources.Recurso_19_3x_8;
            this.vmensuales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vmensuales.Location = new System.Drawing.Point(294, 13);
            this.vmensuales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vmensuales.Name = "vmensuales";
            this.vmensuales.Padding = new System.Windows.Forms.Padding(8, 8, 8, 10);
            this.vmensuales.Size = new System.Drawing.Size(302, 129);
            this.vmensuales.TabIndex = 12;
            this.vmensuales.Text = "Ventas Mensuales";
            this.vmensuales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vmensuales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vmensuales.UseVisualStyleBackColor = false;
            this.vmensuales.Click += new System.EventHandler(this.vmensuales_Click);
            // 
            // boton12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(954, 657);
            this.Controls.Add(this.vmensuales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "boton12";
            this.Text = "boton12";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vmensuales;
    }
}