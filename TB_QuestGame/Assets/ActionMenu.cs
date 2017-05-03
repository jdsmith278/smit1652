using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {

        public enum CurrentMenu
        {
            MissionIntro,
            InitializeMission,
            MainMenu,
            ObjectMenu,
            NPCMenu,
            TravelerMenu,
            AdminMenu
        }

        public static CurrentMenu currentMenu = CurrentMenu.MainMenu;

        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, ExileAction>()
                    {
                        { ' ', ExileAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { '1', ExileAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { 'c', ExileAction.ExileInfo },
                    { 'l', ExileAction.LookAround},
                    { 'f', ExileAction.LookAt },
                    { 'g', ExileAction.PickUp},
                    { 'd', ExileAction.PutDown},
                    { 'i', ExileAction.Inventory},
                    { 't', ExileAction.Travel },
                    { 'j', ExileAction.AtlasLocationsVisited },
                    { 'm', ExileAction.ListAtlasLocations },
                    { 'L', ExileAction.ListGameObjects },
                    { 'n', ExileAction.NonplayerCharacterMenu },
                    { '`', ExileAction.AdminMenu },
                    { 'q', ExileAction.ReturnToMainMenu },
                    { '0', ExileAction.Exit }
                }
        };

        public static Menu AdminMenu = new Menu()
        {
            MenuName = "AdminMenu",
            MenuTitle = "Admin Menu",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { 'm', ExileAction.ListAtlasLocations },
                    { 'L', ExileAction.ListGameObjects},
                    { 'n', ExileAction.ListNonplayerCharacters},
                    { 'q', ExileAction.ReturnToMainMenu }
                }
        };

        public static Menu TravelerMenu = new Menu()
        {
            MenuName = "TravelerMenu",
            MenuTitle = "Traveler Menu",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { 'c', ExileAction.ExileInfo },
                    { 'i', ExileAction.Inventory},
                    { 'j', ExileAction.AtlasLocationsVisited},
                    { 'q', ExileAction.ReturnToMainMenu }
                }
        };

        public static Menu ObjectMenu = new Menu()
        {
            MenuName = "ObjectMenu",
            MenuTitle = "Object Menu",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { 'l', ExileAction.LookAt },
                    { 'g', ExileAction.PickUp},
                    { 'd', ExileAction.PutDown},
                    { 'q', ExileAction.ReturnToMainMenu }
                }
        };

        public static Menu NpcMenu = new Menu()
        {
            MenuName = "NpcMenu",
            MenuTitle = "NPC Menu",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { 'T', ExileAction.TalkTo},
                    { 'q', ExileAction.ReturnToMainMenu }
                }
        };

        public static Menu BattelMenu = new Menu()
        {
            MenuName = "BattleMenu",
            MenuTitle = "Battle Menu",
            MenuChoices = new Dictionary<char, ExileAction>()
                {
                    { 'T', ExileAction.TalkTo},
                    { 'q', ExileAction.ReturnToMainMenu }
                }
        };
        
    }
}
