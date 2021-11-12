using _8.hét.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.hét.Entities
{
    public class BallFactory: IToyFactory
    {
        public Toy CreateNew()
        {

            return new Ball();
        }


    }
}
