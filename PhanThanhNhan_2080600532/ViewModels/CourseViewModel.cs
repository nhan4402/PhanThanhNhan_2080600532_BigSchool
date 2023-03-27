using PhanThanhNhan_2080600532.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PhanThanhNhan_2080600532.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            DateTime dateValue;
            if (!DateTime.TryParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
            {
                throw new ArgumentException("Invalid Date format");
            }

            DateTime timeValue;
            if (!DateTime.TryParseExact(Time, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeValue))
            {
                throw new ArgumentException("Invalid Time format");
            }

            return dateValue.Date + timeValue.TimeOfDay;
        }

    }
}