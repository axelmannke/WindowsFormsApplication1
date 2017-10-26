namespace WindowsFormsApplication1
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button3 = new System.Windows.Forms.Button();
            this.rbRec1 = new System.Windows.Forms.RadioButton();
            this.rbRec2 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.kontoTreeView1 = new PresentationLayer.KontoTreeView();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 418);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 264);
            this.tabControl1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 69);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ausgewähltes Konto im TabControl darstellen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbRec1
            // 
            this.rbRec1.AutoSize = true;
            this.rbRec1.Location = new System.Drawing.Point(554, 99);
            this.rbRec1.Name = "rbRec1";
            this.rbRec1.Size = new System.Drawing.Size(84, 21);
            this.rbRec1.TabIndex = 7;
            this.rbRec1.Text = "Rekursiv";
            this.rbRec1.UseVisualStyleBackColor = true;
            // 
            // rbRec2
            // 
            this.rbRec2.AutoSize = true;
            this.rbRec2.Checked = true;
            this.rbRec2.Location = new System.Drawing.Point(659, 99);
            this.rbRec2.Name = "rbRec2";
            this.rbRec2.Size = new System.Drawing.Size(115, 21);
            this.rbRec2.TabIndex = 8;
            this.rbRec2.TabStop = true;
            this.rbRec2.Text = "Nicht rekursiv";
            this.rbRec2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(554, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 69);
            this.button4.TabIndex = 10;
            this.button4.Text = "Konten abrufen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(554, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 69);
            this.button5.TabIndex = 11;
            this.button5.Text = "Form2 öffnen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // kontoTreeView1
            // 
            this.kontoTreeView1.Location = new System.Drawing.Point(12, 12);
            this.kontoTreeView1.Name = "kontoTreeView1";
            this.kontoTreeView1.Size = new System.Drawing.Size(521, 387);
            this.kontoTreeView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 697);
            this.Controls.Add(this.kontoTreeView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rbRec2);
            this.Controls.Add(this.rbRec1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbRec1;
        private System.Windows.Forms.RadioButton rbRec2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private PresentationLayer.KontoTreeView kontoTreeView1;
    }
}

