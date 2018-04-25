using _03_IncreaseCounterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace _03_IncreaseCounterServiceTests
{
    public class IncreaseCounterServiceTests
    {
        [Fact]
        public void IncreaseCounterMethod_SmallerThanThree_NoCounterIncrease()
        {
            var service = new IncreaseCounterService();
            service.IncreaseCounters(1);

            Assert.AreEqual(0, service.First);
            Assert.AreEqual(0, service.Second);
            Assert.AreEqual(0, service.Third);
        }

        [Fact]
        public void IncreaseCounterMethod_Between3And5_FirstIncreases()
        {
            var service = new IncreaseCounterService();
            service.IncreaseCounters(4);

            Assert.AreEqual(1, service.First);
            Assert.AreEqual(0, service.Second);
            Assert.AreEqual(0, service.Third);
        }

        [Fact]
        public void IncreaseCountermethod_Between5And7_SecondIncreases()
        {
            var service = new IncreaseCounterService();
            service.IncreaseCounters(6);

            Assert.AreEqual(0, service.First);
            Assert.AreEqual(1, service.Second);
            Assert.AreEqual(0, service.Third);
        }

        [Fact]
        public void IncreasedCounterMethod_Above7_ThirdIncreases()
        {
            var service = new IncreaseCounterService();
            service.IncreaseCounters(10);

            Assert.AreEqual(0, service.First);
            Assert.AreEqual(0, service.Second);
            Assert.AreEqual(1, service.Third);
        }
    }
}
