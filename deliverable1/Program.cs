using System;

namespace deliverable1
{
    class MainClass
    {
        public static double FindAverageOfThree(double total)
        {
            return total / 3;
        }

        public static double FindMaxOfThree(double a, double b, double c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public static double FindMinOfThree(double a, double b, double c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public static double RoundToTwoDecimals(double amount)
        {
            return Math.Round(amount, 2);
        }

        public static string ConvertToUSDollar(double amount)
        {
            double amountTotal = RoundToTwoDecimals(amount);
            return "$" + amountTotal.ToString("#,##0.00");
        }

        public static string ConvertToKrona(double amount)
        {
            double amountTotal = RoundToTwoDecimals(amount);
            string kronaAmount = amountTotal.ToString("#,##0.00");
            return kronaAmount.Replace(".", ",") + "kr";
        }

        public static string ConvertToYen(double amount)
        {
            double amountTotal = RoundToTwoDecimals(amount) * 100;
            return "￥" + amountTotal.ToString();
        }

        public static string ConvertToBaht(double amount)
        {
            double amountTotal = RoundToTwoDecimals(amount);
            return "฿" + amountTotal.ToString("#,##0.00");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three currency amounts: ");
            Console.WriteLine("First: ");
            double firstAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second: ");
            double secondAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Third: ");
            double thirdAmount = Convert.ToDouble(Console.ReadLine());

            double total = firstAmount + secondAmount + thirdAmount;
            double average = FindAverageOfThree(total);
            double highest = FindMaxOfThree(firstAmount, secondAmount, thirdAmount);
            double lowest = FindMinOfThree(firstAmount, secondAmount, thirdAmount);

            string USTotal = ConvertToUSDollar(total);
            string kronaTotal = ConvertToKrona(total);
            string yenTotal = ConvertToYen(total);
            string bahtTotal = ConvertToBaht(total);

            string USAverage = ConvertToUSDollar(average);
            string kronaAverage = ConvertToKrona(average);
            string yenAverage = ConvertToYen(average);
            string bahtAverage = ConvertToBaht(average);

            string USMax = ConvertToUSDollar(highest);
            string kronaMax = ConvertToKrona(highest);
            string yenMax = ConvertToYen(highest);
            string bahtMax = ConvertToBaht(highest);

            string USMin = ConvertToUSDollar(lowest);
            string kronaMin = ConvertToKrona(lowest);
            string yenMin = ConvertToYen(lowest);
            string bahtMin = ConvertToBaht(lowest);

            Console.WriteLine("Total:");
            Console.WriteLine("-US: " + USTotal);
            Console.WriteLine("-Sweden: " + kronaTotal);
            Console.WriteLine("-Japan: " + yenTotal);
            Console.WriteLine("-Thailand: " + bahtTotal);

            Console.WriteLine("Average:");
            Console.WriteLine("-US: " + USAverage);
            Console.WriteLine("-Sweden: " + kronaAverage);
            Console.WriteLine("-Japan: " + yenAverage);
            Console.WriteLine("-Thailand: " + bahtAverage);

            Console.WriteLine("Maximum:");
            Console.WriteLine("-US: " + USMax);
            Console.WriteLine("-Sweden: " + kronaMax);
            Console.WriteLine("-Japan: " + yenMax);
            Console.WriteLine("-Thailand: " + bahtMax);

            Console.WriteLine("Minimum:");
            Console.WriteLine("-US: " + USMin);
            Console.WriteLine("-Sweden: " + kronaMin);
            Console.WriteLine("-Japan: " + yenMin);
            Console.WriteLine("-Thailand: " + bahtMin);
        }
    }
}
