namespace parcial
{
    partial class boton3
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
            this.proveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proveedores
            // 
            this.proveedores.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedores.BackColor = System.Drawing.Color.Indigo;
            this.proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.proveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.proveedores.FlatAppearance.BorderSize = 0;
            this.proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedores.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proveedores.Image = global::parcial.Properties.Resources.Recurso_15_3x_8;
            this.proveedores.Location = new System.Drawing.Point(240, 13);
            this.proveedores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.proveedores.Name = "proveedores";
            this.proveedores.Padding = new System.Windows.Forms.Padding(10);
            this.proveedores.Size = new System.Drawing.Size(422, 129);
            this.proveedores.TabIndex = 3;
            this.proveedores.Text = "Registro de proveedores";
            this.proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.proveedores.UseVisualStyleBackColor = false;
            this.proveedores.Click += new System.EventHandler(this.proveedores_Click);
            // 
            // boton3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(934, 626);
            this.Controls.Add(this.proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "boton3";
            this.Text = "boton3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button proveedores;
    }
}