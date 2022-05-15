using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Kulazhin.Default_Messages
{
    static class DefaultMessages
    {
        public enum Message
        {
            EnterCoordinates,
            EnterLength,
            EnterWidth,
            SetNewLength,
            SetNewWidth,
            SetNewX,
            SetNewY
        };

        public static string ShowMessage(Message msg)
        {
            switch (msg)
            {
                case 0: return "Enter coordinates X;Y for left - bottom rectangle point";
                case (Message)1: return "Enter rectangle length";
                case (Message)2: return "Enter rectangle width";
                case (Message)3: return "Set new length";
                case (Message)4: return "Set new width";
                case (Message)5: return "Set X-length to move";
                case (Message)6: return "Set Y-width to mov";
                default: return string.Empty;
            }
        }
    }
}
