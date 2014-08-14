//===============================================================================
// Microsoft patterns & practices
// SharePoint Guidance version 2.0
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.SPG.Common.Logging;

namespace Microsoft.Practices.SPG.Tests.Components.Logging
{
    /// <summary>
    /// Summary description for SharePointLoggerTest
    /// </summary>
    [TestClass]
    public class SharePointLoggerTest
    {
        #region AutoGenerated
        public SharePointLoggerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        #endregion

        /// <summary>
        /// Test Case to test the TraceLogger Property
        /// </summary>
        [TestMethod]
        public void TraceLoggerPropertyTest()
        {
            SharePointLogger logger = new SharePointLogger();
            try
            {
                ITraceLogger iTLogger = logger.TraceLogger;
                TraceLogger tlogger = new TraceLogger();
                if (!iTLogger.GetType().IsInterface)
                    if (iTLogger.GetType().ToString() == tlogger.GetType().ToString())
                        Assert.IsTrue(true);
                    else
                        Assert.Fail("There is a type mismatch");
                else
                    Assert.Fail("Interface was returned");
                    
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Case to test EventLogLogger Property
        /// </summary>
        [TestMethod]
        public void EventLogLoggerPropertyTest()
        {
            SharePointLogger logger = new SharePointLogger();           
            try
            {
                IEventLogLogger iELogger = logger.EventLogLogger;
                EventLogLogger elogger = new EventLogLogger();
                if (!iELogger.GetType().IsInterface)
                    if (iELogger.GetType().ToString() == elogger.GetType().ToString())
                        Assert.IsTrue(true);
                    else
                        Assert.Fail("There is a type mismatch");
                else
                    Assert.Fail("Interface was returned");

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }       
    
    }
}