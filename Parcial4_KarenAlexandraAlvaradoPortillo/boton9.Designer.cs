namespace parcial
{
    partial class boton9
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
            this.informes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informes
            // 
            this.informes.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.informes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.informes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.informes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.informes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.informes.FlatAppearance.BorderSize = 0;
            this.informes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.informes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.informes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informes.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.informes.Image = global::parcial.Properties.Resources.Recurso_23_3x_8;
            this.informes.Location = new System.Drawing.Point(253, 13);
            this.informes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.informes.Name = "informes";
            this.informes.Padding = new System.Windows.Forms.Padding(10);
            this.informes.Size = new System.Drawing.Size(414, 129);
            this.informes.TabIndex = 9;
            this.informes.Text = "informes de ingresos a cajas";
            this.informes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.informes.UseVisualStyleBackColor = false;
            // 
            // boton9
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(934, 565);
            this.Controls.Add(this.informes);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "boton9";
            this.Text = "boton9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button informes;
    }
}