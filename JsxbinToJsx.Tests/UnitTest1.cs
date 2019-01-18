using NUnit.Framework;
using JsxbinToJsx.JsxbinDecoding;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestVersion1()
        {
            ExecuteTests("v1.0");
        }

        [Test]
        public void TestVersion2()
        {
            ExecuteTests("v2.0");
        }
        
        private void ExecuteTests(string version)
        {
            foreach (var p in new Testdata().ReadTestfiles(version))
            {
                string actualJsx = AbstractNode.Decode(p.Jsxbin, false);
                Assert.True(p.Jsx == actualJsx, $"Decoding JSXBIN {version} does not match expected output in {p.JsxFilename}.");
            }
        }
    }
}