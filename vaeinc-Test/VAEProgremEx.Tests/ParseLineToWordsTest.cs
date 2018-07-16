#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VAEProgramEx.LineProcessor;
using System.Linq;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2018 (c) by VAE Program Ex All Rights Reserved.
//  
// Project:      Line Processor
// Module:       ParseLineToWordsTest.cs
// Description:  Tests for the Parse Line To Words class in the Line Processor assembly.
//  
// Date:       Author:           Comments:
// 7/13/2018 10:33 PM  Rob Sharma     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace VAEProgramEx.LineProcessorTest
{

    /// <summary>
    /// Tests for the Parse Line To Words Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Parse Line To Words")]
    public class ParseLineToWordsTest
    {
        #region Class Variables
        private ParseLineToWords _parseLineToWords;
        #endregion

        #region Setup/Teardown

        /// <summary>
        /// Code that is run once for a suite of tests
        /// </summary>
        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {

        }

        /// <summary>
        /// Code that is run once after a suite of tests has finished executing
        /// </summary>
        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {

        }

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            //New instance of Parse Line To Words
            _parseLineToWords = new ParseLineToWords();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _parseLineToWords or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        /// <summary>
        /// Setup Words From Line Method Test
        /// Documentation   :  Setups the words from line.
        /// Method Signature:  string[] SetupWordsFromLine(string line)
        /// </summary>
        [Test]

        public void SetupWordsFromLineTest()
        {
            DateTime methodStartTime = DateTime.Now;
            string[] expected = new string[20];

            //Parameter Definitions
            string line = "test";

          
            string[] results = ParseLineToWords.SetupWordsFromLine(line);
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.ParseLineToWords.SetupWordsFromLine method null test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.ParseLineToWords.SetupWordsFromLine Time Elapsed: {0}", methodDuration));
        }

        #endregion

    }
}
