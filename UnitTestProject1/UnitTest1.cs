using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using laba5; 

namespace laba5.Tests
{
    [TestClass]
    public class DailyReportTests
    {
        [TestMethod]
        public void Test_IndividualProfitCalculation()
        {
            double revenue = 250.50;
            double expenses = 100.20;
            DailyReport report = new DailyReport("Пятница", revenue, expenses);


            double actualProfit = report.Profit;

            double expectedProfit = 150.30;
            Assert.AreEqual(expectedProfit, actualProfit, 0.001, "Расчет чистой прибыли выполнен неверно!");
        }

        [TestMethod]
        public void Test_CalculateWeeklyMetrics_Deviations()
        {
            List<DailyReport> list = new List<DailyReport>
            {
                new DailyReport("Пн", 150, 50),  
                new DailyReport("Вт", 200, 50), 
                new DailyReport("Ср", 100, 80)   
            };

            DailyReport.CalculateWeeklyMetrics(list);

            Assert.AreEqual(10.00, list[0].Deviation, 0.001, "Отклонение для Пн рассчитано неверно!");
            Assert.AreEqual(60.00, list[1].Deviation, 0.001, "Отклонение для Вт рассчитано неверно!");
            Assert.AreEqual(-70.00, list[2].Deviation, 0.001, "Отклонение для Ср рассчитано неверно!");
        }

        [TestMethod]
        public void Test_CalculateWeeklyMetrics_EmptyList_ShouldNotThrow()
        {
            List<DailyReport> emptyList = new List<DailyReport>();

            try
            {
                DailyReport.CalculateWeeklyMetrics(emptyList);
            }
            catch (System.Exception ex)
            {
                Assert.Fail($"Метод упал при обработке пустого списка! Ошибка: {ex.Message}");
            }
        }
    }
}