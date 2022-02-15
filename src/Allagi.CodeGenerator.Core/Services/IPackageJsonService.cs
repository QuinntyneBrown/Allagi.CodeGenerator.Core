namespace Allagi.CodeGenerator.Core.Services
{
    public interface IPackageJsonService
    {
        void AddGenerateModelsNpmScript(string packageJsonFilePath);
    }
}
