using System.Collections.Generic;

namespace AssociateManagement.Services
{
    public interface IDatabaseService<T>
    {
        T Create(T data);
        List<T> Get();
    }
}