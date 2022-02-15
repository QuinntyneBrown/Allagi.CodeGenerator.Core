using Allagi.CodeGenerator.Core.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Allagi.CodeGenerator.Core.Services
{
    public class TokensBuilder
    {
        private Dictionary<string, object> _value { get; set; } = new Dictionary<string, object>();

        public TokensBuilder()
        {
            _value = new Dictionary<string, object>();
        }
        public TokensBuilder With(string propertyName, Token token)
        {
            var tokens = token == null ? new Token("").ToTokens(propertyName) : token.ToTokens(propertyName);
            _value = new Dictionary<string, object>(_value.Concat(tokens));
            return this;
        }

        public Dictionary<string, object> Build()
            => this._value;
    }
}
