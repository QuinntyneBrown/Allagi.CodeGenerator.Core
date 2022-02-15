using Allagi.CodeGenerator.Core.Models;

namespace Allagi.CodeGenerator.Core.Interfaces
{
    public interface IAngularJsonProvider
    {
        AngularJsonModel Get(string directory = null);
    }
}
