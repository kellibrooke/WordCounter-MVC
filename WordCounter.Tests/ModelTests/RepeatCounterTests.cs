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


    }
}
