using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all npc objects
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<NPC> NPCs = new List<NPC>()
        {
            new Civilian
            {
                Id = 1,
                _npcName = "Toby Danger", // ALL NPC NAMES HAVE VERY OWN GET/SET 'NPCName'.
                AtlasLocationsID = 2,
                Description = "A skeleton that looks...alive? The sarco may have been his.",
                isEnemy = false,
                Messages = new List<string>
                {
                    "Sometimes dead..is better.",
                    "Why do you look so suprised? You're deader than I am.",
                    "I don't miss being a skin-bag, i've always been claustrophobic."
                }
            },

            new Civilian
            {
                Id = 2,
                _npcName = "Great Knight Haswell",
                AtlasLocationsID = 1,
                damage = 14.7,
                Description = "He's standing there talking to himself..",
                Messages = new List<string>
                {
                    "I miss Space Ghost.",
                    "Guide us. Teach us. Protect us. in your light we shall thrive, without it, we shall hunger",
                    "I have no business with you."
                }
                
            },

            new Civilian
            {
                Id = 3,
                _npcName = "Space Ghost",
                AtlasLocationsID = 4,
                Description = "It's...Space Ghost! O_O",
                 Messages = new List<string>
                {
                    "Haswell gives me the creeps.",
                    "I need to find Zorak, is he with you?",
                    "I'm on my way around the world, coast to coast."
                }
            }
        };
    }
}
