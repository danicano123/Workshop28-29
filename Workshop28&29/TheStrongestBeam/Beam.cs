namespace TheStrongestBeam
{
    public class Beam
    {

        private String _Beam;
        public Beam(String beam)
        {
            _Beam = beam;
        }

        public Boolean DataValidation()
        {
            bool containsValidChars = _Beam.All(c => "%&#=*".Contains(c));
            bool containsOnlyValidChars = _Beam.Length == _Beam.Count(c => "%&#=*".Contains(c));

            if (containsValidChars && containsOnlyValidChars)
            {
                return true;
            }
            return false;
        }

        public Boolean PlatformValidation()
        {
            String[] subString = _Beam.Split("+");
            for (int i = 0; i <= subString.Length - 1; i++)
            {
                if (subString[i].Length == 2 && subString[i].Length == 3)
                {
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

        public Boolean BasesValidation()
        {
            if (_Beam[0].Equals((char)35) || _Beam[0].Equals((char)37) || _Beam[0].Equals((char)38))
            {
                return true;
            }
            return false;
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