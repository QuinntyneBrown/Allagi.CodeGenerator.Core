using System;
using System.IO;

namespace Allagi.CodeGenerator.Core.Services
{
    public class FileSystemEntry
    {
        public FileAttributes Attributes { get; set; }
        public DateTimeOffset CreationTimeUtc { get; set; }
        public string Directory { get; set; }
        public string FileName { get; set; }
        public bool IsDirectory { get; set; }
        public bool IsHidden { get; set; }
        public DateTimeOffset LastAccessTimeUtc { get; set; }
        public DateTimeOffset LastWriteTimeUtc { get; set; }
        public long Length { get; set; }
        public string OriginalRootDirectory { get; set; }
        public string RootDirectory { get; set; }
    }
}
