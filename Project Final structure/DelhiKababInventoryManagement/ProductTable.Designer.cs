namespace DelhiKababInventoryManagement
{
    partial class ProductTable
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
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(23, 540);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(151, 45);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Location = new System.Drawing.Point(192, 541);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(159, 45);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "View ";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Update
            // 
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update.Location = new System.Drawing.Point(369, 541);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(154, 45);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(833, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(533, 64);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(174, 34);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(187, 71);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(327, 23);
            this.SearchTxt.TabIndex = 6;
            // 
            // ProductTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 624);
            this.ControlBox = false;
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.productgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button Add;
        private Button Edit;
        private Button Update;
        private Button button1;
        private Button SearchButton;
        private TextBox SearchTxt;
    }
}