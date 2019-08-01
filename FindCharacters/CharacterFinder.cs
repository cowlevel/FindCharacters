namespace FindCharacters
{
    public class CharacterFinder
    {
        public CharacterFinder()
        {

        }

        public string WordsInput { get; set; }

        public char CharacterInput { get; set; }

        public int CharacterCount
        {
            get
            {
                int numChar = 0;

                foreach (char c in WordsInput)
                {
                    if (c == CharacterInput)
                    {
                        numChar++;
                    }
                }

                return numChar;
            }

            private set {}
        }
    }
}