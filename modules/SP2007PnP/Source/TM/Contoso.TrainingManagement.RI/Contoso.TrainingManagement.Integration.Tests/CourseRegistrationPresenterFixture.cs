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
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.SharePoint;

using Contoso.TrainingManagement.Mocks;
using Contoso.TrainingManagement.Forms;
using Contoso.TrainingManagement.Repository;
using Contoso.TrainingManagement.Repository.BusinessEntities;
using System.Configuration;

namespace Contoso.TrainingManagement.IntegrationTests
{
    /// <summary>
    /// Summary description for CourseRegistrationFixture
    /// </summary>
    [TestClass]
    public class CourseRegistrationPresenterFixture
    {
        #region Private Fields

        private readonly ServiceLocator serviceLocator = ServiceLocator.GetInstance();
        private readonly string siteUrl = ConfigurationManager.AppSettings["SiteUrl"];
        private SPWeb web;

        #endregion

        #region Test Initialize

        [TestInitialize]
        public void TestInit()
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                web = site.AllWebs.Add(Guid.NewGuid().ToString(), "", "", 1033, "CONTOSOTRAINING#0", false, false);
            }

            ServiceLocator.Clear();
            MockRegistrationRepository.Clear();
        }

        #endregion

        #region Test Cleanup

        [TestCleanup]
        public void TestCleanup()
        {
            web.Delete();
            web.Dispose();

            serviceLocator.Reset();
        }

        #endregion

        #region Test Methods

        #region RenderCourseRegistrationView

        #region Without Registration

        [TestMethod]
        public void RenderCourseRegistrationPopulatesView()
        {
            string loginName = Environment.UserDomainName + "\\" + Environment.UserName;
            
            string courseId = "1";

            MockCourseRegistrationView mockView = new MockCourseRegistrationView();
            mockView.QueryString = new System.Collections.Specialized.NameValueCollection();
            mockView.QueryString["ID"] = courseId;

            TrainingCourse course = new TrainingCourse() { Id = 1, Code = "TestCode" };
            MockTrainingCourseRepository.TrainingCourseReturnedByGet = course;

            this.serviceLocator.Register<IRegistrationRepository>(typeof(MockRegistrationRepository));
            this.serviceLocator.Register<ITrainingCourseRepository>(typeof(MockTrainingCourseRepository));

            CourseRegistrationPresenter presenter = new CourseRegistrationPresenter(mockView);
            presenter.RenderCourseRegistrationView(web, loginName);

            Assert.AreEqual<string>("Course Registration - TestCode", mockView.PageTitle);
            Assert.AreEqual<string>("Course Registration", mockView.HeaderTitle);
            Assert.AreEqual<string>("TestCode", mockView.HeaderSubtitle);
            Assert.AreEqual<string>("Would you like to register for course: TestCode?", mockView.ContentMessage);
            Assert.IsTrue(mockView.ShowConfirmationControls);
            Assert.IsFalse(mockView.ShowCourseSelectionControls);
            Assert.AreEqual(web.Url, mockView.SiteLink);
        }

        [TestMethod]
        public void RenderCourseRegistrationPopulatesViewWithCourseSelectionList()
        {
            string loginName = Environment.UserDomainName + "\\" + Environment.UserName;

            MockCourseRegistrationView mockView = new MockCourseRegistrationView();
            mockView.QueryString = new System.Collections.Specialized.NameValueCollection();

            TrainingCourse course = new TrainingCourse()
                                        {
                                            Id = 1,
                                            Code = "TestCode"
                                        };
            MockTrainingCourseRepository.TrainingCourseReturnedByGet = course;
            List<TrainingCourse> courses = new List<TrainingCourse>();
            TrainingCourse course1 = new TrainingCourse()
                                         {
                                             Id = 1,
                                             Code = "TstCode1"
                                         };
            TrainingCourse course2 = new TrainingCourse()
                                         {
                                             Id = 2,
                                             Code = "TstCode2"
                                         };
            courses.Add(course1);
            courses.Add(course2);
            MockTrainingCourseRepository.TrainingCourseListReturnedByGet = courses;

            this.serviceLocator.Register<IRegistrationRepository>(typeof(MockRegistrationRepository));
            this.serviceLocator.Register<ITrainingCourseRepository>(typeof(MockTrainingCourseRepository));

            CourseRegistrationPresenter presenter = new CourseRegistrationPresenter(mockView);
            presenter.RenderCourseRegistrationView(web, loginName);

            Assert.AreEqual<string>("Course Registration", mockView.HeaderTitle);
            Assert.AreEqual<string>("Course Registration - New", mockView.PageTitle);
            Assert.AreEqual<string>("New", mockView.HeaderSubtitle);
            Assert.AreEqual<string>("Which course would you like to register for?", mockView.ContentMessage);
            Assert.IsNotNull(mockView.Courses);
            Assert.AreEqual(2, mockView.Courses.Count);
            Assert.AreEqual("TstCode1", mockView.Courses[0].Code);
            Assert.AreEqual("TstCode2", mockView.Courses[1].Code);
            Assert.IsTrue(mockView.ShowConfirmationControls);
            Assert.IsTrue(mockView.ShowCourseSelectionControls);
            Assert.AreEqual(web.Url, mockView.SiteLink);
        }

        [TestMethod]
        public void RenderWithNoCourse()
        {
            string loginName = Environment.UserDomainName + "\\" + Environment.UserName;
            string courseId = "999999";

            MockCourseRegistrationView mockView = new MockCourseRegistrationView();
            mockView.QueryString = new System.Collections.Specialized.NameValueCollection();
            mockView.QueryString["ID"] = courseId;

            MockTrainingCourseRepository.TrainingCourseReturnedByGet = null;

            this.serviceLocator.Register<ITrainingCourseRepository>(typeof(MockTrainingCourseRepository));

            CourseRegistrationPresenter presenter = new CourseRegistrationPresenter(mockView);
            presenter.RenderCourseRegistrationView(web, loginName);

            Assert.AreEqual<string>("Course Registration - Failure", mockView.PageTitle);
            Assert.AreEqual<string>("Course Registration", mockView.HeaderTitle);
            Assert.AreEqual<string>("Failure", mockView.HeaderSubtitle);
            Assert.AreEqual<string>("The Course selected was not a valid.", mockView.ContentMessage);
            Assert.AreEqual(web.Url, mockView.SiteLink);
            Assert.IsFalse(mockView.ShowConfirmationControls);
            Assert.IsFalse(mockView.ShowCourseSelectionControls);
        }

        [TestMethod]
        public void RenderWithExistingRegistration()
        {
            string loginName = Environment.UserDomainName + "\\" + Environment.UserName;
            string courseId = "1";

            MockCourseRegistrationView mockView = new MockCourseRegistrationView();
            mockView.QueryString = new System.Collections.Specialized.NameValueCollection();
            mockView.QueryString["ID"] = courseId;

            TrainingCourse course = new TrainingCourse() { Id = 1, Code = "TestCode" };
            MockTrainingCourseRepository.TrainingCourseReturnedByGet = course;

            Registration registration = new Registration();
            registration.RegistrationStatus = "Pending";
            MockRegistrationRepository.RegistrationReturnedByGet = registration;

            this.serviceLocator.Register<IRegistrationRepository>(typeof(MockRegistrationRepository));
            this.serviceLocator.Register<ITrainingCourseRepository>(typeof(MockTrainingCourseRepository));

            CourseRegistrationPresenter presenter = new CourseRegistrationPresenter(mockView);
            presenter.RenderCourseRegistrationView(web, loginName);

            Assert.AreEqual<string>("Course Registration - TestCode", mockView.PageTitle);
            Assert.AreEqual<string>("Course Registration", mockView.HeaderTitle);
            Assert.AreEqual<string>("TestCode", mockView.HeaderSubtitle);
            Assert.AreEqual<string>("A registration request for this Course with the status of 'Pending' has already been submitted by you.", mockView.ContentMessage);
            Assert.AreEqual(web.Url, mockView.SiteLink);
            Assert.IsFalse(mockView.ShowConfirmationControls);
            Assert.IsFalse(mockView.ShowCourseSelectionControls);
        }

        #endregion 

        #region With Registration

        [TestMethod]
        public void RegisterCourseAndPopulateConfirmation()
        {
            string loginName = Environment.UserDomainName + "\\" + Environment.UserName;
            string courseId = "1";

            MockCourseRegistrationView mockView = new MockCourseRegistrationView();
            mockView.QueryString = new System.Collections.Specialized.NameValueCollection();
            mockView.QueryString["ID"] = courseId;

            MockRegistrationRepository.RegistrationReturnedByGet = null;

            TrainingCourse course = new TrainingCourse() { Id = 1, Title = "TestTitle", Code = "TestCode" };
            MockTrainingCourseRepository.TrainingCourseReturnedByGet = course;

            this.serviceLocator.Register<IRegistrationRepository>(typeof(MockRegistrationRepository));
            this.serviceLocator.Register<ITrainingCourseRepository>(typeof(MockTrainingCourseRepository));

            CourseRegistrationPresenter presenter = new CourseRegistrationPresenter(mockView);
            presenter.Register(web, loginName);

            Assert.AreEqual<string>("Course Registration - TestCode", mockView.PageTitle);
            Assert.AreEqual<string>("Course Registration", mockView.HeaderTitle);
            Assert.AreEqual<string>("TestCode", mockView.HeaderSubtitle);
            Assert.AreEqual<string>("Your registration request for TestCode has been submitted.", mockView.ContentMessage);
            Assert.AreEqual(web.Url, mockView.SiteLink);
            Assert.IsFalse(mockView.ShowConfirmationControls);
            Assert.IsFalse(mockView.ShowCourseSelectionControls);
        }

        [TestMethod]
        public void RegisterCourseAndPopulateConfirmationWithSelectedCourse()
        {
            string loginName = Environment.UserDomainName + "\\" + Environment.UserName;
            string courseId = "1";

            MockCourseRegistrationView mockView = new MockCourseRegistrationView();
            mockView.QueryString = new System.Collections.Specialized.NameValueCollection();
            mockView.SelectedCourse = courseId;

            MockRegistrationRepository.RegistrationReturnedByGet = null;

            TrainingCourse course = new TrainingCourse()
                                        {
                                            Id = 1,
                                            Title = "TestTitle",
                                            Code = "TestCode"
                                        };
            MockTrainingCourseRepository.TrainingCourseReturnedByGet = course;

            this.serviceLocator.Register<IRegistrationRepository>(typeof(MockRegistrationRepository));
            this.serviceLocator.Register<ITrainingCourseRepository>(typeof(MockTrainingCourseRepository));

            CourseRegistrationPresenter presenter = new CourseRegistrationPresenter(mockView);
            presenter.Register(web, loginName);

            Assert.AreEqual(1, MockRegistrationRepository.RegistrationReturnedByGet.CourseId);
            Assert.AreEqual("Pending", MockRegistrationRepository.RegistrationReturnedByGet.RegistrationStatus);
            Assert.AreEqual<string>("Course Registration - TestCode", mockView.PageTitle);
            Assert.AreEqual<string>("Course Registration", mockView.HeaderTitle);
            Assert.AreEqual<string>("TestCode", mockView.HeaderSubtitle);
            Assert.AreEqual<string>("Your registration request for TestCode has been submitted.", mockView.ContentMessage);
            Assert.AreEqual(web.Url, mockView.SiteLink);
            Assert.IsFalse(mockView.ShowConfirmationControls);
            Assert.IsFalse(mockView.ShowCourseSelectionControls);
        }

        #endregion

        #endregion

        #endregion

        #region Private Mock Setup

        private class MockCourseRegistrationView : ICourseRegistrationView
        {
            #region ICourseRegistrationView Members

            public string PageTitle
            {
                get;
                set;
            }

            public string HeaderTitle
            {
                get;
                set;
            }

            public string HeaderSubtitle
            {
                get;
                set;
            }

            public string ContentMessage
            {
                get;
                set;
            }

            public bool ShowConfirmationControls
            {
                get;
                set;
            }

            public IList<TrainingCourse> Courses
            {
                get;
                set;
            }

            public bool ShowCourseSelectionControls
            {
                get;
                set;
            }

            public System.Collections.Specialized.NameValueCollection QueryString
            {
                get;
                set;
            }

            public string SelectedCourse
            {
                get;
                set;
            }

            public string SiteLink
            {
                get;
                set;
            }

            #endregion
        }

        #endregion
    }
}