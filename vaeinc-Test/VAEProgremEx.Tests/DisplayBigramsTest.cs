#region Includes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NUnit.Framework;
using VAEProgramEx;
using VAEProgramEx.LineProcessor;
using System.Linq;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2018 (c) by VAE Program Ex All Rights Reserved.
//  
// Project:      
// Module:       DisplayBigramsTest.cs
// Description:  Tests for the Display Bigrams class in the Veterans Administrationdverse Event Program Ex assembly.
//  
// Date:       Author:           Comments:
// 7/13/2018 10:34 PM  Rob Sharma     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace VAEProgramExTest
{

    /// <summary>
    /// Tests for the Display Bigrams Class
    /// Documentation: Class DisplayBigrams. Used for diplaying bigrams - histograms in console
    /// </summary>
    [TestFixture, NUnit.Framework.Description("Tests for Display Bigrams")]
    public class DisplayBigramsTest
    {
        #region Class Variables
        private DisplayBigrams _displayBigrams;
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
            //New instance of Display Bigrams
            _displayBigrams = new DisplayBigrams();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _displayBigrams or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

  }
}
