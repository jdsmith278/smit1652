using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static partial class WorldObjects
    {
        public static List<AtlasLocations> AtlasLocations = new List<AtlasLocations>()
        {

            new AtlasLocations
            {
                CommonName = "Defiled Crypt",
                AtlasLocationID = 1,
                UniversalDate = 7017,
                UniversalLocation = "Outside of civilization",
                Description = "A desecrated place of what you imagine must have once been a crypt \n" +
                    "no other living beings, or dead ones for that matter, seem to exist in this place. " +
                    "\n",
                GeneralContents = "You look around and take in the world around you. \n" +
                    "a sarcophagus lay upright, halfway burrowed into the wall. " +
                    "Was it yours?\n",
                Accessable = true,
                ExperiencePoints = 100
            },

            new AtlasLocations
            {
                CommonName = "Dark Wood",
                AtlasLocationID = 2,
                UniversalDate = 7017,
                UniversalLocation = "Just outside the crypt",
                Description = "The fresh, dark, air hitting your face is welcome. \n" +
                    "Your eyes have no trouble adjusting to the darkness." +
                    "",
                GeneralContents = "Trees with no leaves loom over you.\n" +
                "You hear heavy wind roaring through them as they sway..but thats all.\n",
                Accessable = true,
                ExperiencePoints = -5
            },

            new AtlasLocations
            {
                CommonName = "Ancient Forge",
                AtlasLocationID = 3,
                UniversalDate = 7017,
                UniversalLocation = "Somewhere in the Dark Wood",
                Description = "Some memories come rushing back \n" +
                              "You remember this place. \n" +
                              "Who were you?",
                GeneralContents = "This place looks very different from it's natural surroundings. \n" +
                "Ornate metal lines the open archway and inside; a glowing anvil and forge. \n" +
                "seemingly placed delicately upon the forge; a huge tome. \n"+
                "This place looks almost untouched...",
                Accessable = true,
                ExperiencePoints = 100
            },

            new AtlasLocations
            {
                CommonName = "Abandoned Mine",
                AtlasLocationID = 4,
                UniversalDate = 7017,
                UniversalLocation = "Somewhere in the Dark Wood",
                Description = "The mine is cold and dank and smells of sulfur. Someone might be here.. \n",

                GeneralContents = "A natural deposit of materials. \n" +
                              "You feel like you know your way around here. Why does this place feel familiar to you as well?",
                Accessable = true,
                ExperiencePoints = 100
            },

            new AtlasLocations
            {
                CommonName = "Future City",
                AtlasLocationID = 5,
                UniversalDate = 100,
                UniversalLocation = "Somewhere",
                Description = "A city like you've never imagined.",
                GeneralContents = "A city that bustles with activity and too many voices, you should get out of here. \nYou gain experience.",
                Accessable = true,
                ExperiencePoints = 123

            },
             new AtlasLocations
            {
                CommonName = "Abandonded Valley",
                AtlasLocationID = 6,
                UniversalDate = 100,
                UniversalLocation = "A cold and seemingly empty place.",
                Description = "If you go down there, you might not get out.",
                GeneralContents = "You struggle to see through the thick fog. Anything could be down there.. \nYou gain experience.",
                Accessable = true,
                ExperiencePoints = 511

            },
              new AtlasLocations
            {
                CommonName = "Damp Thicket",
                AtlasLocationID = 7,
                UniversalDate = 100,
                UniversalLocation = "Somewhere off course",
                Description = "Looks like you'd never want to come across any reason you might want to go in there.",
                GeneralContents = "You don't want to go in, just want to know where it is. \nYou gain experience.",
                Accessable = true,
                ExperiencePoints = -94,
                

            },
               new AtlasLocations
            {
                CommonName = "Old Iron Mill",
                AtlasLocationID = 8,
                UniversalDate = 100,
                UniversalLocation = "The Iron Mill",
                Description = "An iron mill. You can see people still working it, regardless of the shape its in.",
                GeneralContents = "Tons of iron laying around. You can definitely use this. \nYou gain experience.",
                Accessable = true,
                ExperiencePoints = 63

            },
           
        };
        
    }
}
