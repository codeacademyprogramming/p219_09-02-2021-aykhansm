using System;
using System.Collections.Generic;

namespace _09022021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student ayxanism = new Student();
            //ayxanism.AddExercise("tarix", 85);
            //ayxanism.AddExercise("riyaziyyat", 90);
            //Console.WriteLine(ayxanism.FindExerciseAverage());
            string YorN;
            string amountStr;
            double amount;
            bool IsWantsOrNot;
            string AddAnotherPayment;
            List<Payment> list1 = new List<Payment>();

            do
            {
                do
                {
                    Console.Write("Odenis meblegini daxil edin:  ");
                    amountStr = Console.ReadLine();
                    amountStr = amountStr.Trim();
                } while (!double.TryParse(amountStr, out amount));
                do
                {
                    Console.Write("Odenisi odemek isteyirsinizmi? y/n ");
                    YorN = Console.ReadLine();
                    YorN = YorN.Trim();
                } while (YorN.ToLower() != "y" && YorN.ToLower() != "n");
                if (YorN.ToLower() == "y")
                {
                    IsWantsOrNot = true;
                }
                else
                {
                    IsWantsOrNot = false;
                }
                Payment newpayment = new Payment(amount,IsWantsOrNot);

                list1.Add(newpayment);
                do
                {
                    Console.Write("Yeni payment yaratmaq isteyirsinizmi ? y/n");
                    AddAnotherPayment = Console.ReadLine();
                    AddAnotherPayment = AddAnotherPayment.Trim();
                } while (AddAnotherPayment.ToLower() != "y" && AddAnotherPayment.ToLower() != "n");


            } while (AddAnotherPayment.ToLower() == "y");
            Console.WriteLine(CalculatedUnpaidPAyments(list1));
        }

        public static double CalculatedUnpaidPAyments(List<Payment> list1)
        {
            double sum = 0;
            foreach(Payment item in list1)
            {
                if (item.IsPaid== false)
                {
                    sum += item.Amount;
                }
            }
            return sum;
        }
    }
}