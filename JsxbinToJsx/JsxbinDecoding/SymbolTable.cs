using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsxbinToJsx.JsxbinDecoding
{
    public sealed class SymbolTable
    {
        Dictionary<string, string> table = new Dictionary<string, string>();

        public void Add(string key, string value)
        {
            table[key] = value;
        }

        public string Get(string key)
        {
            return table[key];
        }
    }
}
