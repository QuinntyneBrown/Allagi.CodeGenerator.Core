namespace Allagi.CodeGenerator.Core.Interfaces
{
    public interface ITenseConverter
    {
        string Convert(string value, bool pastTense = true);
    }
}
