namespace Tyuiu.KrasyukME.Sprint0.task2.V0.Test
{
    using Tyuiu.KrasyukME.Sprint0.Task2.V0.Lib;
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Мария";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Мария", res);
        }
    }
}