using System;
using System.ComponentModel;

namespace PalindromeChecker
{
    public class Error
    {
        const string notValid = "";

        public enum EnumErrors
        {
            [Description("This is not a valid string")]
            NotValid = 0,

            [Description("Error: ")]
            GenericErrorLog = 1
        }

        
        public static string GetDescription(EnumErrors enumerationValue)
        {
            var type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type", nameof(enumerationValue));
            }
            var memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return enumerationValue.ToString();
        }


        public void DisplayError(EnumErrors error, string errorString = "")
        {
            Console.WriteLine(GetDescription(error) + errorString);
        }
    }
}
