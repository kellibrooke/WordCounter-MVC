using System;
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
            char[] badChars = { ',', '.', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
            string betterSentence = lowerCaseSentence.Trim(badChars);
            _userSentence = betterSentence;
        }

        public string GetUserSentence()
        {
            return _userSentence;
        }

        public void SetUserCheckWord(string userWord)
        {
          string lowerCaseWord = userWord.ToLower();
          char[] badChars = { ',', '.', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };
          string betterWord = lowerCaseWord.Trim(badChars);
          _userCheckWord = betterWord;
        }

        public string GetUserCheckWord()
        {
            return _userCheckWord;
        }

        public Dictionary<string, int> GetWordTally()
        {
            return _wordTally;
        }

        public void CreateWordTally()
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
