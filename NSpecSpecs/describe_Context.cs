using NSpec;
using NSpec.Domain;
using NUnit.Framework;

namespace NSpecNUnit
{
    [TestFixture]
    public class describe_Context
    {
        [Test]
        public void it_should_make_a_sentence_from_camel_cased_names()
        {
            new Context("YouLoveCamelCase").Name.should_be("You love camel case");
        }

        [Test]
        public void it_should_make_a_sentence_from_underscored_context_names()
        {
            new Context("i_love_underscores").Name.should_be("i love underscores");
        }
    }
}