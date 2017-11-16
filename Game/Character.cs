using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Character
    {
        private CharClass _thisClass;

        public Character(int classIdentifier)
        {
            CharClass.characterClass thisIdentifier;

            if (Enum.IsDefined(typeof(CharClass.characterClass), classIdentifier))
            {
                thisIdentifier = (CharClass.characterClass)classIdentifier;
            }
            else
            {
                throw new Exception("Invalid class for the character!!");
            }

            ThisClass = new CharClass(thisIdentifier);
        }

        public CharClass ThisClass
        {
            get { return _thisClass; }
            set
            {
                _thisClass = value;
            }
        }
    }
}
