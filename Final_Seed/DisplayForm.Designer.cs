
namespace Final_Seed
{
    partial class DisplayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EdtNameBtn = new System.Windows.Forms.Button();
            this.EdtAddBtn = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EdtNameBtn
            // 
            this.EdtNameBtn.Location = new System.Drawing.Point(12, 93);
            this.EdtNameBtn.Name = "EdtNameBtn";
            this.EdtNameBtn.Size = new System.Drawing.Size(75, 23);
            this.EdtNameBtn.TabIndex = 0;
            this.EdtNameBtn.Text = "Edit Name";
            this.EdtNameBtn.UseVisualStyleBackColor = true;
            this.EdtNameBtn.Click += new System.EventHandler(this.EdtNameBtn_Click);
            // 
            // EdtAddBtn
            // 
            this.EdtAddBtn.Location = new System.Drawing.Point(12, 285);
            this.EdtAddBtn.Name = "EdtAddBtn";
            this.EdtAddBtn.Size = new System.Drawing.Size(102, 23);
            this.EdtAddBtn.TabIndex = 1;
            this.EdtAddBtn.Text = "Edit Address";
            this.EdtAddBtn.UseVisualStyleBackColor = true;
            this.EdtAddBtn.Click += new System.EventHandler(this.EdtAddBtn_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(120, 12);
            this.GridView.Name = "GridView";
            this.GridView.RowTemplate.Height = 25;
            this.GridView.Size = new System.Drawing.Size(668, 426);
            this.GridView.TabIndex = 2;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.EdtAddBtn);
            this.Controls.Add(this.EdtNameBtn);
            this.Name = "DisplayForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EdtNameBtn;
        private System.Windows.Forms.Button EdtAddBtn;
        private System.Windows.Forms.DataGridView GridView;
    }
}

