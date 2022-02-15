using Allagi.CodeGenerator.Core.Models;

namespace Allagi.CodeGenerator.Core.Interfaces
{
    public interface ISettingsProvider
    {
        ArchitectureModel Get(string directory = null);
    }
}
