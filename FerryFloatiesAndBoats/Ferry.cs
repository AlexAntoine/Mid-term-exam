using System;
using System.Collections.Generic;
using System.Text;

namespace FerryFloatiesAndBoats
{
    //Dwayne Booth
    public class Ferry
    {
        protected string _FerryName;
        protected int _passengerCap;
        protected int _autoCap;
        protected int _length;
        protected int _draft;
        protected int _width;
        protected int _hp;
        protected double _serviceSpeed;
        protected string _homePort;

        public bool setPassengerCap(string s)
        {
           

            if (int.TryParse(s, out _))
            {
                _passengerCap = int.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getPassengerCap()
        {
            
            return _passengerCap.ToString();
        }

        public bool setAutoCap(string s)
        {
          
            if (int.TryParse(s, out _))
            {
                _autoCap = int.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getAutoCap()
        {
            return _autoCap.ToString();
        }

        public bool setLength(string s)
        {
         

            if (int.TryParse(s, out _))
            {
                _length = int.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getLength()
        {
            return _length.ToString();
        }

        public bool setDraft(string s)
        {
           

            if (int.TryParse(s, out _))
            {
                _draft = int.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getDraft()
        {
            return _draft.ToString();
        }

        public bool setHomePort(string s)
        {
            _homePort = s;
            return true;
        }

        public string getHomePort()
        {
            return _homePort;
        }

        public bool setFerryName(string s)
        {
          
            _FerryName = s;
            return true;
        }

        public string getFerryName()
        {
            return _FerryName;
        }

        public bool setServiceSpeed(string s)
        {
            

            if (double.TryParse(s, out _))
            {
               _serviceSpeed = double.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getServiceSpeed()
        {
            return _serviceSpeed.ToString();
        }

        public bool setWidth(string s)
        {

            if (int.TryParse(s, out _))
            {
               _width = int.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getWidth()
        {
            return _width.ToString();
        }

        public bool setHp(string s)
        {
            

            if (int.TryParse(s, out _))
            {
                _hp = int.Parse(s);
                return true;
            }
            else
                return false;
        }

        public string getHp()
        {
            return _hp.ToString();
        }
    }
}