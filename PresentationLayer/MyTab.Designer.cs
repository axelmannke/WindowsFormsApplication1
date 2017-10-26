namespace PresentationLayer
{
    partial class MyTab
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSoll = new System.Windows.Forms.TextBox();
            this.txtHaben = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoll
            // 
            this.txtSoll.Location = new System.Drawing.Point(108, 40);
            this.txtSoll.Name = "txtSoll";
            this.txtSoll.Size = new System.Drawing.Size(100, 22);
            this.txtSoll.TabIndex = 0;
            // 
            // txtHaben
            // 
            this.txtHaben.Location = new System.Drawing.Point(108, 77);
            this.txtHaben.Name = "txtHaben";
            this.txtHaben.Size = new System.Drawing.Size(100, 22);
            this.txtHaben.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soll:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Haben:";
            // 
            // MyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHaben);
            this.Controls.Add(this.txtSoll);
            this.Name = "MyTab";
            this.Size = new System.Drawing.Size(356, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoll;
        private System.Windows.Forms.TextBox txtHaben;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
