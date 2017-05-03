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
                Name = "Toby Danger", // ALL NPC NAMES HAVE VERY OWN GET/SET 'NPCName'.
                AtlasLocationsID = 2,
                Description = "A skeleton that looks...alive? The sarco may have been his.",
                combatReady = false,
                isDead = false,
                hasQuest = false,
                Power = 15,
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
                Name = "Great Knight Haswell",
                AtlasLocationsID = 1,
                damage = 14.7,
                isDead = false,
                Description = "He's standing there talking to himself..",
                Power = 35,
                hasQuest = true,
                Messages = new List<string>
                
                {
                    "Guide us. Teach us. Protect us. In your light we shall thrive, in your wisdom we are sheltered.",
                    "The field is lost.",
                    "The black one has fallen from the sky and the towers, in ruins, lie.",
                    "The enemy is within, everywhere!"
                }
                
            },

            new Civilian
            {
                Id = 3,
                Name = "Space Ghost",
                AtlasLocationsID = 4,
                Description = "It's...Space Ghost! O_O",
                isDead = false,
                hasQuest = false,
                Power = 150,
                 Messages = new List<string>
                {
                    "Haswell gives me the creeps.",
                    "I need to find Zorak, is he with you?",
                    "I'm on my way around the world, coast to coast."
                }
            },

            new Civilian
            {
                Id = 3,
                Name = "The Neon Droid",
                AtlasLocationsID = 8,
                Description = "An obvious robot shaped like a female human. It sits close, seemingly trying to seduce me.",
                isDead = false,
                hasQuest = false,
                Power = 250,
                 Messages = new List<string>
                {
                    "*Sits closer*",
                    "*lights up",
                    "*brushes back invisible hair*",
                    ""
                }
            },
            new Civilian
            {
                Id = 3,
                Name = "Lazer Hawk",
                AtlasLocationsID = 6,
                Description = "A Hawk with lazers. -_-",
                isDead = false,
                hasQuest = false,
                Power = 70,
                 Messages = new List<string>
                {
                    "Caw!",
                    "Zap!",
                    "*Glares*"
                }
            }
        };
    }
}
