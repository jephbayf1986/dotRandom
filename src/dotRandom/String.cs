using System;
using System.Linq;
using System.Text;

namespace dotRandom
{
    public static partial class DotRandom
    {
        /// <summary>
        /// Random String
        /// </summary>
        /// <param name="length">Length of Output String (Default 50)</param>
        /// <returns>A string comprimising randomized A-z characters</returns>
        public static string RandomString(int length = 50)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var random = new Random();

            return new string(Enumerable.Repeat(chars + chars.ToLower(), length)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());

        }

        /// <summary>
        /// Random First Name
        /// </summary>
        /// <returns>A random from a list of first names</returns>
        public static string RandomFirstName()
        {
            var randomIndex = RandomIntBetween(0, _FirstNames.Length);

            return _FirstNames[randomIndex];
        }

        /// <summary>
        /// Random Last Name
        /// </summary>
        /// <returns>A random from a list of last/family names</returns>
        public static string RandomLastName()
        {
            var randomIndex = RandomIntBetween(0, _LastNames.Length);

            return _LastNames[randomIndex];
        }

        /// <summary>
        /// Random Full Name
        /// </summary>
        /// <returns>A random from a list of first and last/family names with a space between</returns>
        public static string RandomFullName()
        {
            return RandomFirstName() + " " + RandomLastName();
        }

        /// <summary>
        /// Random User Name
        /// </summary>
        /// <returns>A random from a list of first and last/family names with no space</returns>
        public static string RandomUserName()
        {
            return RandomFirstName() + RandomLastName();
        }

        /// <summary>
        /// Random Email Address
        /// </summary>
        /// <returns>A random from a email address from a list of first, last names and domains</returns>
        public static string RandomEmail()
        {
            var randomIndex = RandomIntBetween(0, _EmailDomains.Length);

            return RandomUserName().ToLower() + "@" + _EmailDomains[randomIndex];
        }

        /// <summary>
        /// Lorem Ipsum Text
        /// </summary>
        /// <param name="maxLength">Length of Output String</param>
        /// <returns>A lorem ipsum style sentence or group of sentences</returns>
        public static string LoremIpsumText(int maxLength = 444)
        {
            var stringBuilder = new StringBuilder();

            var approxSentences = Math.Ceiling(((decimal)maxLength) / 100);
            
            for (int i = 0; i < approxSentences; i++)
            {
                switch (i % 4) 
                {
                    case 0:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance1));
                        break;
                    case 1:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance2));
                        break;
                    case 2:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance3));
                        break;
                    default:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance4));
                        break;
                }

                if (stringBuilder.Length > maxLength)
                {
                    stringBuilder.Remove(maxLength, stringBuilder.Length - maxLength);

                    return stringBuilder.ToString();
                }
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Lorem Ipsum Sentences
        /// </summary>
        /// <param name="numberOfSentences">Length of Output String</param>
        /// <returns>A random from a list of last/family names</returns>
        public static string LoremIpsumSentences(int numberOfSentences = 1)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < numberOfSentences; i++)
            {
                switch (i % 4)
                {
                    case 0:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance1));
                        break;
                    case 1:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance2));
                        break;
                    case 2:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance3));
                        break;
                    default:
                        stringBuilder.Append(string.Join(" ", _LoremIpsumSentance4));
                        break;
                }
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Random Upper Case String
        /// </summary>
        /// <param name="length">Length of Output String (Default 50)</param>
        /// <returns>A string comprimising randomized A-Z characters</returns>
        public static string RandomUpperCaseString(int length = 50)
        {
            return RandomString(length).ToUpper();
        }

        /// <summary>
        /// Random Lower Case String
        /// </summary>
        /// <param name="length">Length of Output String (Default 50)</param>
        /// <returns>A string comprimising randomized a-z characters</returns>
        public static string RandomLowerCaseString(int length = 50)
        {
            return RandomString(length).ToLower();
        }

        private static readonly string[] _LoremIpsumSentance1 =
        {
            "Lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit,",
            "sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore", "et", 
            "dolore", "magna", "aliqua. "
        };

        private static readonly string[] _LoremIpsumSentance2 =
        {
            "Ut", "enim", "ad", "minim", "veniam,", "quis", "nostrud", "exercitation", 
            "ullamco", "laboris", "nisi", "ut", "aliquip", "ex", "ea", "commodo", "consequat. "
        };

        private static readonly string[] _LoremIpsumSentance3 =
        {
            "Duis", "aute", "irure", "dolor", "in", "reprehenderit", "in", "voluptate", 
            "velit", "esse", "cillum", "dolore", "eu", "fugiat", "nulla", "pariatur. "
        };

        private static readonly string[] _LoremIpsumSentance4 =
        {
            "Excepteur", "sint", "occaecat", "cupidatat", "non", "proident,", "sunt", 
            "in", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id", "est", 
            "laborum. "
        };

        private static readonly string[] _FirstNames =
        {
            "Alexander", "Belinda", "Candy", "Chloe", "Danny", "Delphine", "Didier",
            "Edmond", "Emily", "Freddy", "Gabriella", "George", "Gerald", "Joey",
            "Kylie", "Lottie", "Lorenzo", "Mandy", "Molly", "Pandora", "Pedro",
            "Peggi", "Penny", "Rebecca", "Richard", "Robbie", "Rohan", "Rosie",
            "Simon", "Suzy", "Wendy", "Zaza", "Zoe", "Zuzu"
        };

        private static readonly string[] _LastNames =
        {
            "Bernard", "Brown", "Davis", "Dekker", "Diaz", "Doyle", "Ferrari", 
            "Fischer", "Garcia", "Hernandez", "Jones", "Johnson", "Kahn", "Kumar", 
            "Larsen", "Lee", "Lukic", "Martin", "Miller", "Müller", "Muhammed", 
            "Nielsen", "O'Brien", "Petit", "Quinn", "Robert", "Rodriguez", "Russo", 
            "Singh", "Smith", "Schwarz", "Thomas", "Van Dyk", "Wagner", "Williams"
        };

        private static readonly string[] _EmailDomains =
        {
            "gmail.com", "outlook.com", "hotmail.com", "live.com", "yahoo.com",
            "aol.com", "comcast.net", "icloud.com", "proton.me", "zoho.com"
        };
    }
}