#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Test;
using VAEProgramEx.LineProcessor;

#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2018 (c) by VAE Program Ex All Rights Reserved.
//  
// Project:      Line Processor
// Module:       BigramTupleTest.cs
// Description:  Tests for the Bigram Tuple class in the Line Processor assembly.
//  
// Date:       Author:           Comments:
// 7/13/2018 10:33 PM  Rob Sharma     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace VAEProgramEx.LineProcessorTest
{

    /// <summary>
    /// Tests for the Bigram Tuple Class
    /// Documentation: Class BigramTuple. This is a class to hold each element and provide processing for those elements
    /// </summary>
    [TestFixture, Description("Tests for Bigram Tuple")]
    public class BigramTupleTest
    {
        #region Class Variables
        private BigramTuple<T1,T2,T3> _bigramTuple;
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
            //New instance of Bigram Tuple
            _bigramTuple = new BigramTuple<T1, T2, T3>();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _bigramTuple or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        /// <summary>
        /// Word 1 Property Test
        /// Documentation:  
        /// Property Type:  T1
        /// Access       :  Read/Write
        /// </summary>
        [Test]

        public void Word1Test()
        {
            T1 expected = new T1();
            _bigramTuple.Word1 = expected;
            Assert.AreEqual(expected, _bigramTuple.Word1, "VAEProgramEx.LineProcessor.BigramTuple.Word1 property test failed");
        }

        /// <summary>
        /// Word 2 Property Test
        /// Documentation:  
        /// Property Type:  T2
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        public void Word2Test()
        {
            T2 expected = new T2();
            _bigramTuple.Word2 = expected;
            Assert.AreEqual(expected, _bigramTuple.Word2, "VAEProgramEx.LineProcessor.BigramTuple.Word2 property test failed");
        }

        /// <summary>
        /// Bigram Count Property Test
        /// Documentation:  
        /// Property Type:  T3
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        public void BigramCountTest()
        {
            T3 expected = new T3();
            _bigramTuple.BigramCount = expected;
            Assert.AreEqual(expected, _bigramTuple.BigramCount, "VAEProgramEx.LineProcessor.BigramTuple.BigramCount property test failed");
        }

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        /// <summary>
        /// Equals Method Test
        /// Documentation   :  Determines whether the specified &lt;see cref="System.Object" /&gt; is equal to this instance.
        /// Method Signature:  bool Equals(object obj)
        /// </summary>
        [Test]
        public void EqualsTest()
        {
            DateTime methodStartTime = DateTime.Now;
            bool expected = true;

            //Parameter Definitions
            object obj = new object();

               

                      bool results = _bigramTuple.Equals(obj);
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.BigramTuple.Equals method null test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.BigramTuple.Equals Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// Get Hash Code Method Test
        /// Documentation   :  Returns a hash code for this instance.
        /// Method Signature:  int GetHashCode()
        /// </summary>
        [Test]
        public void GetHashCodeTest()
        {
            DateTime methodStartTime = DateTime.Now;
            int expected = 123;

            //Parameter Definitions

   
            int results = _bigramTuple.GetHashCode();
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.BigramTuple.GetHashCode method min test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.BigramTuple.GetHashCode Time Elapsed: {0}", methodDuration));
        }

        #endregion

    }
}
