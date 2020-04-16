using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class Fish : Animal
    {
        public override string Move()
        {
            return "I am swimming.";
        }
    }
}
