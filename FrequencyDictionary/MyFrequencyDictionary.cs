using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrequencyDictionary {
    public class MyFrequencyDictionary {
        public Dictionary<string, int> Frequency{ get; }

        private IEnumerable<string> GetWords(string text) {
            return text.Split('\n', '\r', '.', ',', ' ', '!', '?', ':', ';')
                .Where(word => word.Length > 0);
        }

        private void Save(string pathToDir) {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathToDir);

            foreach (var fileInfo in directoryInfo.GetFiles()) {
                using (var stream = new StreamReader(fileInfo.FullName)) {
                    string text = stream.ReadToEnd();

                    foreach (var word in GetWords(text)) {
                        if (Frequency.ContainsKey(word)) ++Frequency[word];
                        else Frequency.Add(word, 1);
                    }
                }
            }
        }

        public MyFrequencyDictionary(string pathToDir) {
            Frequency = new Dictionary<string, int>();

            Save(pathToDir);
        }
    }
}