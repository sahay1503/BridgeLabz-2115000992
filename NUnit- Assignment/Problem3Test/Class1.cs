using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem3;

namespace Problem3Test
{
    [TestFixture]
    public class Class1
    {
        private ListManager _listManager;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
        }
        [Test]
        public void AddElement_GivenElement_AddsElementToList()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            int element = 4;
            _listManager.AddElement(list, element);
            Assert.That(list, Contains.Item(element));
        }

        [Test]
        public void RemoveElement_GivenElement_RemovesElementFromList()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            int element = 2;
            _listManager.RemoveElement(list, element);
            Assert.That(list.Contains(element), Is.False);
        }

        [Test]
        public void GetSize_AfterAddingElement_ReturnsUpdatedSize()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            _listManager.AddElement(list, 4);
            int size = _listManager.GetSize(list);
            Assert.That(size, Is.EqualTo(4));
        }

        [Test]
        public void GetSize_AfterRemovingElement_ReturnsUpdatedSize()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            _listManager.RemoveElement(list, 2);
            int size = _listManager.GetSize(list);
            Assert.That(size, Is.EqualTo(2));
        }
    }
}
