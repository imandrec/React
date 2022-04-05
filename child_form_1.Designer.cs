namespace Tarea4
{
    partial class NewSimulationForm
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
			this.InputFileNameTextBox = new System.Windows.Forms.TextBox();
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.LoadDataButton = new System.Windows.Forms.Button();
			this.CalculateMovingAveragesButton = new System.Windows.Forms.Button();
			this.ViewReportButton = new System.Windows.Forms.Button();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input file name";
			// 
			// InputFileNameTextBox
			// 
			this.InputFileNameTextBox.Location = new System.Drawing.Point(133, 29);
			this.InputFileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.InputFileNameTextBox.Name = "InputFileNameTextBox";
			this.InputFileNameTextBox.Size = new System.Drawing.Size(242, 20);
			this.InputFileNameTextBox.TabIndex = 1;
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(383, 27);
			this.SelectFileButton.Margin = new System.Windows.Forms.Padding(2);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(99, 22);
			this.SelectFileButton.TabIndex = 2;
			this.SelectFileButton.Text = "Select File";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// LoadDataButton
			// 
			this.LoadDataButton.Location = new System.Drawing.Point(11, 341);
			this.LoadDataButton.Margin = new System.Windows.Forms.Padding(2);
			this.LoadDataButton.Name = "LoadDataButton";
			this.LoadDataButton.Size = new System.Drawing.Size(74, 24);
			this.LoadDataButton.TabIndex = 4;
			this.LoadDataButton.Text = "Load Data";
			this.LoadDataButton.UseVisualStyleBackColor = true;
			this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
			// 
			// CalculateMovingAveragesButton
			// 
			this.CalculateMovingAveragesButton.Location = new System.Drawing.Point(208, 341);
			this.CalculateMovingAveragesButton.Margin = new System.Windows.Forms.Padding(2);
			this.CalculateMovingAveragesButton.Name = "CalculateMovingAveragesButton";
			this.CalculateMovingAveragesButton.Size = new System.Drawing.Size(155, 24);
			this.CalculateMovingAveragesButton.TabIndex = 5;
			this.CalculateMovingAveragesButton.Text = "Calculate Moving Averages";
			this.CalculateMovingAveragesButton.UseVisualStyleBackColor = true;
			this.CalculateMovingAveragesButton.Click += new System.EventHandler(this.CalculateMovingAveragesButton_Click);
			// 
			// ViewReportButton
			// 
			this.ViewReportButton.Location = new System.Drawing.Point(531, 341);
			this.ViewReportButton.Margin = new System.Windows.Forms.Padding(2);
			this.ViewReportButton.Name = "ViewReportButton";
			this.ViewReportButton.Size = new System.Drawing.Size(82, 24);
			this.ViewReportButton.TabIndex = 6;
			this.ViewReportButton.Text = "View Report";
			this.ViewReportButton.UseVisualStyleBackColor = true;
			this.ViewReportButton.Click += new System.EventHandler(this.ViewReportButton_Click);
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.ResultTextBox.Location = new System.Drawing.Point(11, 81);
			this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultTextBox.Size = new System.Drawing.Size(673, 239);
			this.ResultTextBox.TabIndex = 7;
			// 
			// NewSimulationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 406);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.ViewReportButton);
			this.Controls.Add(this.CalculateMovingAveragesButton);
			this.Controls.Add(this.LoadDataButton);
			this.Controls.Add(this.SelectFileButton);
			this.Controls.Add(this.InputFileNameTextBox);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "NewSimulationForm";
			this.Text = "NewSimulationForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputFileNameTextBox;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Button CalculateMovingAveragesButton;
        private System.Windows.Forms.Button ViewReportButton;
		protected System.Windows.Forms.TextBox ResultTextBox;
	}
}