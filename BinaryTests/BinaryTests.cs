using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binary_Search_Tree;



namespace BinaryTests
{
    [TestClass]
    public class BinaryTests
    {
        [TestMethod]
        public void Add_AddFourNodes_NodesAreAdded()
        {
            Node node = new Node();
            node.Add(12);
            node.Add(15);
            node.Add(8);
            node.Add(20);
        }
    }
}
