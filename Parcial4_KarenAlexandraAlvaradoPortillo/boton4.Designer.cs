namespace parcial
{
    partial class boton4
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
            this.categorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorias
            // 
            this.categorias.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.categorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.categorias.FlatAppearance.BorderSize = 0;
            this.categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorias.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categorias.Image = global::parcial.Properties.Resources.Recurso_17_3x_8;
            this.categorias.Location = new System.Drawing.Point(218, 13);
            this.categorias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.categorias.Name = "categorias";
            this.categorias.Padding = new System.Windows.Forms.Padding(10);
            this.categorias.Size = new System.Drawing.Size(384, 126);
            this.categorias.TabIndex = 4;
            this.categorias.Text = "Registro de categorias";
            this.categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categorias.UseVisualStyleBackColor = false;
            // 
            // boton4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(911, 603);
            this.Controls.Add(this.categorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "boton4";
            this.Text = "boton4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button categorias;
    }
}