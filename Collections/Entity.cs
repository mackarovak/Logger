using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Entity
    {
        public int Id { get; private set; }
        public int ParentId { get; private set; }
        public string Name { get; private set; }

        public Dictionary <int, List <Entity>> outputDictionary(List <Entity> list) 
        {
            var dict= new Dictionary<int, List<Entity>>();
            return dict;
        }
    }
}
