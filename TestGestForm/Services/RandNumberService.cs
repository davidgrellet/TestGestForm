using System;
using System.Collections.Generic;
using System.Linq;
using TestGestForm.Interfaces;

namespace TestGestForm.Services
{
    public class RandNumberService : IRandNumberService
    {
        public List<string> GetRandNumberList()
        {
            return CreateList().Select(x => CheckShort(x)).ToList();
        }
        public List<short> CreateList()
        {
            Random randNumber = new Random();
            int multiplyingFactor = randNumber.Next(2001);
            List<short> numberList = new List<short>();
            for (int i = 0; i <= multiplyingFactor; i++)
            {
                numberList.Add(Convert.ToInt16(randNumber.Next(-1000, 1001)));
            }
            return numberList;
        }
        public string CheckShort(short number)
        {
            if(number % 3 == 0 && number % 5 == 0)
            {
                return "Gestform";
            }
            if(number % 3 == 0)
            {
                return "Gest";
            }
            if(number % 5 == 0)
            {
                return "Form";
            }
            return number.ToString();
        }
    }
}