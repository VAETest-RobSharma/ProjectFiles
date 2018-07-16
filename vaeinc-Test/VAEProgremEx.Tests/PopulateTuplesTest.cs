#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VAEProgramEx.LineProcessor;

#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2018 (c) by VAE Program Ex All Rights Reserved.
//  
// Project:      Line Processor
// Module:       PopulateTuplesTest.cs
// Description:  Tests for the Populate Tuples class in the Line Processor assembly.
//  
// Date:       Author:           Comments:
// 7/13/2018 10:33 PM  Rob Sharma     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace VAEProgramEx.LineProcessorTest
{

    /// <summary>
    /// Tests for the Populate Tuples Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Populate Tuples")]
    public class PopulateTuplesTest
    {
        #region Class Variables
        private PopulateTuples _populateTuples;
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
            //New instance of Populate Tuples
            _populateTuples = new PopulateTuples();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _populateTuples or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        /// <summary>
        /// Populate Tuples From Line Method Test
        /// Documentation   :  Populates the tuples from line.
        /// Method Signature:  void PopulateTuplesFromLine(string[] wordList, List&lt;LineProcessor.BigramTuple&lt;string, string, int&gt;&gt; openWith)
        /// </summary>
        [Test]

        public void PopulateTuplesFromLineTest()
        {
            DateTime methodStartTime = DateTime.Now;

            //Parameter Definitions
            string[] wordList = new string[20];
            List<LineProcessor.BigramTuple<string, string, int>> openWith = new List<LineProcessor.BigramTuple<string, string, int>>();

            //Default Value Test
            PopulateTuples.PopulateTuplesFromLine(wordList, openWith);

            PopulateTuples.PopulateTuplesFromLine(wordList, openWith);

            

            PopulateTuples.PopulateTuplesFromLine(wordList, openWith);

            PopulateTuples.PopulateTuplesFromLine(wordList, openWith);

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.PopulateTuples.PopulateTuplesFromLine Time Elapsed: {0}", methodDuration));
        }

        #endregion

    }
}
