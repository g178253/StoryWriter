using System;
using Xunit;
using StoryWriter.Core;
using System.Collections.Generic;

namespace test
{
    public class ContainerTest
    {
        [Fact]
        public void Child_Default_Null()
        {
            var c = Get();
            Assert.Null(c.Child);
        }

        [Fact]
        public void Add_Children_Single()
        {
            var c = Get();
            c.Add(Null.Instance);
            var children = c.Value as ICollection<Element>;
            Assert.Single(children);
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
            var children = c.Value as ICollection<Element>;
            Assert.Empty(children);
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
