using System.Collections.Generic;

namespace DBTest1
{
    public class Hamali
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }

        public virtual ICollection<Tools> Tools { get; set; }
    }
}
