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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button3 = new System.Windows.Forms.Button();
            this.rbRec1 = new System.Windows.Forms.RadioButton();
            this.rbRec2 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSoll = new System.Windows.Forms.TextBox();
            this.txtHaben = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.kontoTreeView1 = new PresentationLayer.KontoTreeView();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 111);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(344, 435);
            this.treeView1.TabIndex = 3;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1011, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(444, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 168);
            this.tabControl1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbRec1
            // 
            this.rbRec1.AutoSize = true;
            this.rbRec1.Location = new System.Drawing.Point(24, 564);
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
            this.rbRec2.Location = new System.Drawing.Point(25, 600);
            this.rbRec2.Name = "rbRec2";
            this.rbRec2.Size = new System.Drawing.Size(115, 21);
            this.rbRec2.TabIndex = 8;
            this.rbRec2.TabStop = true;
            this.rbRec2.Text = "Nicht rekursiv";
            this.rbRec2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(997, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(671, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSoll
            // 
            this.txtSoll.Location = new System.Drawing.Point(1014, 91);
            this.txtSoll.Name = "txtSoll";
            this.txtSoll.Size = new System.Drawing.Size(100, 22);
            this.txtSoll.TabIndex = 13;
            // 
            // txtHaben
            // 
            this.txtHaben.Location = new System.Drawing.Point(1014, 128);
            this.txtHaben.Name = "txtHaben";
            this.txtHaben.Size = new System.Drawing.Size(100, 22);
            this.txtHaben.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1024, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // kontoTreeView1
            // 
            this.kontoTreeView1.Location = new System.Drawing.Point(444, 296);
            this.kontoTreeView1.Name = "kontoTreeView1";
            this.kontoTreeView1.Size = new System.Drawing.Size(521, 387);
            this.kontoTreeView1.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1053, 441);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 731);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtHaben);
            this.Controls.Add(this.txtSoll);
            this.Controls.Add(this.kontoTreeView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rbRec2);
            this.Controls.Add(this.rbRec1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbRec1;
        private System.Windows.Forms.RadioButton rbRec2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private PresentationLayer.KontoTreeView kontoTreeView1;
        private System.Windows.Forms.TextBox txtSoll;
        private System.Windows.Forms.TextBox txtHaben;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

