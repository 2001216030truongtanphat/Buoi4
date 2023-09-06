using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class CToaDo
    {
        private string _ten;
        public string Ten 
        {
            get { return _ten; } 
            set { _ten = value; }
        }
        private float _tdX;
        public float X
        {
            get { return _tdX; }
            set { _tdX = value;}
        }
        private float _tdY;
        public float Y
        {
            get { return _tdY; }
            set { _tdY = value; }
        }
        public CToaDo()
        {
            _tdX = 0;
            _tdY = 0;
        }
        public CToaDo(float tdx, float tdy, string ten)
        {
            this._tdX = tdx;
            this._tdY = tdy;
            this._ten = ten;
        }
        public override string ToString()
        {
            return Ten + "(" + X + "," + Y + ")";
        }
    }
}
