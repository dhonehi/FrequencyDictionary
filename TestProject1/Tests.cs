using System;
using System.IO;
using FrequencyDictionary;
using NUnit.Framework;

namespace TestProject1 {
    [TestFixture]
    public class Tests {
        private MyFrequencyDictionary _myFrequencyDictionary;

        [Test]
        public void ExistingDirectory() {
            if (Directory.Exists("C:\\Temp1")) {
                 _myFrequencyDictionary = new MyFrequencyDictionary("C:\\Temp1");
                Assert.Pass();
            } else {
                Assert.Fail("Directory not found");
            }
        }
        
        [Test]
        public void ExistingHello() {
            Assert.True(_myFrequencyDictionary.Frequency.ContainsKey("привет"));
        }
        
        [Test]
        public void HelloCount() {
            Assert.AreEqual(4, _myFrequencyDictionary.Frequency["привет"]);
        }

        [Test]
        public void NotExistComma() {
            Assert.False(_myFrequencyDictionary.Frequency.ContainsKey(","));
        }

        [Test]
        public void WordsCount() {
            int wordsCount = 0;

            foreach (var item in _myFrequencyDictionary.Frequency) {
                wordsCount += item.Value;
            }
            
            Assert.AreEqual(13, wordsCount);
        }
    }
}