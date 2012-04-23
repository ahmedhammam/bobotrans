using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Interfejsi
{
    public interface IDaoCrud<T>
    {
        long create(T entity);
        T read(T entity);
        T update(T entity);
        void delete(T entity);
        T getById(long id);
        List<T> GetAll();
        List<T> getByExample(string name, string values);
    }
}
