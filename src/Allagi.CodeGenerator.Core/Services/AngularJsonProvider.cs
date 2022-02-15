using Allagi.CodeGenerator.Core.Interfaces;
using Allagi.CodeGenerator.Core.Models;
using System.IO;
using System.Linq;
using System.Text.Json;
using static System.Environment;
using static System.IO.Path;
using static System.Text.Json.JsonSerializer;

namespace Allagi.CodeGenerator.Core.Services
{
    public class AngularJsonProvider : IAngularJsonProvider
    {
        public AngularJsonModel Get(string directory = null)
        {
            directory ??= CurrentDirectory;

            var parts = directory.Split(DirectorySeparatorChar);

            for (var i = 1; i <= parts.Length; i++)
            {
                var path = $"{string.Join(DirectorySeparatorChar, parts.Take(i))}{DirectorySeparatorChar}angular.json";

                if (System.IO.File.Exists(path))
                {
                    var angularJson = Deserialize<AngularJsonModel>(System.IO.File.ReadAllText(path), new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true,
                    });

                    angularJson.RootDirectory = new FileInfo(path).Directory.FullName;

                    return angularJson;
                }

                i++;
            }

            return AngularJsonModel.Empty;

        }
    }
}
