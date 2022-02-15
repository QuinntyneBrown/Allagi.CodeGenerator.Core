using System;
using System.IO;

namespace Allagi.CodeGenerator.Core.Interfaces
{
    public class InMemoryFile : IFile
    {
        public bool Exists(string path)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string[] paths)
        {
            throw new NotImplementedException();
        }

        public Stream OpenRead(string path)
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteAllLines(string path, string[] contents)
        {
            throw new NotImplementedException();
        }
    }
}
