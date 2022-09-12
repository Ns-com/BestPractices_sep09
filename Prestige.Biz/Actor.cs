using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        /// <summary>
        /// will return title
        /// </summary>
        /// <returns></returns>
        public Actor()
        {
            Console.WriteLine("actor has been born");
            //intilize object of agency. when needed frequently;
           // this.currrentAgency = new ActorAgency();
        }
        //to excecute this and above constructor we we "this" keyword.
        public Actor(string actorName):this()
        {
            ActorName = actorName;
        }
        private string actorName;

        public string ActorName
        {
            get
            {
                return actorName;
            }
            set 
            {
                var formattedName = value?.Trim();
                actorName = formattedName;
            }
        }
        //currentagency is object of another class used as property.
        private ActorAgency currrentAgency;

        public ActorAgency CurrrentAgency
        {
            get 
            {
                if (currrentAgency == null)
                    currrentAgency = new ActorAgency();
                return currrentAgency;
            }
            set { currrentAgency = value; }
        }
        private string jobTitle;
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle =value; }
        }
        //if no logic is involved then use simple following format instead of jobtitle
        public int ActorAge { get; set; }
        public string ActorDescription { get; set; } = "Regular actor";
        public string GetOccupation()
        {
            jobTitle = "actor";
            return jobTitle;
        }
        /// <summary>
        /// returns actor book status
        /// </summary>
        /// <returns></returns>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            string details = "Booking can change";
            if (theDate!=string.Empty)
            {
                return "Actor " + ActorName + " is booked. " + details+theDate;
            }
            else
            {
                return "Actor " + ActorName + " is booked. " + details;
            }
        }
        public string GetAgencyName()
        {
            /*ActorAgency agency = new ActorAgency();
            return agency.Name;*/
            //2nd method of callling agency is via property setting and cons intialization:
            //CurrentAgency is property. currentAgency is field.
            return CurrrentAgency.Name;
        }




    }
}
