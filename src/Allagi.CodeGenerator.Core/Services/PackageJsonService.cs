using Newtonsoft.Json.Linq;

namespace Allagi.CodeGenerator.Core.Services
{

    public class PackageJsonService : IPackageJsonService
    {
        public void AddGenerateModelsNpmScript(string filePath)
        {
            var key = "generate-models";

            var value = "node node_modules/ng-swagger-gen/ng-swagger-gen --config ng-swagger-gen.json";

            var section = "scripts";

            var json = System.IO.File.ReadAllText(filePath);

            JObject jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(json);

            JObject scriptsJsonObject = jsonObject[section] as JObject;

            if (scriptsJsonObject.GetValue(key) == null)
            {
                scriptsJsonObject.Add(key, value);
            }
            else
            {
                scriptsJsonObject[key] = value;
            }

            jsonObject[section] = scriptsJsonObject;

            System.IO.File.WriteAllText(filePath, Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
