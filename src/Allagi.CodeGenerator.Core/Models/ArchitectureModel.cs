using System.Collections.Generic;

namespace Allagi.CodeGenerator.Core.Models
{
    public class ArchitectureModel
    {
        public List<ApiModel> Apis { get; set; }
        public List<FrontendModel> Frontends { get; }
        public string RootDirectory { get; set; }
    }
}
