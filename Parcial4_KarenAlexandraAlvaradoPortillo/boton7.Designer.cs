namespace parcial
{
    partial class boton7
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
            this.ventas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ventas
            // 
            this.ventas.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ventas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ventas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ventas.FlatAppearance.BorderSize = 0;
            this.ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventas.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ventas.Image = global::parcial.Properties.Resources.Recurso_21_3x_8;
            this.ventas.Location = new System.Drawing.Point(292, 13);
            this.ventas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ventas.Name = "ventas";
            this.ventas.Padding = new System.Windows.Forms.Padding(10);
            this.ventas.Size = new System.Drawing.Size(259, 126);
            this.ventas.TabIndex = 7;
            this.ventas.Text = "Ventas";
            this.ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ventas.UseVisualStyleBackColor = false;
            // 
            // boton7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(908, 565);
            this.Controls.Add(this.ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "boton7";
            this.Text = "boton7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ventas;
    }
}