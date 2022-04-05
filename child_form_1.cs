using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
	public partial class NewSimulationForm : Form
	{
		List<Stock> stocksTemp = new List<Stock>();
		string filePath = "";

		List<ReportElements> AllReports = new List<ReportElements>();

		public NewSimulationForm()
		{
			InitializeComponent();

			InitialSettings();
		}

		void ShowResultInTextBox(List<Stock> stocks)
		{
			//unable use \n with textboxes
			//string newLine = Environment.NewLine;

			MethodsForGui methodsForGui = new MethodsForGui();

			stocksTemp = methodsForGui.ReadDataFromFile(filePath);

			string newLine = Environment.NewLine;
			//all data 
			for (int i = 0; i < stocksTemp.Count; i++)
			{
				//printing header
				if (i == 0)
				{
					//formating and indenting
					string r = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}{4,-10}{5,-13}{6,-10}",
											 stocksTemp[i].Headers[0],
											 stocksTemp[i].Headers[1],
											 stocksTemp[i].Headers[2],
											 stocksTemp[i].Headers[3],
											 stocksTemp[i].Headers[4],
											 stocksTemp[i].Headers[5],
											 stocksTemp[i].Headers[6]);


					//printing lheader
					ResultTextBox.AppendText(r + newLine);
					continue;
				}

				//printing other rows
				else
				{
					//formatting and indenting
					string r = string.Format("{0,-12}{1,-10:F2}{2,-10:F2}{3,-10:F2}{4,-10:F2}{5,-13:F2}{6,-10}",
						stocksTemp[i].Date.DateInString,
						stocksTemp[i].Open,
						stocksTemp[i].Highest,
						stocksTemp[i].Lowest,
						stocksTemp[i].Close,
						stocksTemp[i].Adjusted,
						stocksTemp[i].Volume);
					//printing lheader
					ResultTextBox.AppendText(r + newLine);
				}
			}
		}

		private void InitialSettings()
		{
			LoadDataButton.Enabled = false;
			CalculateMovingAveragesButton.Enabled = false;
			ViewReportButton.Enabled = false;

			InputFileNameTextBox.Enabled = false;
			ResultTextBox.ReadOnly = true;
		}

		private void SelectFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();

			fileDialog.Title = "Browse for File";
			fileDialog.Multiselect = false;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = InputFileNameTextBox.Text = fileDialog.FileName;

				LoadDataButton.Enabled = true;
			}
		}

		private void LoadDataButton_Click(object sender, EventArgs e)
		{
			//loading data from file to text box
			ResultTextBox.Text = "";
			ShowResultInTextBox(stocksTemp);

			CalculateMovingAveragesButton.Enabled = true;
		}

		private void CalculateMovingAveragesButton_Click(object sender, EventArgs e)
		{
			//calculating moving averages
			//short term
			MethodsForGui methods = new MethodsForGui();
			AllReports = methods.ST_LTMovingAverages(stocksTemp);

			ViewReportButton.Enabled = true;
		}

		private void ViewReportButton_Click(object sender, EventArgs e)
		{
			ViewReportForm reportForm = new ViewReportForm(AllReports);

			//show dialog show window as child of the given form
			reportForm.ShowDialog(this);
		}
	}

}