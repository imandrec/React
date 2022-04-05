using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
	[Serializable]
	public class Date
	{
		public string DateInString { get; set; }

		public DateTime DateInTrueFormat { get; set; }

		public DateTime DateParsing(string dateInString)
		{
			DateTime date = Convert.ToDateTime(dateInString, CultureInfo.InvariantCulture);

			return date.Date;
		}
	}
}
