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
      public void GetSetUserSentence_ValidatesConvertsUserSentence_LowercaseArrayOfWords()
      {
        RepeatCounter newTest = new RepeatCounter();
        string testUserInput = "A test. for a TEST";
        newTest.SetUserSentence(testUserInput);
        string actual = newTest.GetUserSentence();
        string expected = "a test for a test";
        Assert.AreEqual(expected, actual);
      }

    //   [TestMethod]
    //   public void SetGetUserCheckWord_SetsGetsUserCheckWord_String()
    //   {
    //     RepeatCounter newTest = new RepeatCounter();
    //     string testUserInput = "test";
    //     newTest.SetUserCheckWord(testUserInput);
    //     string actual = newTest.GetUserCheckWord();
    //     string expected = "test";
    //     Assert.AreEqual(expected, actual);
    //   }
    //
    //     [TestMethod]
    //     public void SentenceToWords_SplitsSentenceIntoWords_StringArray()
    //     {
    //       RepeatCounter newTest = new RepeatCounter();
    //       string testString = "test string";
    //       string[] expected =  { "test", "string" };
    //       string[] actual = newTest.SentenceToWords(testString);
    //       CollectionAssert.AreEqual(expected, actual);
    //     }
    //
    //     [TestMethod]
    //     public void SentenceContainsNoPunctuation_ChecksWordCharsAreLetters_True()
    //     {
    //       RepeatCounter newTest = new RepeatCounter();
    //       string[] testString = { "test", "is", "good" };
    //       bool expected =  true;
    //       bool actual = newTest.SentenceContainsNoPunctuation(testString);
    //       Assert.AreEqual(expected, actual);
    //     }
    //
    //     [TestMethod]
    //     public void SentenceContainsNoPunctuation_ChecksWordCharsAreLetters_False()
    //     {
    //       RepeatCounter newTest = new RepeatCounter();
    //       string [] testString = { "test", "is", "good." };
    //       bool expected =  false;
    //       bool actual = newTest.SentenceContainsNoPunctuation(testString);
    //       Assert.AreEqual(expected, actual);
    //     }
    //
    //     [TestMethod]
    //     public void CreateWordTally_ChecksWordsAddedValuesCorrect_DictDef()
    //     {
    //       RepeatCounter newTest = new RepeatCounter();
    //       string[] testWords = { "test", "words", "test"};
    //       int expected = 2;
    //       newTest.CreateWordTally(testWords);
    //       Dictionary<string, int> actualTally = newTest.GetWordTally();
    //       actualTally.TryGetValue("test", out int actual);
    //       Assert.AreEqual(expected, actual);
    //     }
    //
    //     [TestMethod]
    //     public void WordRepeatAmount_ChecksHowManyTimesWordRepeats_Int()
    //     {
    //       RepeatCounter newTest = new RepeatCounter();
    //       string[] testWords = { "test", "words", "test"};
    //       string testUserWord = "test";
    //       int expected = 2;
    //       newTest.CreateWordTally(testWords);
    //       int actual = newTest.WordRepeatAmount(testUserWord);
    //       Assert.AreEqual(expected, actual);
    //     }
    }
}
