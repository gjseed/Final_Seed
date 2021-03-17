
namespace Final_Seed
{
    partial class NameForm
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
            this.UpdBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FNtxtBx = new System.Windows.Forms.TextBox();
            this.LNtxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdBtn
            // 
            this.UpdBtn.Location = new System.Drawing.Point(72, 35);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(134, 23);
            this.UpdBtn.TabIndex = 0;
            this.UpdBtn.Text = "Commit Changes";
            this.UpdBtn.UseVisualStyleBackColor = true;
            this.UpdBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.Location = new System.Drawing.Point(72, 110);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(134, 23);
            this.CBtn.TabIndex = 1;
            this.CBtn.Text = "Cancel Changes";
            this.CBtn.UseVisualStyleBackColor = true;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // FNtxtBx
            // 
            this.FNtxtBx.Location = new System.Drawing.Point(348, 36);
            this.FNtxtBx.Name = "FNtxtBx";
            this.FNtxtBx.Size = new System.Drawing.Size(257, 23);
            this.FNtxtBx.TabIndex = 4;
            // 
            // LNtxtBx
            // 
            this.LNtxtBx.Location = new System.Drawing.Point(348, 110);
            this.LNtxtBx.Name = "LNtxtBx";
            this.LNtxtBx.Size = new System.Drawing.Size(257, 23);
            this.LNtxtBx.TabIndex = 5;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 199);
            this.Controls.Add(this.LNtxtBx);
            this.Controls.Add(this.FNtxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.UpdBtn);
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FNtxtBx;
        private System.Windows.Forms.TextBox LNtxtBx;
    }
}