using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace BrickProjectTests
{
    public class BaseTest
    {
        public BaseTest()
        {
            MockRepository = new MockRepository(MockBehavior.Loose);
        }

        public MockRepository MockRepository { get; }
    }
}
