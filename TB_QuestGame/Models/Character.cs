using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum FactionType
        {
            None,
            Crom,
            Brokkr,
            Hephaestus,

        }

        #endregion

        #region FIELDS
        public string _npcName;
        protected string _name;
        protected int _atlasLocationsID;
        protected int _age;
        protected int _level;
        protected int _power;
        protected FactionType _faction;
        protected string dietyDescript; // string req
        protected bool isName; // bool req


        #endregion

        #region PROPERTIES

        public string NPCName
        {
            get { return _npcName; }
            set { _npcName = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int AtlasLocationsID
        {
            get { return _atlasLocationsID; }
            set { _atlasLocationsID = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public FactionType Faction
        {
            get { return _faction; }
            set { _faction = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, FactionType faction, int atlasLocationID, int level, int power) // should fix if improper page 12 referance guide sprint 2 did not contain 3 arguments
        {
           
            _name = name;
            _faction = faction;
            _atlasLocationsID = atlasLocationID;
            _level = level;
            _power = power;
            
        }

        #endregion

        #region METHODS



        #endregion
    }
}
