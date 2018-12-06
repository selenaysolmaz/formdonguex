namespace WindowsFormsApp4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lfor = new System.Windows.Forms.ListBox();
            this.lwhile = new System.Windows.Forms.ListBox();
            this.ldowhile = new System.Windows.Forms.ListBox();
            this.lıenum = new System.Windows.Forms.ListBox();
            this.lforeach = new System.Windows.Forms.ListBox();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnıenum = new System.Windows.Forms.Button();
            this.btnforeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar = {10,20,25,28,34} dizisi içersindeki rakamları ve enson satırda \r\ntoplam" +
    "larını Listbox\'a ekleyen kodu yazınız.";
            // 
            // lfor
            // 
            this.lfor.FormattingEnabled = true;
            this.lfor.Location = new System.Drawing.Point(15, 68);
            this.lfor.Name = "lfor";
            this.lfor.Size = new System.Drawing.Size(121, 160);
            this.lfor.TabIndex = 1;
            // 
            // lwhile
            // 
            this.lwhile.FormattingEnabled = true;
            this.lwhile.Location = new System.Drawing.Point(152, 68);
            this.lwhile.Name = "lwhile";
            this.lwhile.Size = new System.Drawing.Size(121, 160);
            this.lwhile.TabIndex = 2;
            // 
            // ldowhile
            // 
            this.ldowhile.FormattingEnabled = true;
            this.ldowhile.Location = new System.Drawing.Point(290, 68);
            this.ldowhile.Name = "ldowhile";
            this.ldowhile.Size = new System.Drawing.Size(121, 160);
            this.ldowhile.TabIndex = 3;
            // 
            // lıenum
            // 
            this.lıenum.FormattingEnabled = true;
            this.lıenum.Location = new System.Drawing.Point(426, 68);
            this.lıenum.Name = "lıenum";
            this.lıenum.Size = new System.Drawing.Size(121, 160);
            this.lıenum.TabIndex = 4;
            // 
            // lforeach
            // 
            this.lforeach.FormattingEnabled = true;
            this.lforeach.Location = new System.Drawing.Point(571, 68);
            this.lforeach.Name = "lforeach";
            this.lforeach.Size = new System.Drawing.Size(121, 160);
            this.lforeach.TabIndex = 5;
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(15, 234);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(121, 34);
            this.btnfor.TabIndex = 6;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(152, 234);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(121, 34);
            this.btnwhile.TabIndex = 7;
            this.btnwhile.Text = "while";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(290, 234);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(121, 34);
            this.btndowhile.TabIndex = 8;
            this.btndowhile.Text = "dowhile";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnıenum
            // 
            this.btnıenum.Location = new System.Drawing.Point(426, 234);
            this.btnıenum.Name = "btnıenum";
            this.btnıenum.Size = new System.Drawing.Size(121, 34);
            this.btnıenum.TabIndex = 9;
            this.btnıenum.Text = "ıenum";
            this.btnıenum.UseVisualStyleBackColor = true;
            this.btnıenum.Click += new System.EventHandler(this.btnıenum_Click);
            // 
            // btnforeach
            // 
            this.btnforeach.Location = new System.Drawing.Point(571, 234);
            this.btnforeach.Name = "btnforeach";
            this.btnforeach.Size = new System.Drawing.Size(121, 34);
            this.btnforeach.TabIndex = 10;
            this.btnforeach.Text = "foreach";
            this.btnforeach.UseVisualStyleBackColor = true;
            this.btnforeach.Click += new System.EventHandler(this.btnforeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 312);
            this.Controls.Add(this.btnforeach);
            this.Controls.Add(this.btnıenum);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.lforeach);
            this.Controls.Add(this.lıenum);
            this.Controls.Add(this.ldowhile);
            this.Controls.Add(this.lwhile);
            this.Controls.Add(this.lfor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lfor;
        private System.Windows.Forms.ListBox lwhile;
        private System.Windows.Forms.ListBox ldowhile;
        private System.Windows.Forms.ListBox lıenum;
        private System.Windows.Forms.ListBox lforeach;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnıenum;
        private System.Windows.Forms.Button btnforeach;
    }
}

