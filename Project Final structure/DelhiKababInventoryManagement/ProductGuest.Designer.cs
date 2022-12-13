namespace DelhiKababInventoryManagement
{
    partial class ProductGuest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(283, 488);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(365, 23);
            this.SearchTxt.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(661, 478);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(181, 42);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewBtn.Location = new System.Drawing.Point(72, 479);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(163, 45);
            this.ViewBtn.TabIndex = 6;
            this.ViewBtn.Text = "View Quantity";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ProductGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(999, 578);
            this.ControlBox = false;
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductGuest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox SearchTxt;
        private Button SearchBtn;
        private Button ViewBtn;
    }
}