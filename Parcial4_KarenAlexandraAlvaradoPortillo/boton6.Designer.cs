namespace parcial
{
    partial class boton6
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
            this.caja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caja
            // 
            this.caja.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.caja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caja.BackColor = System.Drawing.Color.CornflowerBlue;
            this.caja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.caja.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.caja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.caja.FlatAppearance.BorderSize = 0;
            this.caja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.caja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caja.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caja.Image = global::parcial.Properties.Resources.Recurso_20_3x_8;
            this.caja.Location = new System.Drawing.Point(326, 13);
            this.caja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.caja.Name = "caja";
            this.caja.Padding = new System.Windows.Forms.Padding(10);
            this.caja.Size = new System.Drawing.Size(351, 129);
            this.caja.TabIndex = 6;
            this.caja.Text = "Registro de caja";
            this.caja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.caja.UseVisualStyleBackColor = false;
            // 
            // boton6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(991, 623);
            this.Controls.Add(this.caja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "boton6";
            this.Text = "boto6";
            this.Load += new System.EventHandler(this.boton6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button caja;
    }
}