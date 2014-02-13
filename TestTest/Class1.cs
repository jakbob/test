using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestTest
{

    [TestFixture]

    public class Class1
    {
        [Test]
        public void should_be_true()
        {
           Assert.True(true); 
        }

        [Test]
        public void should_fail()
        {
            Assert.True(false);
        }

    }
}
