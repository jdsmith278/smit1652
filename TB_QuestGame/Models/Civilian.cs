using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    class Civilian : NPC, ISpeak // Character or NPC on worksheet
    {
        public override int Id { get; set; }
        public override string Description { get; set; }
        public List<string> Messages { get; set; }
        public override bool isEnemy {get; set;}
        public override double damage { get; set; }

        /// <summary>
        /// generate a message or use default
        /// </summary>
        /// <returns>message text</returns>
        public string Speak()
        {
            if (this.Messages != null)
            {
                return GetMessage();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// randomly select a message from the list of messages
        /// </summary>
        /// <returns>message text</returns>
        private string GetMessage()
        {
            Random r = new Random();
            int messageIndex = r.Next(0, Messages.Count());
            return Messages[messageIndex];
        }


    }
}
