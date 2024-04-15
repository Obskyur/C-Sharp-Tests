using System.Globalization;
using System.Linq;

namespace Test_JadenCasing
{
    internal static class JadenCase
    {
        public static string ToJadenCase(this string phrase) => 
            // Using Linq:
            String.Join(" ", phrase.Split().Select(word => Char.ToUpper(word[0]) + word[1..]));

            // Using CultureInfo:
            // return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }
}
