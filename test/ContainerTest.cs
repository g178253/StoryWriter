using System;
using Xunit;
using StoryWriter.Core;

namespace test
{
    public class ContainerTest
    {
        [Fact]
        public void Child_Default_Null()
        {
            var c = Get();
            Assert.Equal(Null.Instance, c.Child);
        }

        [Fact]
        public void Add_Children_Single()
        {
            var c = Get();
            c.Add(Null.Instance);
            Assert.Single(c.Children);
        }

        [Fact]
        public void Add_Child_EqualsNewElement()
        {
            var c = Get();
            var i = new Element();
            c.Add(i);

            Assert.Equal(i, c.Child);
        }

        [Fact]
        public void Remove_Children_Empty()
        {
            var c = Get();
            c.Add(Null.Instance);

            c.Remove(-1);
            Assert.Empty(c.Children);
        }

        [Fact]
        public void Remove_Child_EqualsNull()
        {
            var c = Get();
            c.Add(Null.Instance);

            c.Remove(-1);
            Assert.Equal(Null.Instance, c.Child);
        }

        private Container Get()
        {
            return new Container();
        }
    }
}
