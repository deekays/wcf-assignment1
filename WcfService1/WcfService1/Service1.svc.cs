using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string htmlOut(string tag, string data)
        {
            string output = $"<{tag}>{data}</{tag}>";
            return output;
        }

        public string isPrime(int num)
        {
            bool prime = true;
            string output;
            if(num == 1)
            {
                prime = false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                }
            }

            if (prime)
            {
                output = "prime number";
            }
            else
            {
                output = "not prime number";
            }
            return output;

        }

        public string reverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public string sortNums(string sort, string nums)
        {
            string[] stringArray = nums.Split(',');
            int[] intArray = Array.ConvertAll(stringArray, s=>int.Parse(s));
            if(sort.ToUpper() == "A")
            {
                Array.Sort(intArray);
            }
            else if(sort.ToUpper() == "D")
            {
                Array.Sort(intArray);
                Array.Reverse(intArray);
            }

            string output = String.Join(",", intArray);
            return output;
        }

        public int sumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
