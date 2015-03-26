using System;
using wcf_29132014.com.hotschedules.services;

namespace wcf_29132014
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SalesItemServiceService();
            var date = ToSimpleDate(new DateTime());
            client.setSalesItemsV3(1, 1, null, date, date);
        }

        static hsSimpleDate ToSimpleDate(DateTime time)
        {
            return new hsSimpleDate
            {
                year = time.Year,
                month = time.Month,
                day = time.Day,
            };
        }
    }
}
