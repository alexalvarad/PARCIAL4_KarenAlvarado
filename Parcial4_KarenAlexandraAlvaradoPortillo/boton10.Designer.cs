namespace parcial
{
    partial class boton10
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
            this.vrealizadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vrealizadas
            // 
            this.vrealizadas.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.vrealizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vrealizadas.BackColor = System.Drawing.Color.PaleVioletRed;
            this.vrealizadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vrealizadas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.vrealizadas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vrealizadas.FlatAppearance.BorderSize = 0;
            this.vrealizadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.vrealizadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.vrealizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vrealizadas.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrealizadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vrealizadas.Image = global::parcial.Properties.Resources.Recurso_22_3x_8;
            this.vrealizadas.Location = new System.Drawing.Point(302, 13);
            this.vrealizadas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vrealizadas.Name = "vrealizadas";
            this.vrealizadas.Padding = new System.Windows.Forms.Padding(5);
            this.vrealizadas.Size = new System.Drawing.Size(323, 126);
            this.vrealizadas.TabIndex = 10;
            this.vrealizadas.Text = "Ventas realizadas";
            this.vrealizadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vrealizadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vrealizadas.UseVisualStyleBackColor = false;
            // 
            // boton10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(965, 611);
            this.Controls.Add(this.vrealizadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "boton10";
            this.Text = "boton10";
            this.Load += new System.EventHandler(this.boton10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vrealizadas;
    }
}