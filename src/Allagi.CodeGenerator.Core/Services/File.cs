using Allagi.CodeGenerator.Core.Interfaces;
using System.Linq;

namespace Allagi.CodeGenerator.Core.Services
{
    public class File : IFile
    {
        public bool Exists(string path)
            => System.IO.File.Exists(path);

        public bool Exists(string[] paths)
            => paths.Any(x => Exists(x));

        public System.IO.Stream OpenRead(string path)
            => System.IO.File.OpenRead(path);

        public string ReadAllText(string path)
            => System.IO.File.ReadAllText(path);

        public void WriteAllLines(string path, string[] contents)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            System.IO.File.WriteAllLines(path, contents);
        }
    }
}
