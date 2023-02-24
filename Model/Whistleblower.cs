using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg
{
    public class Whistleblower : Blog
    {
        public enum WhistleblowerType
        {
            Complaints,
            Improvements,
            ProductionMistakes,
            Other
        }

        public string Password;
        public bool IsActive;
        public WhistleblowerType WhistleblowerTypeChoice;

        public Whistleblower()
        {

        }
        public Whistleblower(string title, string text, string picturePath) // WhistleblowerType whistleblowerTypeChoice 
        {
            Title= title;
            Text= text;
            PicturePath= picturePath;
            IsActive= true;
            // WhistleblowerTypeChoice = whistleblowerTypeChoice;
        }

        public Whistleblower CreateWhistleblower()
        {
            return null;
        }

        public Whistleblower ViewWhisteblower()
        {
            return null;
        }

        public Whistleblower whistleblower()
        {
            return null;
        }

    }
}