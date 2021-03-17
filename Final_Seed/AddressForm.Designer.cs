
namespace Final_Seed
{
    partial class AddressForm
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.UpdAbtn = new System.Windows.Forms.Button();
            this.CncUbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(231, 94);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(66, 15);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Address of:";
            // 
            // UpdAbtn
            // 
            this.UpdAbtn.Location = new System.Drawing.Point(119, 401);
            this.UpdAbtn.Name = "UpdAbtn";
            this.UpdAbtn.Size = new System.Drawing.Size(156, 23);
            this.UpdAbtn.TabIndex = 1;
            this.UpdAbtn.Text = "Commit Changes";
            this.UpdAbtn.UseVisualStyleBackColor = true;
            // 
            // CncUbtn
            // 
            this.CncUbtn.Location = new System.Drawing.Point(499, 401);
            this.CncUbtn.Name = "CncUbtn";
            this.CncUbtn.Size = new System.Drawing.Size(145, 23);
            this.CncUbtn.TabIndex = 2;
            this.CncUbtn.Text = "Cancel Changes";
            this.CncUbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Street:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Zip Code:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(327, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 23);
            this.textBox4.TabIndex = 10;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CncUbtn);
            this.Controls.Add(this.UpdAbtn);
            this.Controls.Add(this.NameLbl);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button UpdAbtn;
        private System.Windows.Forms.Button CncUbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}