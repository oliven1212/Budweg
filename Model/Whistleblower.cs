using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg.Model
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
        public Whistleblower(Employee author, string title, string text, string picturePath, WhistleblowerType whistleblowerType)
        {
            Author = author;
            Title= title;
            Text= text;
            PicturePath= picturePath;
            IsActive= true;
            WhistleblowerTypeChoice = WhistleblowerType;
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