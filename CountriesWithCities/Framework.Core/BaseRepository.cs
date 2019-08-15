using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public abstract class BaseRepository<TKey, T> : IRepository<TKey, T>
    {
        public List<T> Get()
        {
            return 
        }

        public T Get(TKey id)
        {
            throw new NotImplementedException();
        }
    }
}
