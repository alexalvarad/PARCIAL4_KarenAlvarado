namespace parcial
{
    partial class boton5
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
            this.egreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // egreso
            // 
            this.egreso.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.egreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.egreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.egreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.egreso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.egreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.egreso.FlatAppearance.BorderSize = 0;
            this.egreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.egreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.egreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.egreso.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.egreso.Image = global::parcial.Properties.Resources.Recurso_18_3x_8;
            this.egreso.Location = new System.Drawing.Point(226, 13);
            this.egreso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.egreso.Name = "egreso";
            this.egreso.Padding = new System.Windows.Forms.Padding(10);
            this.egreso.Size = new System.Drawing.Size(375, 129);
            this.egreso.TabIndex = 5;
            this.egreso.Text = "Registro de egresos";
            this.egreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.egreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.egreso.UseVisualStyleBackColor = false;
            // 
            // boton5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(891, 569);
            this.Controls.Add(this.egreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "boton5";
            this.Text = "boton5";
            this.Load += new System.EventHandler(this.boton5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button egreso;
    }
}