using System.Reflection.Metadata.Ecma335;

namespace MadisonBridges
{
    public class Bridges
    {
        private String _bridge;

        public Bridges(String bridge)
        {
            _bridge = bridge;
        }

        // Validations


        public Boolean DataValidation()
        {
            bool containsValidChars = _bridge.All(c => "=+*".Contains(c));
            bool containsOnlyValidChars = _bridge.Length == _bridge.Count(c => "=+*".Contains(c));

            if (containsValidChars && containsOnlyValidChars)
            {
                return true;
            }
            return false;
        }
        public Boolean BasesValidation()
        {
            if (_bridge[0].Equals((char)42) && _bridge[_bridge.Length - 1].Equals((char)42))
            {
                return true;
            }
            return false;
        }

        public Boolean PlatformValidation()
        {
            String[] subString = _bridge.Split("+");
            for (int i = 0; i <= subString.Length - 1; i++)
            {
                if (subString[i].Length == 2 && subString[i].Length == 3)
                {
                    Console.WriteLine("wtf");
                    return false;
                }
                if (subString.Length % 2 == 0)
                {
                    for (int j = 1; j <= subString.Length - 2; j++)
                    {
                        if (subString[j].Length != 2)
                        {
                            return false;
                        }
                    }

                }
                else if (subString[(int)((double)subString.Length / 2 - 0.5)].Length != 2 && subString[(int)((double)subString.Length / 2 - 0.5)].Length != 3)
                {
                    return false;
                }

            }
            return true;
        }

        public Boolean IsValid()
        {
            if (BasesValidation() && DataValidation() && PlatformValidation())
            {
                return true;
            }

            return false;
        }

    }
}