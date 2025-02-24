using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem8;

namespace Program8Test
{
    [TestFixture]
    public class Class1
    {
        private FileProcessor _file;
        private string _filename;
        [SetUp]
        public void Setup()
        {
            _file = new FileProcessor();
            _filename = "F:\\Capg- TRAINING\\C# Programmes\\feature-22Feb2025\\NUnit- Assignment\\Program8Test\\testfile.txt";
        }
        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_filename))
            {
                File.Delete(_filename);
            }
        }

        [Test]
        public void WriteToFile_GivenContent_WritesContentToFile()
        {
            string content = "Hello, World!";
            var fileProcessor = new FileProcessor();
            fileProcessor.WriteToFile(_filename, content);

            string readContent = File.ReadAllText(_filename);
            Assert.AreEqual(content, readContent);
        }

        [Test]
        public void WriteToFile_FileExists_ReturnsTrue()
        {
            string content = "File existence test";
            var fileProcessor = new FileProcessor();
            fileProcessor.WriteToFile(_filename, content);

            bool fileExists = File.Exists(_filename);
            Assert.IsTrue(fileExists);
        }
        [Test]
        public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
        {
            string nonExistentFile = "nonexistent.txt";
            var fileProcessor = new FileProcessor();

            var ex = Assert.Throws<IOException>(() => fileProcessor.ReadFromFile(nonExistentFile));
            Assert.AreEqual("File does not exist.", ex.Message);
        }

    }
}
