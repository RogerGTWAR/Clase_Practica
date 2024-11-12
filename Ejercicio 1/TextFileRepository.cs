using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class TextFileRepository : IFileRepository
    {

        public async Task<string> ReadFileAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public async Task SaveFileAsync(string filePath, string content)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                await writer.WriteAsync(content);
            }
        }
    }
}
