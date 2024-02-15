using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Controller
{
    internal class DateTimeController
    {
        private static DateTimeController instance;
        public static DateTimeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DateTimeController();
                }
                return instance;
            }
        }

        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public DateTime SetDateTime (DateTime dateTime)
        {
            return dateTime;
        }

        public DateTime AddDays(DateTime dateTime, int days)
        {
            return dateTime.AddDays(days);
        }

        

    }
}
