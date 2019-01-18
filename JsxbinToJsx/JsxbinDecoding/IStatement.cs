using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsxbinToJsx.JsxbinDecoding
{
    public interface IStatement
    {
        int LineNumber { get; }
    }
}
