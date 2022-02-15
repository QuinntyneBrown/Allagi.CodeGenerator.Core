using Allagi.CodeGenerator.Core.Interfaces;

namespace Allagi.CodeGenerator.Core.Services
{
    public class FileSystem : IFileSystem
    {
        public IFile File { get; private set; } = new File();
    }
}
