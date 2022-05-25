using System;

namespace _00.Framework.Domin
{
    public abstract class DominBase<T>
    {
        public T Id { get; set; }
        public DateTime CreationDate { get; set; }


        public DominBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
