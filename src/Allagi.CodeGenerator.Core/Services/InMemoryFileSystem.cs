using Allagi.CodeGenerator.Core.Interfaces;

namespace Allagi.CodeGenerator.Core.Services
{
    public class InMemoryFileSystem : IFileSystem
    {
        public IFile File => new InMemoryFile();
    }
}
