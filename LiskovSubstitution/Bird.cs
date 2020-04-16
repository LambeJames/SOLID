using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class Bird : Animal
    {
        public override string Move()
        {
            return "I am flying.";
        }
    }
}
