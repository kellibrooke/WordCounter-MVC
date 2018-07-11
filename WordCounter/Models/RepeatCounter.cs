using System;
using System.Text;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _userSentence;
        private string _userCheckWord;

        private Dictionary<string, int> _wordTally = new Dictionary<string, int>();

        public void SetUserSentence(string userSentence)
        {
            string lowerCaseSentence = userSentence.ToLower();
            StringBuilder punctFree = new StringBuilder();
            foreach (char letter in lowerCaseSentence)
            {
                if(!char.IsPunctuation(letter))
                {
                punctFree.Append(letter);
                }
            }
            _userSentence = punctFree.ToString();
        }

        public string GetUserSentence()
        {
            return _userSentence;
        }

        public void SetUserCheckWord(string userWord)
        {
          string lowerCaseWord = userWord.ToLower();
          StringBuilder punctFree = new StringBuilder();
          foreach (char letter in lowerCaseWord)
          {
              if(!char.IsPunctuation(letter))
              {
              punctFree.Append(letter);
              }
          }
          _userCheckWord = punctFree.ToString();
        }

        public string GetUserCheckWord()
        {
            return _userCheckWord;
        }

        public Dictionary<string, int> GetWordTally()
        {
            return _wordTally;
        }

        public void SetWordTally()
        {
            string[] wordArray = _userSentence.Split(' ');
            foreach (string word in wordArray)
            {
              if (_wordTally.ContainsKey(word))
              {
                  _wordTally[word] += 1;
              }
              else
              {
                  _wordTally.Add(word, 1);
              }
            }
        }

        public int WordRepeatAmount()
        {
            int numberOfRepeats;
            _wordTally.TryGetValue(_userCheckWord, out numberOfRepeats);
            return numberOfRepeats;
        }

    }
}
