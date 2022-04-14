using System;

namespace ryze.system.Domain
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            _Insert = DateTime.Now;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime _Insert { get; set; }
        public DateTime _Update { get; private set; }
        public DateTime _Deleted { get; private set; }

        protected void SetUpdate()
        {
            _Update = DateTime.Now;
        }
    }
}
