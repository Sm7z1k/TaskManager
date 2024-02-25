namespace TaskManager
{
    partial class TaskManager
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
            this.ProcessesPage = new System.Windows.Forms.TabPage();
            this.ProcessGridView = new System.Windows.Forms.DataGridView();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProcessesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessesPage
            // 
            this.ProcessesPage.Controls.Add(this.ProcessGridView);
            this.ProcessesPage.Location = new System.Drawing.Point(4, 22);
            this.ProcessesPage.Name = "ProcessesPage";
            this.ProcessesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessesPage.Size = new System.Drawing.Size(926, 311);
            this.ProcessesPage.TabIndex = 1;
            this.ProcessesPage.Text = "Processes";
            this.ProcessesPage.UseVisualStyleBackColor = true;
            // 
            // ProcessGridView
            // 
            this.ProcessGridView.AllowUserToAddRows = false;
            this.ProcessGridView.AllowUserToDeleteRows = false;
            this.ProcessGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcessGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProcessGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGridView.Location = new System.Drawing.Point(3, 3);
            this.ProcessGridView.Name = "ProcessGridView";
            this.ProcessGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcessGridView.Size = new System.Drawing.Size(923, 305);
            this.ProcessGridView.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.ProcessesPage);
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(934, 337);
            this.MainTabControl.TabIndex = 7;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 436);
            this.Controls.Add(this.MainTabControl);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.ProcessesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage ProcessesPage;
        public System.Windows.Forms.DataGridView ProcessGridView;
        private System.Windows.Forms.TabControl MainTabControl;
    }
}

