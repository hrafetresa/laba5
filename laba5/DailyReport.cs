using System;
using System.Collections.Generic;

namespace laba5
{
    public class DailyReport
    {
        private string day; 
        private double revenue; 
        private double expenses; 
        private double deviation; 

        public DailyReport(string day, double revenue, double expenses)
        {
            this.day = day;
            this.revenue = revenue;
            this.expenses = expenses;
            this.deviation = 0.0;
        }

        public string Day => day;
        public double Revenue => revenue;
        public double Expenses => expenses;

        public double Profit => revenue - expenses;

        public double Deviation
        {
            get { return deviation; }
            set { deviation = value; }
        }

        public static void CalculateWeeklyMetrics(List<DailyReport> list)
        {
            if (list == null || list.Count == 0) return;

            double totalProfit = 0;

            for (int i = 0; i < list.Count; i++)
            {
                totalProfit += list[i].Profit;
            }

            double averageProfit = totalProfit / list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Deviation = list[i].Profit - averageProfit;
            }
        }
    }
}