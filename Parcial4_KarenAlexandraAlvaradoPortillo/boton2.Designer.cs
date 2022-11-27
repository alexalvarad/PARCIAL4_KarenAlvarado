namespace parcial
{
    partial class boton2
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
            this.clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientes
            // 
            this.clientes.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clientes.FlatAppearance.BorderSize = 0;
            this.clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientes.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientes.Image = global::parcial.Properties.Resources.Recurso_14_3x_8;
            this.clientes.Location = new System.Drawing.Point(232, 13);
            this.clientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(10);
            this.clientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientes.Size = new System.Drawing.Size(441, 171);
            this.clientes.TabIndex = 2;
            this.clientes.Text = "Registro de clientes";
            this.clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientes.UseVisualStyleBackColor = false;
            this.clientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // boton2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(904, 580);
            this.Controls.Add(this.clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "boton2";
            this.Text = "boton2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientes;
    }
}