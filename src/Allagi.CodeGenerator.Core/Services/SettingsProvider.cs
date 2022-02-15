using Allagi.CodeGenerator.Core.Exceptions;
using Allagi.CodeGenerator.Core.Interfaces;
using Allagi.CodeGenerator.Core.Models;
using System.IO;
using System.Linq;
using static System.Environment;
using static System.IO.Path;
using static System.Text.Json.JsonSerializer;

namespace Allagi.CodeGenerator.Core.Services
{
    public class SettingsProvider : ISettingsProvider
    {
        public ArchitectureModel Get(string directory = null)
        {
            directory ??= CurrentDirectory;

            var parts = directory.Split(DirectorySeparatorChar);

            for (var i = 1; i <= parts.Length; i++)
            {
                var path = $"{string.Join(DirectorySeparatorChar, parts.Take(i))}{DirectorySeparatorChar}{CoreConstants.SettingsFileName}";

                if (System.IO.File.Exists(path))
                {
                    var settings = Deserialize<ArchitectureModel>(System.IO.File.ReadAllText(path), new System.Text.Json.JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true,
                    });
                    settings.RootDirectory = new FileInfo(path).Directory.FullName;
                    return settings;
                }

                i++;
            }

            throw new SettingsNotFoundException();

        }
    }
}
