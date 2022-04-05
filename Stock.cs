using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
	[Serializable]
	public class Stock
	{
		public Date Date { get; set; }
		public decimal Open { get; set; }
		public decimal Highest { get; set; }
		public decimal Lowest { get; set; }
		public decimal Close { get; set; }
		public decimal Adjusted { get; set; }
		public decimal Volume { get; set; }

		//for header row
		public string[] Headers { get; set; }

		public decimal GetColumnName(string headerColumnName)
		{
			if (headerColumnName.ToLower() == "Open".ToLower())
			{
				return Math.Truncate(this.Open * 100) / 100; ;
			}

			else if (headerColumnName.ToLower() == "Close".ToLower())
			{
				return Math.Truncate(this.Close * 100) / 100; ;
			}

			else if (headerColumnName.ToLower() == "High".ToLower())
			{
				return Math.Truncate(this.Highest * 100) / 100;
			}

			else if (headerColumnName.ToLower() == "Low".ToLower())
			{
				return Math.Truncate(this.Lowest * 100) / 100; ;
			}

			else if (headerColumnName.ToLower() == "Adj Close".ToLower())
			{
				return Math.Truncate(this.Adjusted * 100) / 100; ;
			}

			else if (headerColumnName.ToLower() == "Volume".ToLower())
			{
				return this.Volume;
			}

			return 0;
		}
	}
}
