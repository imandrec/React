using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
	[Serializable]
	public class ReportElements
	{
		//short term moving averages
		public decimal ST_MovingAverage { get; set; } = 0;

		//long term moving averages
		public decimal LT_MovingAverage { get; set; } = 0;

		//corresponding date of short term or long term moving average
		public Date date { get; set; }

		public string Ticker { get; set; }

		//for header row
		public string[] Headers { get; set; }
	}
}
