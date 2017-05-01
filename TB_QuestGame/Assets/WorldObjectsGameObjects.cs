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
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Shard of Sosoria",
                AtlasLocationId = 2,
                Description = "Small glowing shard that feels like nothing but weighs heavily in the palm of your hand.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "knife",
                AtlasLocationId = 3,
                Description = "a standard knife.",
                Type = TravelerObjectType.Treasure,
                Value = 15,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "Maroon Lotus",
                AtlasLocationId = 3,
                Description = "A healing salve; they say..",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = false,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Tattered Page",
                AtlasLocationId = 3,
                Description =
                    "A tattered page that's barely legible." + "/n" +
                    "Date: 114 " + "/n" +
                    "/n" +
                    "I think the holy knight is losing his mind..the things he says.. ",
                Type = TravelerObjectType.Information,
                Value = 5,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 8,
                Name = "Gold Ring",
                AtlasLocationId = 0,
                Description =
                    "Golden ring; was fancy back then; wonder what it's worth now.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 9,
                Name = "Lagoon Orchid",
                AtlasLocationId = 0,
                Description =
                    "More dependable than the Maroon Lotus.",
                Type = TravelerObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },
                    
             new AtlasLocationObject
            {
                Id = 5,
                Name = "Ornate Chest",
                AtlasLocationId = 2,
                Description = "Theres a large tounge sticking out, Eww!",
                IsDeadly = true
            },

            new AtlasLocationObject
            {
                Id = 6,
                Name = "Pants of Fortitude",
                AtlasLocationId = 2,
                Description = "Some pretty nice pants.",
                IsDeadly = true
            }
        };
    }
}
