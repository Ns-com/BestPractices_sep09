using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Common
{
    static public class NotificationService
    {
        /// <summary>
        /// notifies talent
        /// </summary>
        /// <param name="talentName"></param>
        /// <returns></returns>
        static public string NotifyTalent(string talentName)
        {
            var message = "Talent:" + talentName;
            Console.WriteLine(message);
            return message;
        }
    }
}
