namespace Allagi.CodeGenerator.Core.Interfaces
{
    public interface ICommandService
    {
        void Start(string command, string workingDirectory = null, bool waitForExit = true);
    }
}
