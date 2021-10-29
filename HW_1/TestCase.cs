using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
	public class TestCase
	{
        public ulong X { get; set; }
        public ulong Expected { get; set; }
        public Exception ExpectedException { get; set; }

        public void TestSum(TestCase testCase)
        {
            if (testCase.Expected == Expected)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine($"{testCase.ExpectedException}");
            }
        }
    }

    
}
