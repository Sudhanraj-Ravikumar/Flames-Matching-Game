using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlamesGame
{
    public class MatchingLogic
    {
        private string _x;
        private string _y;
        List<char> flames = new List<char>() { 'f', 'l', 'a', 'm', 'e', 's' };
        string X { get => _x; set => _x = value; }
        string Y { get => _y; set => _y = value; }
        
        public string GetString(string x,string y)
        {
            x = X;
            y = Y;
            return x + y;
        }

        
        public string GetMatchingResult(string YourName,string PartnerName)
        {
            
            string result ;
            
            int count;
            char[] YourNameArray = YourName.ToCharArray();
            char[] PartnerNameArrary = PartnerName.ToCharArray();

            
            count = GetmatchedLetterCount(YourNameArray, PartnerNameArrary);
            return result = GetFlamesResultant(count);


        }


        private string GetFlamesResultant(int count)
        {
            List<char> Flames = flames;

            if (count>5)
            {
                int mod = (int)Math.Floor((decimal)(count / 6));
                return flames[mod].ToString(); 
            }
            return flames[count].ToString();
        }

        private int GetmatchedLetterCount(char[] MyName,char[] LastName)
        {
            List<char> myname =MyName.ToList();
            List<char>lastname =  LastName.ToList();
            int counter = 0;
            for (int i = 0; i < myname.Count; i++)
            {

                if (lastname?.Count!=0)
                {
                    for (int j = 0; j < lastname.Count; j++)
                    {
                        if (myname[i] == lastname[j])
                        {
                            counter++;
                            lastname.Remove(lastname[j]);
                            lastname.TrimExcess();
                            break;
                        }

                    }
                }
            }
            return counter;
        }
    }
}
