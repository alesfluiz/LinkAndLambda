using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Entities
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }

    }
}
