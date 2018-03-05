using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    //TODO: Don't use comments - the code should be self-descriptive (here and in other files). 
    //Self-descriptive means understandable from the mehods/fields names.
    internal class Input
    {
        //Load list of available Keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        //Perform a check to see if a particular button is pressed.
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Detect if a keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
