using System;
using System.Collections.Generic;
using System.Text;

namespace FerryFloatiesAndBoats
{
    public class Boats: Ferry
    {
        protected string _houseBoatName;
        protected int _beds;

        public Boats()
        {

        }
        public bool setBeds()
        {
            //take input, verfie it's an integer
            //if it is return true convert input to an int
            //and assign it to beds property, if it is not return false
        }

        public string getBeds()
        {
            //return beds properties as a string 
        }

        public bool setHouseBoatName()
        {
            /*
             * take string input and assign it to houseBoatName property
             * return true
             */
        }

        public string getHouseBoatName()
        {
            /*
             * return houseboadname as a string
             */
        }
    }
}
