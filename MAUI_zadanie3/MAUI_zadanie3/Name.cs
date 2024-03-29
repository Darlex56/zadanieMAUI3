using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_zadanie3
{
    class Name
    {
        Random random;
        String[] name = { "Bob", "Ana", "Marek", "Jozef", "Mir3k", "Erik", "David", "Andrej", "Adam", "Erika", "Monika", "Martin", "Samuel"};
        String[] sentences = { "%d started following you.", "%d liked your photo.", "%d sent a photo posted by @", "Your friend %d is on Instagram."};

        public string chooseName() {
            random = new Random();

            return name[random.Next(name.Length - 1)];
        }

        public string[] chooseSentence()
        {
            random = new Random();
            string sentence = sentences[random.Next(sentences.Length - 1)];
            string name = chooseName();
            if (sentence.Contains("%d")) {
                sentence = sentence.Replace("%d", name);
            }
            if (sentence.Contains("@")) {
                random = new Random();

                sentence = sentence.Replace("@", "@" + name);
            }
            return [sentence, name];
        }
    }
}
