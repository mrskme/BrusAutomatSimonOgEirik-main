
using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Chocolate : Product
    {
        private readonly bool _isWhite;
        public Chocolate(bool isWhite, double price, string name, int storage) : base(price, name, storage)
        {
            _isWhite = isWhite;
        }
    }
}
