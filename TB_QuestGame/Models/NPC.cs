using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public abstract class NPC : Character
    {
        public abstract int Id { get; set; }
        public abstract string Description { get; set; }
        public abstract bool combatReady { get; set; }
        public abstract bool isDead { get; set; }
        public abstract int Power { get; set; }
        public abstract bool hasQuest { get; set;}
        public abstract double damage { get; set; }
        public abstract string npcName { get; set; }
        public enum Mood
        {
            happy,
            angry,
            anxious,
            dastardly,

        } 
        
    }
}
