using System.IO;

namespace Allagi.CodeGenerator.Core.Interfaces
{
    public interface IFile
    {
        string ReadAllText(string path);
        Stream OpenRead(string path);
        bool Exists(string path);
        bool Exists(string[] paths);
        void WriteAllLines(string path, string[] contents);
    }
}