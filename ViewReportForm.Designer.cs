
namespace Tarea4
{
	partial class ViewReportForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.DeSerializationButton = new System.Windows.Forms.Button();
            this.SerializationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ResultTextBox.Location = new System.Drawing.Point(42, 18);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(1303, 579);
            this.ResultTextBox.TabIndex = 0;
            // 
            // DeSerializationButton
            // 
            this.DeSerializationButton.Location = new System.Drawing.Point(42, 631);
            this.DeSerializationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeSerializationButton.Name = "DeSerializationButton";
            this.DeSerializationButton.Size = new System.Drawing.Size(309, 69);
            this.DeSerializationButton.TabIndex = 1;
            this.DeSerializationButton.Text = "Deserialization";
            this.DeSerializationButton.UseVisualStyleBackColor = true;
            this.DeSerializationButton.Click += new System.EventHandler(this.DeSerializationButton_Click);
            // 
            // SerializationButton
            // 
            this.SerializationButton.Location = new System.Drawing.Point(1038, 631);
            this.SerializationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerializationButton.Name = "SerializationButton";
            this.SerializationButton.Size = new System.Drawing.Size(309, 69);
            this.SerializationButton.TabIndex = 1;
            this.SerializationButton.Text = "Serialization";
            this.SerializationButton.UseVisualStyleBackColor = true;
            this.SerializationButton.Click += new System.EventHandler(this.SerializationButton_Click);
            // 
            // ViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 734);
            this.Controls.Add(this.SerializationButton);
            this.Controls.Add(this.DeSerializationButton);
            this.Controls.Add(this.ResultTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewReportForm";
            this.Text = "ViewReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.Button DeSerializationButton;
		private System.Windows.Forms.Button SerializationButton;
	}
}