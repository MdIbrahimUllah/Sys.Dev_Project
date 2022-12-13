namespace DelhiKababInventoryManagement
{
    partial class Supplier
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
            this.viewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewBtn.Location = new System.Drawing.Point(14, 520);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(132, 46);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "view";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(169, 521);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(134, 46);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBtn.Location = new System.Drawing.Point(338, 521);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 46);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(840, 520);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(205, 57);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(135, 28);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(365, 57);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(415, 23);
            this.SearchTxt.TabIndex = 6;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 597);
            this.ControlBox = false;
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Supplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button viewBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button button4;
        private Button Search;
        private TextBox SearchTxt;
    }
}