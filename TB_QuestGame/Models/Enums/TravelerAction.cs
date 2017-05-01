using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum ExileAction
    {
        None,
        MissionSetup,
        LookAround,
        Travel,

        TravelerMenu,
        ExileInfo,
        ExileInventory,
        AtlasLocationsVisited,
        
        ObjectMenu,
        LookAt,
        PickUpItem,
        PutDownItem,
        ListGameObjects,  
        AdminMenu,        
        PickUp,           
        PutDown,          
        Inventory,   
           
        ListNonplayerCharacters,
        NonplayerCharacterMenu,
        TalkTo,
                        
        PickUpTreasure,
        PutDownTreasure,
                               
        ExileTreasure,
        ListTreasures,

        ListDestinations,
        
        ListAtlasLocations,
        ListItems,

        ReturnToMainMenu, 
        Exit
    }
}
