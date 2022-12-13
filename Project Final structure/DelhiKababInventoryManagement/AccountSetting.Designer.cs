namespace DelhiKababInventoryManagement
{
    partial class AccountSetting
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
            this.ViewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(989, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewBtn.Location = new System.Drawing.Point(258, 523);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(148, 42);
            this.ViewBtn.TabIndex = 1;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(433, 521);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(148, 42);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBtn.Location = new System.Drawing.Point(612, 523);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(135, 39);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AccountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(998, 574);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountSetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button ViewBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
    }
}