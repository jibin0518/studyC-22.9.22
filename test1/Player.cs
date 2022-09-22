using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    public class Player
    {
        public int hp=100;
        public int at=10;

        public void AddAt(int _at)
        {
            at += _at;
        }



        public void Fight(int monster1At)
        {
            hp -= monster1At;
        }
    }
}
