using System;

namespace JsxbinToJsx.JsxbinDecoding
{
    public interface IReferenceDecoder
    {
        double JsxbinVersion { get; }
        Tuple<string, bool> Decode(INode node);
    }
}
