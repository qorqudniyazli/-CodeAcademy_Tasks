namespace Enum;
using Enum_Task.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Enum_Task.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var properties = typeof(ShippingStatus).GetFields();
        foreach (var prop in properties)
        {
            var dd = prop.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
            if (dd != null)
            {
                Console.WriteLine(prop.Name + " --> " + dd.Name);
            }
        }

        //------------[Flags]-------------//


        Console.WriteLine(
             "\n\nAll possible combinations of values without FlagsAttribute:");
        for (int val = 0; val <= 16; val++)
            Console.WriteLine("{0,3} - {1:G}", val, (SingleHue)val);

        //with  [Flags]
        Console.WriteLine(
             "\nAll possible combinations of values with FlagsAttribute:");
        for (int val = 0; val <= 16; val++)
            Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);
    }
}
