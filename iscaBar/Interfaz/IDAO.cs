using iscaBar.Model;
using iscaBar.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iscaBar.Interfaz
{
    public interface IDAO<T>
    {

        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task SaveAsync(T element);
        Task DeleteAsync(T element);
        Task<T> GetWithChildrenAsync(int id);
    }
}
