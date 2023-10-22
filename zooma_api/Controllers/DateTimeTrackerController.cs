using Microsoft.AspNetCore.Mvc;
using zooma_api.DTO;

namespace zooma_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeTrackerController : ControllerBase
    {
        [HttpPost]
        [Route("date-time-tracker")]
        public IActionResult CheckDate(DateTimeBody dateTime)
        {
            return IsValidDate(dateTime.day, dateTime.month, dateTime.year);
        }

        public int DaysInMonth(int year, int month)
        {
            int[] monthHas31 = { 1, 3, 5, 7, 8, 10, 12 };
            int[] monthHas30 = { 4, 6, 9, 11 };

            if (monthHas31.Contains(month))
            {
                return 31;
            }
            else if (monthHas30.Contains(month))
            {
                return 30;
            }
            else if (month == 2)
            {
                if (year % 400 == 0) return 29;
                else if (year % 100 == 0) return 28;
                else if (year % 4 == 0) return 29;
                else return 28;
            }
            else
            {
                return 0;
            }
        }
        public IActionResult IsValidDate(int day, int month, int year)
        {
            if (month >= 1 && month < 12)
            {
                if (day >= 0)
                {
                    if (day <= DaysInMonth(year, month))
                    {
                        return Ok($"{year}/{month}/{day} is a valid date!");
                    }
                    else return BadRequest("Day exceeds max days in month!");
                }
                else return BadRequest("Date cannot below 1!");
            }
            else return BadRequest("Invalid month!");
        }
    }
}