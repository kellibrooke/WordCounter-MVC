using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
      [TestMethod]
      public void GetSetUserSentence_ValidatesConvertsUserSentence_String()
      {
        RepeatCounter newTest = new RepeatCounter();
        string testUserInput = "A test. for a TEST";
        newTest.SetUserSentence(testUserInput);
        string actual = newTest.GetUserSentence();
        string expected = "a test for a test";
        Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void GetSetUserCheckWord_ValidatesConvertsUserWord_String()
      {
        RepeatCounter newTest = new RepeatCounter();
        string testUserInput = "Test's";
        newTest.SetUserCheckWord(testUserInput);
        string actual = newTest.GetUserCheckWord();
        string expected = "tests";
        Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void GetSetWordTally_CreatesWordTally_Int()
      {
        RepeatCounter newTest = new RepeatCounter();
        string testUserSentence = "it isn't fair is it?";
        string testUserWord = "it";
        newTest.SetUserCheckWord(testUserWord);
        newTest.SetUserSentence(testUserSentence);
        newTest.SetWordTally();
        Dictionary<string, int> returnedTally = newTest.GetWordTally();
        int actual = returnedTally["it"];
        int expected = 2;
        Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void WordRepeatAmount_CountsNumberOfRepeatsOfUserCheckWord_Int()
      {
        RepeatCounter newTest = new RepeatCounter();
        string testUserSentence = "it isn't fair is it?";
        string testUserWord = "it";
        newTest.SetUserCheckWord(testUserWord);
        newTest.SetUserSentence(testUserSentence);
        newTest.SetWordTally();
        int expected = 2;
        int actual = newTest.WordRepeatAmount();
        Assert.AreEqual(expected, actual);
      }
    }
}
