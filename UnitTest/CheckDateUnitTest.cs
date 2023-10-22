using Microsoft.AspNetCore.Mvc;
using zooma_api.Controllers;

namespace UnitTest
{
    public class CheckDateUnitTest
    {
        private DateTimeTrackerController _dateTimeTracker;

        [SetUp]
        public void SetUp()
        {
            _dateTimeTracker = new DateTimeTrackerController();
        }

        [Test]
        public void CheckDate_InputIsDay29Month1Year2000_Return200()
        {
            // ARRANGE
            var day = 29;
            var month = 1;
            var year = 2000;

            // ACT
            var result = _dateTimeTracker.CheckDate(new zooma_api.DTO.DateTimeBody
            {
                day = day,
                month = month,
                year = year
            });
            var okResult = result as OkObjectResult;


            // ASSERT
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [Test]
        public void CheckDate_InputIsDay31Month4Year2004_Return400()
        {
            // ARRANGE
            var day = 31;
            var month = 4;
            var year = 2004;

            // ACT
            var result = _dateTimeTracker.CheckDate(new zooma_api.DTO.DateTimeBody
            {
                day = day,
                month = month,
                year = year
            });
            var badRequestResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }

        [Test]
        public void CheckDate_InputIsDay31Month12Year2004_Return200()
        {
            // ARRANGE
            var day = 31;
            var month = 12;
            var year = 2004;

            // ACT
            var result = _dateTimeTracker.CheckDate(new zooma_api.DTO.DateTimeBody
            {
                day = day,
                month = month,
                year = year
            });
            var okResult = result as OkObjectResult;

            // ASSERT
            //  Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [Test]
        public void CheckDate_InputIsDay31Month0Year2004_Return400()
        {
            // ARRANGE
            var day = 31;
            var month = 0;
            var year = 2004;

            // ACT
            var result = _dateTimeTracker.CheckDate(new zooma_api.DTO.DateTimeBody
            {
                day = day,
                month = month,
                year = year
            });
            var brResult = result as BadRequestObjectResult;

            // ASSERT
            Assert.IsNotNull(brResult);
            Assert.AreEqual(400, brResult.StatusCode);
        }

        [Test]
        public void CheckDate_InputIsDay29Month2Year2004_Return200()
        {
            // ARRANGE
            var day = 29;
            var month = 2;
            var year = 2004;

            // ACT
            var result = _dateTimeTracker.CheckDate(new zooma_api.DTO.DateTimeBody
            {
                day = day,
                month = month,
                year = year
            });
            var okResult = result as OkObjectResult;

            // ASSERT
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [Test]
        public void CheckDate_InputIsDay20Month2YearMinus1_Return400()
        {
            // ARRANGE
            var day = 20;
            var month = 2;
            var year = -1;

            // ACT
            var result = _dateTimeTracker.CheckDate(new zooma_api.DTO.DateTimeBody
            {
                day = day,
                month = month,
                year = year
            });
            var brResult = result as OkObjectResult;

            // ASSERT
            Assert.IsNotNull(brResult);
            Assert.AreEqual(400, brResult.StatusCode);
        }
    }
}
