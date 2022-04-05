using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
	public partial class ViewReportForm : Form
	{
		List<ReportElements> AllReports = new List<ReportElements>();
		public ViewReportForm(List<ReportElements> reports)
		{
			InitializeComponent();

			//if reports are not null
			if (reports != null)
			{
				AllReports= reports;
				showResultInTextBox(reports);
			}
		}

		private void showResultInTextBox(List<ReportElements> reports)
		{
			ResultTextBox.Text = "";

			string newLine = Environment.NewLine;

			//all data 
			for (int i = 0; i < reports.Count; i++)
			{
				//printing header
				if (i == 0)
				{
					//formating and indenting
					string r = string.Format("{0,-12}{1,-12}{2,-25}{3,-49}",
											 reports[i].Headers[0],
											 reports[i].Headers[1],
											 reports[i].Headers[2],
											 reports[i].Headers[3]);


					//printing lheader
					ResultTextBox.AppendText(r + newLine);
					continue;
				}

				//printing other rows
				else
				{
					//formatting and indenting
					string r = string.Format("{0,-12}{1,-12:F2}{2,-25:F2}{3,-49:F2}",
						reports[i].Ticker,
						reports[i].date.DateInString,
						reports[i].ST_MovingAverage,
						reports[i].LT_MovingAverage);
					//printing lheader
					ResultTextBox.AppendText(r + newLine);
				}
			}
		}

		private void SerializationButton_Click(object sender, EventArgs e)
		{
			IFormatter formatter = new BinaryFormatter();
			string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\stockMovingAverage.ser";

			using (Stream stream = new FileStream(currentPath, FileMode.Create, FileAccess.Write))
			{
				stream.Position = 0;
				formatter.Serialize(stream, AllReports);
			}			
		}

		private void DeSerializationButton_Click(object sender, EventArgs e)
		{
			IFormatter formatter = new BinaryFormatter();
			OpenFileDialog fileDialog = new OpenFileDialog();

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string path = fileDialog.FileName;

				Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

				List<ReportElements> reports = new List<ReportElements>();

				reports = (List<ReportElements>)formatter.Deserialize(stream);

				showResultInTextBox(reports);
			}
		}
	}
}
