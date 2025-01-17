﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
   public interface IFileRepository
    {
        Task<string> ReadFileAsync(string filePath);
        Task SaveFileAsync(string filePath, string content);
    }
}
