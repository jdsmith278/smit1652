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
        public abstract bool isEnemy { get; set; }
        public abstract double damage { get; set; }
        public enum Mood
        {
            happy,
            angry,
            anxious,
            dastardly,

        } 
        
    }
}
