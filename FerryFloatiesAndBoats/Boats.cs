using System;
using System.Collections.Generic;
using System.Text;

namespace FerryFloatiesAndBoats
{
    //Dwayne Booth 
    public class Boats: Ferry
    {
        protected string _houseBoatName;
        protected int _beds;

        public Boats()
        {

        }
        public bool setBeds(string s)
        {

            if(int.TryParse(s, out _))
            {
                _beds = int.Parse(s);
                return true;
            }
            return false;
        }

        public string getBeds()
        {
            return _beds.ToString();
        }

        public bool setHouseBoatName(string s)
        {
           
            _houseBoatName = s;
            return true;
        }

        public string getHouseBoatName()
        {
            return _houseBoatName;
        }
    }
}
