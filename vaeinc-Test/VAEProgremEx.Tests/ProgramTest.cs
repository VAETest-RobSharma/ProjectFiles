#region Includes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NUnit.Framework;
using VAEProgramEx;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Runtime.Remoting.Lifetime;
using System.Threading.Tasks;
using VAEProgramEx.LineProcessor;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2018 (c) by VAE Program Ex All Rights Reserved.
//  
// Project:      
// Module:       ProgramTest.cs
// Description:  Tests for the Program class in the Veterans Administrationdverse Event Program Ex assembly.
//  
// Date:       Author:           Comments:
// 7/13/2018 10:34 PM  Rob Sharma     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace VAEProgramExTest
{

    /// <summary>
    /// Tests for the Program Class
    /// Documentation: 
    /// </summary>
    [TestFixture, System.ComponentModel.Description("Tests for Program")]
    public class ProgramTest
    {
        #region Class Variables
        private Program _program;
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
            //New instance of Program
            _program = new Program();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _program or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        /// <summary>
        /// Main Method Test
        /// Documentation   :  Defines the entry point of the application.
        /// Method Signature:  void Main(string[] args)
        /// </summary>
        [Test]
        public void MainTest()
        {
            DateTime methodStartTime = DateTime.Now;

            //Parameter Definitions
            string[] args = new string[20];

            //Default Value Test
            Program.Main(args);

            Program.Main(args);

            

            Program.Main(args);

            Program.Main(args);

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("VAEProgramEx.Program.Main Time Elapsed: {0}", methodDuration));
        }

        #endregion

    }
}
