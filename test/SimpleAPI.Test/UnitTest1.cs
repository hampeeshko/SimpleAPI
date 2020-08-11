using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void Something()
        {
            var returnValue = controller.Get().Count();
            Assert.Equal(5, returnValue);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
