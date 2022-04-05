using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
	public class MethodsForGui
	{
		public List<Stock> ReadDataFromFile(string fileName)
		{
			//Here data from file will be stored
			List<Stock> stocks = new List<Stock>();

			//all lines of file are read
			string[] csvRows = File.ReadAllLines(fileName);

			//storing lines to stock variable
			for (int i = 0; i < csvRows.Length; i++)
			{
				//Temp Stock variable to get data from csv
				//and stores to Stocks variable
				Stock stock = new Stock();

				//spliting rows through comma delimiter
				string[] row = null;
				if (csvRows[i] != null)
				{
					row = csvRows[i].Split(',');
				}

				//Handling Header Row
				if (i == 0)
				{
					stock.Headers = row;
					stocks.Add(stock);
					continue;
				}

				//data to variables
				//1. date conversion and storing
				Date date = new Date();
				date.DateInString = row[0];
				date.DateInTrueFormat = date.DateParsing(date.DateInString);
				stock.Date = date;

				//2. Open column from csv
				stock.Open = Convert.ToDecimal(row[1]);

				//3. High Column from csv
				stock.Highest = Convert.ToDecimal(row[2]);

				//4. Low Column from csv
				stock.Lowest = Convert.ToDecimal(row[3]);

				//5. Close column from csv
				stock.Close = Convert.ToDecimal(row[4]);

				//6. AdjClose Column from csv
				stock.Adjusted = Convert.ToDecimal(row[5]);

				//7. Volume Column from csv
				stock.Volume = Convert.ToDecimal(row[6]);

				//storing above data from temp variable 
				//to stocks variable list
				stocks.Add(stock);
			}

			return stocks;
		}

		public List<ReportElements> ST_LTMovingAverages(List<Stock> stocks)
		{
			List<ReportElements> Reports = new List<ReportElements>();

			//adding header row
			ReportElements header = new ReportElements();
			header.Headers = new string[4] { "Ticker", "Date", "ShortTermMovingAverage", "LongTermMovingAverage" };

			//for header row
			Reports.Add(header);

			//finding st and lt moving averages for all of the stock
			//i = 1 because header is added already
			for (int i = 1; i < stocks.Count; i++)
			{
				ReportElements report = new ReportElements();

				//adding ticker for each
				report.Ticker = "FB";

				//Adding Date
				report.date = stocks[i].Date;

				//short term moving average for ith date or location of stocks
				report.ST_MovingAverage = ST_LT_Avg(stocks, i, 20);

				//long term moving average for i th date or location in stocks
				report.LT_MovingAverage = ST_LT_Avg(stocks, i, 50);

				Reports.Add(report);
			}

			return Reports;
			//undone way
			{
				//decimal tempSTAvg = 0;
				//int countST = 1;

				//decimal tempLTAvg = 0;
				//int countLT = 1;

				////going through each stock item
				//for (int i = 0; i < stocks.Count; i++)
				//{
				//	//ignoring header
				//	if (i == 0)
				//	{
				//		continue;
				//	}

				//	else
				//	{
				//		//if i has skipped the 19 items
				//		if (i > 19)
				//		{
				//			MovingAverage averages = new MovingAverage();

				//			//going back for 20 items
				//			for (int j = i; j > 0 ; j--)
				//			{
				//				tempSTAvg += stocks[j].Close;
				//				tempLTAvg += stocks[j].Close;

				//				if (countST == 20)
				//				{
				//					averages.ST_MovingAverage = tempSTAvg / 20;
				//					averages.date = stocks[i].Date;

				//					MovingAverages.Add(averages);
				//					tempSTAvg = 0;
				//					countST = 1;
				//					break;
				//				}

				//				countST++;


				//				if (i > 49)
				//				{ 
				//					averages.LT_MovingAverage = tempLTAvg / 50;
				//					averages.date = stocks[i].Date;

				//					if (countLT == 50)
				//					{
				//						MovingAverages.Add(averages);
				//						tempLTAvg = 0;
				//						countLT = 1;
				//						break;
				//					}

				//					countLT++;
				//				}
				//			}
				//		}
				//	}
				//}

				//return MovingAverages;
			}
		}

		//this method will find only 20 days moving average for given data of stocks
		private decimal ST_LT_Avg(List<Stock> stocks, int location, int avgMode)
		{
			//checking if i is less than 20
			if (location >= 1 && location <= avgMode)
			{
				return 0;
			}

			else if (location >= avgMode+1)
			{
				//starting point 
				int startIndex = location - avgMode;
				int endIndex = location;
				decimal tempSum = 0;

				for (int i = startIndex; i < endIndex; i++)
				{
					tempSum += stocks[i].Close;
				}

				return tempSum / avgMode;
			}

			return 0;
		}
	}
}
