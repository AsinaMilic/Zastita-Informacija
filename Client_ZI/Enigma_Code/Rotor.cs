using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine.Code
{
    //This class represents the information one rotor holds.
    class Rotor 
    {
        protected const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        
        private int outerPosition;
        public char OuterChar { get; set; }

     
        private string wiring;

     
        protected char turnOver;

     
        public string name { get; }


        public char ring { get; set; }

        public int[] map { get; }
        public int[] revMap { get; }

   
        public Rotor(string w, char to, string n)
        {
            
            turnOver = to;
            outerPosition = 0;

            ring = 'A'; 
            name = n; 

            map = new int[26];
            revMap = new int[26];

            setWiring(w);
        }

        private void setWiring(string wiring)
        {
           
            this.wiring = wiring;

            OuterChar = wiring.ToCharArray()[outerPosition];

           
            for (int i = 0; i < 26; i++)
            {
                
                int match = ((int)wiring.ToCharArray()[i]) - 65;
                
            
                map[i] = (26 + match - i) % 26;
                revMap[match] = (26 + i - match) % 26;
            }
        }

       
        public void setOuterPosition(int i)
        {
            outerPosition = i;
            OuterChar = alphabet.ToCharArray()[outerPosition];
        }

      
        public int getOuterPosition()
        {
            return outerPosition;
        }

        public void setOuterChar(char c)
        {
            OuterChar = c;
            outerPosition = alphabet.IndexOf(OuterChar);
        }

       
        public void step()
        {
            outerPosition = (outerPosition + 1) % 26;
            OuterChar = alphabet.ToCharArray()[outerPosition];
        }

       
        public virtual bool isInTurnOver()
        {
            return OuterChar == turnOver;
        }
    }
}
