using Microsoft.AspNetCore.Mvc;
using zooma_api.Controllers;

namespace UnitTest
{
    public class IsValidDateUnitTest
    {
        private DateTimeTrackerController _dateTimeTracker;

        [SetUp]
        public void SetUp()
        {
            _dateTimeTracker = new DateTimeTrackerController();
        }
        [Test]

        public void IsValidDate_InputIsDay20Month1Year2000_Return200()
        {
            // ARRANGE
            var day = 20;
            var month = 1;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as OkObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(200, RequestResult.StatusCode);
        }
        [Test]

        public void IsValidDate_InputIsDay31Month4Year2005_Return400()
        {
            // ARRANGE
            var day = 31;
            var month = 4;
            var year = 2005;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay29Month2Year2000_Return200()
        {
            // ARRANGE
            var day = 29;
            var month = 2;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as OkObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(200, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay29Month2Year1900_Return400()
        {
            // ARRANGE
            var day = 29;
            var month = 2;
            var year = 1900;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }

        [Test]
        public void IsValidDate_InputIsDay29Month2Year2004_Return200()
        {
            // ARRANGE
            var day = 29;
            var month = 2;
            var year = 2004;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as OkObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(200, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay30Month2Year2004_Return400()
        {
            // ARRANGE
            var day = 30;
            var month = 2;
            var year = 2004;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay31Month12Year2000_Return200()
        {
            // ARRANGE
            var day = 31;
            var month = 12;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as OkObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(200, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay32Month8Year2000_Return400()
        {
            // ARRANGE
            var day = 32;
            var month = 8;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay20MonthMinus1Year2000_Return400()
        {
            // ARRANGE
            var day = 20;
            var month = -1;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDayMinus20Month1Year2000_Return400()
        {
            // ARRANGE
            var day = -20;
            var month = 1;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }

        [Test]
        public void IsValidDate_InputIsDayMinus20MonthMinus1Year2000_Return400()
        {
            // ARRANGE
            var day = -20;
            var month = -1;
            var year = 2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }
        [Test]
        public void IsValidDate_InputIsDay20Month1YearMinus2000_Return400()
        {
            // ARRANGE
            var day = 20;
            var month = 1;
            var year = -2000;

            //ACT
            var result = _dateTimeTracker.IsValidDate(day, month, year);
            var RequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(RequestResult);
            Assert.AreEqual(400, RequestResult.StatusCode);
        }
    }

}

