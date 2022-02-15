using Allagi.CodeGenerator.Core.Enums;

namespace Allagi.CodeGenerator.Core.Interfaces
{
    public interface INamingConventionConverter
    {
        string Convert(NamingConvention from, NamingConvention to, string value);

        string Convert(NamingConvention to, string value);

        string Convert(NamingConvention to, string value, bool pluralize);
    }
}