#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VAEProgramEx.LineProcessor;
using Test;

#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2018 (c) by VAE Program Ex All Rights Reserved.
//  
// Project:      Line Processor
// Module:       TupleTest.cs
// Description:  Tests for the BigramTuple class in the Line Processor assembly.
//  
// Date:       Author:           Comments:
// 7/13/2018 9:51 PM  Rob Sharma     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace VAEProgramEx.LineProcessorTest
{

    /// <summary>
    /// Tests for the BigramTuple Class
    /// Documentation: Class BigramTuple. This is a class to hold each element and provide processing for those elements
    /// </summary>
    [TestClass()]
    public class TupleTest
    {
        #region Class Variables
        private TestContext testContextInstance;
        private LineProcessor.BigramTuple<string,string,int> _bigramTuple;
        #endregion

        #region Setup/Teardown

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            //New instance of BigramTuple
            _bigramTuple = new LineProcessor.BigramTuple<string, string, int>();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TestCleanup()]
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
        [TestMethod()]
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
        [TestMethod()]
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
        [TestMethod()]
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
        [TestMethod()]

        public void EqualsTest()
        {
            DateTime methodStartTime = DateTime.Now;
            bool expected = true;

            //Parameters
            object obj = new object();

            bool results = _bigramTuple.Equals(obj);
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.BigramTuple.Equals method test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.BigramTuple.Equals Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// Get Hash Code Method Test
        /// Documentation   :  Returns a hash code for this instance.
        /// Method Signature:  int GetHashCode()
        /// </summary>
        [TestMethod()]

        public void GetHashCodeTest()
        {
            DateTime methodStartTime = DateTime.Now;
            int expected = 123;

            //Parameters

            int results = _bigramTuple.GetHashCode();
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.BigramTuple.GetHashCode method test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.BigramTuple.GetHashCode Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// op Equality Method Test
        /// Documentation   :  Implements the == operator.
        /// Method Signature:  bool operator ==(BigramTuple&lt;T1, T2, T3&gt; tuple1, BigramTuple&lt;T1, T2, T3&gt; tuple2)
        /// </summary>
        [TestMethod()]

        public void op_EqualityTest()
        {
            DateTime methodStartTime = DateTime.Now;
            bool expected = true;

            //Parameters

            LineProcessor.BigramTuple<string, string, int> tuple2 = new LineProcessor.BigramTuple<string, string, int>();

            bool results = _bigramTuple == tuple2;
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.BigramTuple.op_Equality method test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.BigramTuple.op_Equality Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// op Inequality Method Test
        /// Documentation   :  Implements the != operator.
        /// Method Signature:  bool operator !=(BigramTuple&lt;T1, T2, T3&gt; tuple1, BigramTuple&lt;T1, T2, T3&gt; tuple2)
        /// </summary>
        [TestMethod()]

        public void op_InequalityTest()
        {
            DateTime methodStartTime = DateTime.Now;
            bool expected = true;

            //Parameters

            LineProcessor.BigramTuple<string, string, int> tuple2 = new LineProcessor.BigramTuple<string, string, int>();

            bool results = _bigramTuple != tuple2;
            Assert.AreEqual(expected, results, "VAEProgramEx.LineProcessor.BigramTuple.op_Inequality method test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.LineProcessor.BigramTuple.op_Inequality Time Elapsed: {0}", methodDuration));
        }

        #endregion

    }

   
}

namespace Test
{
}