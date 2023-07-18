using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public abstract class BaseEntity<T> where T : struct
    {
        public virtual T Id { get; set; }
    }
}
