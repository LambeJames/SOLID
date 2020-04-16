using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class Dog : Fish
    {
        public override string Move()
        {
            return "I am running!";
        }
    }
}
