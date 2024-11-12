using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
  public interface IPhotoRepository<T>
  {
        Task<List<string>> GetSupportedFormatsAsync();
        Task<T> LoadAsync(string filePath);
        Task<T> ProcessAsync(T data);
    }
}
