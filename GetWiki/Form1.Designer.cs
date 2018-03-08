namespace GetWiki
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_InputLink = new System.Windows.Forms.TextBox();
            this.b_GetLink = new System.Windows.Forms.Button();
            this.tb_ShowText = new System.Windows.Forms.TextBox();
            this.tb_ShowTittle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_InputLink
            // 
            this.tb_InputLink.Location = new System.Drawing.Point(12, 32);
            this.tb_InputLink.Name = "tb_InputLink";
            this.tb_InputLink.Size = new System.Drawing.Size(381, 20);
            this.tb_InputLink.TabIndex = 0;
            // 
            // b_GetLink
            // 
            this.b_GetLink.Location = new System.Drawing.Point(174, 58);
            this.b_GetLink.Name = "b_GetLink";
            this.b_GetLink.Size = new System.Drawing.Size(75, 23);
            this.b_GetLink.TabIndex = 1;
            this.b_GetLink.Text = "button1";
            this.b_GetLink.UseVisualStyleBackColor = true;
            this.b_GetLink.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_ShowText
            // 
            this.tb_ShowText.Location = new System.Drawing.Point(12, 113);
            this.tb_ShowText.Multiline = true;
            this.tb_ShowText.Name = "tb_ShowText";
            this.tb_ShowText.ReadOnly = true;
            this.tb_ShowText.Size = new System.Drawing.Size(381, 241);
            this.tb_ShowText.TabIndex = 2;
            // 
            // tb_ShowTittle
            // 
            this.tb_ShowTittle.Location = new System.Drawing.Point(12, 87);
            this.tb_ShowTittle.Name = "tb_ShowTittle";
            this.tb_ShowTittle.ReadOnly = true;
            this.tb_ShowTittle.Size = new System.Drawing.Size(381, 20);
            this.tb_ShowTittle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 366);
            this.Controls.Add(this.tb_ShowTittle);
            this.Controls.Add(this.tb_ShowText);
            this.Controls.Add(this.b_GetLink);
            this.Controls.Add(this.tb_InputLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_InputLink;
        private System.Windows.Forms.Button b_GetLink;
        private System.Windows.Forms.TextBox tb_ShowText;
        private System.Windows.Forms.TextBox tb_ShowTittle;
    }
}

