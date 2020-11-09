using System.Collections.Generic;

namespace BookBinderBE.Services
{
    public interface IDatabaseService<T>
    {
        T Create(T data);
        List<T> Get();
        T Get(string id);
        void Update(string id, T data);
    }
}