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
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingManagementBVT
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    using TrainingManagementAcceptanceTest.HelperClasses;
    /// <summary>
    /// 1.create course with admin login
    /// 2.try to get create course with existing code and should get error to user.
    /// </summary>
    public class WT_CreateExistingCourse : WebTest
    {

        string myCourseCode = Config.NewCourseCode();
        string siteURL = Config.siteURL;
        string webURL = Config.webURL;
        public WT_CreateExistingCourse()
        {
            this.PreAuthenticate = true;
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {

          
//            this.UserName = Config.adminUser;
//            this.Password = Config.adminPass;
          //create course first time  
            
            WebTestRequest request99 = new WebTestRequest(this.siteURL + this.webURL + "/Lists/TrainingCourses/NewForm.aspx");
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request99.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            ExtractText extractionRule99 = new ExtractText();
            extractionRule99.StartsWith = "ctl00_m_g_";
            extractionRule99.EndsWith = "_ctl";
            extractionRule99.IgnoreCase = false;
            extractionRule99.UseRegularExpression = true;
            extractionRule99.Required = true;
            extractionRule99.ExtractRandomMatch = false;
            extractionRule99.Index = 0;
            extractionRule99.HtmlDecode = true;

            extractionRule99.ContextParameterName = "guid";
            request99.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule99.Extract);



            yield return request99;
            string guidPrefix = "ctl00$m$g_";
            string guid = Context["guid"].ToString();
            request99 = null;
            this.BeginTransaction("createCourse");
            WebTestRequest request2 = new WebTestRequest(this.siteURL + this.webURL + "/Lists/TrainingCourses/NewForm.aspx");
            request2.Method = "POST";
            FormPostHttpBody request2Body = new FormPostHttpBody();
            request2Body.FormPostParameters.Add("MSO_PageHashCode", this.Context["$HIDDEN1.MSO_PageHashCode"].ToString());
            request2Body.FormPostParameters.Add("MSOWebPartPage_PostbackSource", this.Context["$HIDDEN1.MSOWebPartPage_PostbackSource"].ToString());
            request2Body.FormPostParameters.Add("MSOTlPn_SelectedWpId", this.Context["$HIDDEN1.MSOTlPn_SelectedWpId"].ToString());
            request2Body.FormPostParameters.Add("MSOTlPn_View", this.Context["$HIDDEN1.MSOTlPn_View"].ToString());
            request2Body.FormPostParameters.Add("MSOTlPn_ShowSettings", this.Context["$HIDDEN1.MSOTlPn_ShowSettings"].ToString());
            request2Body.FormPostParameters.Add("MSOGallery_SelectedLibrary", this.Context["$HIDDEN1.MSOGallery_SelectedLibrary"].ToString());
            request2Body.FormPostParameters.Add("MSOGallery_FilterString", this.Context["$HIDDEN1.MSOGallery_FilterString"].ToString());
            request2Body.FormPostParameters.Add("MSOTlPn_Button", this.Context["$HIDDEN1.MSOTlPn_Button"].ToString());
            request2Body.FormPostParameters.Add("__EVENTTARGET", this.Context["$HIDDEN1.__EVENTTARGET"].ToString());
            request2Body.FormPostParameters.Add("__EVENTARGUMENT", this.Context["$HIDDEN1.__EVENTARGUMENT"].ToString());
            request2Body.FormPostParameters.Add("__REQUESTDIGEST", this.Context["$HIDDEN1.__REQUESTDIGEST"].ToString());
            request2Body.FormPostParameters.Add("MSOSPWebPartManager_DisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_DisplayModeName"].ToString());
            request2Body.FormPostParameters.Add("MSOWebPartPage_Shared", this.Context["$HIDDEN1.MSOWebPartPage_Shared"].ToString());
            request2Body.FormPostParameters.Add("MSOLayout_LayoutChanges", this.Context["$HIDDEN1.MSOLayout_LayoutChanges"].ToString());
            request2Body.FormPostParameters.Add("MSOLayout_InDesignMode", this.Context["$HIDDEN1.MSOLayout_InDesignMode"].ToString());
            request2Body.FormPostParameters.Add("MSOSPWebPartManager_OldDisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_OldDisplayModeName"].ToString());
            request2Body.FormPostParameters.Add("MSOSPWebPartManager_StartWebPartEditingName", this.Context["$HIDDEN1.MSOSPWebPartManager_StartWebPartEditingName"].ToString());
            request2Body.FormPostParameters.Add("__LASTFOCUS", this.Context["$HIDDEN1.__LASTFOCUS"].ToString());
            request2Body.FormPostParameters.Add("__VIEWSTATE", this.Context["$HIDDEN1.__VIEWSTATE"].ToString());
            request2Body.FormPostParameters.Add("__EVENTVALIDATION", this.Context["$HIDDEN1.__EVENTVALIDATION"].ToString());
          
            request2Body.FormPostParameters.Add("InputKeywords", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl00$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl01$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "<div></div>");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField_spSave", "<DIV></DIV>");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl03$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl04$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl05$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl06$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl07$ctl00$owshiddenversion" +
                    "", this.Context["$HIDDEN1." + guidPrefix + guid + "$ctl00$ctl07$ctl00$owshidd" +
                    "enversion"].ToString());
            request2Body.FormPostParameters.Add("attachmentsToBeRemovedFromServer", this.Context["$HIDDEN1.attachmentsToBeRemovedFromServer"].ToString());
            request2Body.FormPostParameters.Add("RectGifUrl", this.Context["$HIDDEN1.RectGifUrl"].ToString());
            request2Body.FormPostParameters.Add("fileupload0", "");
            request2Body.FormPostParameters.Add("__spDummyText1", "");
            request2Body.FormPostParameters.Add("__spDummyText2", "");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl07$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl03.x", "5");
            request2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl07$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl03.y", "8");
            request2.Body = request2Body;
            ExtractHiddenFields extractionRule2 = new ExtractHiddenFields();
            extractionRule2.Required = true;
            extractionRule2.HtmlDecode = true;
            extractionRule2.ContextParameterName = "1";
            request2.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule2.Extract);
            yield return request2;
            this.EndTransaction("createCourse");
            request2 = null;


            WebTestRequest request6 = new WebTestRequest(this.siteURL + this.webURL + "/Lists/TrainingCourses/NewForm.aspx");
            request6.Method = "POST";
            request6.ExpectedResponseUrl = this.siteURL + this.webURL + "/Lists/TrainingCourses/AllItems.aspx";
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("MSO_PageHashCode", this.Context["$HIDDEN1.MSO_PageHashCode"].ToString());
            request6Body.FormPostParameters.Add("MSOWebPartPage_PostbackSource", this.Context["$HIDDEN1.MSOWebPartPage_PostbackSource"].ToString());
            request6Body.FormPostParameters.Add("MSOTlPn_SelectedWpId", this.Context["$HIDDEN1.MSOTlPn_SelectedWpId"].ToString());
            request6Body.FormPostParameters.Add("MSOTlPn_View", this.Context["$HIDDEN1.MSOTlPn_View"].ToString());
            request6Body.FormPostParameters.Add("MSOTlPn_ShowSettings", this.Context["$HIDDEN1.MSOTlPn_ShowSettings"].ToString());
            request6Body.FormPostParameters.Add("MSOGallery_SelectedLibrary", this.Context["$HIDDEN1.MSOGallery_SelectedLibrary"].ToString());
            request6Body.FormPostParameters.Add("MSOGallery_FilterString", this.Context["$HIDDEN1.MSOGallery_FilterString"].ToString());
            request6Body.FormPostParameters.Add("MSOTlPn_Button", this.Context["$HIDDEN1.MSOTlPn_Button"].ToString());
            request6Body.FormPostParameters.Add("__EVENTTARGET", guidPrefix + guid + "$ctl00$toolBarTbl$RightRptControls$" +
                    "ctl00$ctl00$diidIOSaveItem");
            request6Body.FormPostParameters.Add("__EVENTARGUMENT", this.Context["$HIDDEN1.__EVENTARGUMENT"].ToString());
            request6Body.FormPostParameters.Add("__REQUESTDIGEST", this.Context["$HIDDEN1.__REQUESTDIGEST"].ToString());
            request6Body.FormPostParameters.Add("MSOSPWebPartManager_DisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_DisplayModeName"].ToString());
            request6Body.FormPostParameters.Add("MSOWebPartPage_Shared", this.Context["$HIDDEN1.MSOWebPartPage_Shared"].ToString());
            request6Body.FormPostParameters.Add("MSOLayout_LayoutChanges", this.Context["$HIDDEN1.MSOLayout_LayoutChanges"].ToString());
            request6Body.FormPostParameters.Add("MSOLayout_InDesignMode", this.Context["$HIDDEN1.MSOLayout_InDesignMode"].ToString());
            request6Body.FormPostParameters.Add("MSOSPWebPartManager_OldDisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_OldDisplayModeName"].ToString());
            request6Body.FormPostParameters.Add("MSOSPWebPartManager_StartWebPartEditingName", this.Context["$HIDDEN1.MSOSPWebPartManager_StartWebPartEditingName"].ToString());
            request6Body.FormPostParameters.Add("__VIEWSTATE", this.Context["$HIDDEN1.__VIEWSTATE"].ToString());
            request6Body.FormPostParameters.Add("__EVENTVALIDATION", this.Context["$HIDDEN1.__EVENTVALIDATION"].ToString());
            
            
            
            request6Body.FormPostParameters.Add("InputKeywords", "");
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl00$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField",this.myCourseCode );
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl01$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", this.myCourseCode);
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "<div></div>");
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField_spSave", this.myCourseCode + "\r\n<DIV></DIV>");
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl03$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", DateTime.Now.ToShortDateString());
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl04$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", DateTime.Now.ToShortDateString());
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl05$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", DateTime.Now.ToShortDateString());
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl06$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "100");
            request6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl07$ctl00$owshiddenversion" +
                    "", this.Context["$HIDDEN1." + guidPrefix + guid + "$ctl00$ctl07$ctl00$owshidd" +
                    "enversion"].ToString());
            request6Body.FormPostParameters.Add("attachmentsToBeRemovedFromServer", this.Context["$HIDDEN1.attachmentsToBeRemovedFromServer"].ToString());
            request6Body.FormPostParameters.Add("RectGifUrl", this.Context["$HIDDEN1.RectGifUrl"].ToString());
            request6Body.FormPostParameters.Add("fileupload0", "");
            request6Body.FormPostParameters.Add("__spDummyText1", "");
            request6Body.FormPostParameters.Add("__spDummyText2", "");
            request6.Body = request6Body;

            yield return request6;
            request6 = null;
            
           //validate created course exists in courses list
            if (SharePointCalls.GetCourseID(this.myCourseCode, siteURL, webURL) == 0)
              Outcome=  Outcome.Fail;

            //create same course again

            WebTestRequest Erequest99 = new WebTestRequest(this.siteURL + this.webURL + "/Lists/TrainingCourses/NewForm.aspx");
            ExtractHiddenFields EextractionRule1 = new ExtractHiddenFields();
            EextractionRule1.Required = true;
            EextractionRule1.HtmlDecode = true;
            EextractionRule1.ContextParameterName = "1";
            Erequest99.ExtractValues += new EventHandler<ExtractionEventArgs>(EextractionRule1.Extract);
            ExtractText EextractionRule99 = new ExtractText();
            EextractionRule99.StartsWith = "ctl00_m_g_";
            EextractionRule99.EndsWith = "_ctl";
            EextractionRule99.IgnoreCase = false;
            EextractionRule99.UseRegularExpression = true;
            EextractionRule99.Required = true;
            EextractionRule99.ExtractRandomMatch = false;
            EextractionRule99.Index = 0;
            EextractionRule99.HtmlDecode = true;

            EextractionRule99.ContextParameterName = "Eguid";
            Erequest99.ExtractValues += new EventHandler<ExtractionEventArgs>(EextractionRule99.Extract);
            yield return Erequest99;

            guidPrefix = "ctl00$m$g_";
            guid = Context["Eguid"].ToString();
            request99 = null;
            
            WebTestRequest Erequest2 = new WebTestRequest(this.siteURL + this.webURL + "/Lists/TrainingCourses/NewForm.aspx");
            Erequest2.Method = "POST";
            FormPostHttpBody Erequest2Body = new FormPostHttpBody();
            Erequest2Body.FormPostParameters.Add("MSO_PageHashCode", this.Context["$HIDDEN1.MSO_PageHashCode"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOWebPartPage_PostbackSource", this.Context["$HIDDEN1.MSOWebPartPage_PostbackSource"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOTlPn_SelectedWpId", this.Context["$HIDDEN1.MSOTlPn_SelectedWpId"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOTlPn_View", this.Context["$HIDDEN1.MSOTlPn_View"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOTlPn_ShowSettings", this.Context["$HIDDEN1.MSOTlPn_ShowSettings"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOGallery_SelectedLibrary", this.Context["$HIDDEN1.MSOGallery_SelectedLibrary"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOGallery_FilterString", this.Context["$HIDDEN1.MSOGallery_FilterString"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOTlPn_Button", this.Context["$HIDDEN1.MSOTlPn_Button"].ToString());
            Erequest2Body.FormPostParameters.Add("__EVENTTARGET", this.Context["$HIDDEN1.__EVENTTARGET"].ToString());
            Erequest2Body.FormPostParameters.Add("__EVENTARGUMENT", this.Context["$HIDDEN1.__EVENTARGUMENT"].ToString());
            Erequest2Body.FormPostParameters.Add("__REQUESTDIGEST", this.Context["$HIDDEN1.__REQUESTDIGEST"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOSPWebPartManager_DisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_DisplayModeName"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOWebPartPage_Shared", this.Context["$HIDDEN1.MSOWebPartPage_Shared"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOLayout_LayoutChanges", this.Context["$HIDDEN1.MSOLayout_LayoutChanges"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOLayout_InDesignMode", this.Context["$HIDDEN1.MSOLayout_InDesignMode"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOSPWebPartManager_OldDisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_OldDisplayModeName"].ToString());
            Erequest2Body.FormPostParameters.Add("MSOSPWebPartManager_StartWebPartEditingName", this.Context["$HIDDEN1.MSOSPWebPartManager_StartWebPartEditingName"].ToString());
            Erequest2Body.FormPostParameters.Add("__LASTFOCUS", this.Context["$HIDDEN1.__LASTFOCUS"].ToString());
            Erequest2Body.FormPostParameters.Add("__VIEWSTATE", this.Context["$HIDDEN1.__VIEWSTATE"].ToString());
            Erequest2Body.FormPostParameters.Add("__EVENTVALIDATION", this.Context["$HIDDEN1.__EVENTVALIDATION"].ToString());
            
            
            
            Erequest2Body.FormPostParameters.Add("InputKeywords", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl00$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl01$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "<div></div>");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField_spSave", "<DIV></DIV>");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl03$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl04$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl05$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl06$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl07$ctl00$owshiddenversion" +
                    "", this.Context["$HIDDEN1." + guidPrefix + guid + "$ctl00$ctl07$ctl00$owshidd" +
                    "enversion"].ToString());
            Erequest2Body.FormPostParameters.Add("attachmentsToBeRemovedFromServer", this.Context["$HIDDEN1.attachmentsToBeRemovedFromServer"].ToString());
            Erequest2Body.FormPostParameters.Add("RectGifUrl", this.Context["$HIDDEN1.RectGifUrl"].ToString());
            Erequest2Body.FormPostParameters.Add("fileupload0", "");
            Erequest2Body.FormPostParameters.Add("__spDummyText1", "");
            Erequest2Body.FormPostParameters.Add("__spDummyText2", "");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl07$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl03.x", "5");
            Erequest2Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl07$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl03.y", "8");
            Erequest2.Body = request2Body;
            ExtractHiddenFields EextractionRule2 = new ExtractHiddenFields();
            EextractionRule2.Required = true;
            EextractionRule2.HtmlDecode = true;
            EextractionRule2.ContextParameterName = "1";
            Erequest2.ExtractValues += new EventHandler<ExtractionEventArgs>(EextractionRule2.Extract);
            yield return Erequest2;
            
            Erequest2 = null;


            WebTestRequest Erequest6 = new WebTestRequest(this.siteURL + this.webURL + "/Lists/TrainingCourses/NewForm.aspx");
            Erequest6.Method = "POST";
            Erequest6.ExpectedResponseUrl = this.siteURL + this.webURL + "/Lists/TrainingCourses/AllItems.aspx";
            FormPostHttpBody Erequest6Body = new FormPostHttpBody();
            Erequest6Body.FormPostParameters.Add("MSO_PageHashCode", this.Context["$HIDDEN1.MSO_PageHashCode"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOWebPartPage_PostbackSource", this.Context["$HIDDEN1.MSOWebPartPage_PostbackSource"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOTlPn_SelectedWpId", this.Context["$HIDDEN1.MSOTlPn_SelectedWpId"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOTlPn_View", this.Context["$HIDDEN1.MSOTlPn_View"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOTlPn_ShowSettings", this.Context["$HIDDEN1.MSOTlPn_ShowSettings"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOGallery_SelectedLibrary", this.Context["$HIDDEN1.MSOGallery_SelectedLibrary"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOGallery_FilterString", this.Context["$HIDDEN1.MSOGallery_FilterString"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOTlPn_Button", this.Context["$HIDDEN1.MSOTlPn_Button"].ToString());
            Erequest6Body.FormPostParameters.Add("__EVENTTARGET", guidPrefix + guid + "$ctl00$toolBarTbl$RightRptControls$" +
                    "ctl00$ctl00$diidIOSaveItem");
            Erequest6Body.FormPostParameters.Add("__EVENTARGUMENT", this.Context["$HIDDEN1.__EVENTARGUMENT"].ToString());
            Erequest6Body.FormPostParameters.Add("__REQUESTDIGEST", this.Context["$HIDDEN1.__REQUESTDIGEST"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOSPWebPartManager_DisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_DisplayModeName"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOWebPartPage_Shared", this.Context["$HIDDEN1.MSOWebPartPage_Shared"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOLayout_LayoutChanges", this.Context["$HIDDEN1.MSOLayout_LayoutChanges"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOLayout_InDesignMode", this.Context["$HIDDEN1.MSOLayout_InDesignMode"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOSPWebPartManager_OldDisplayModeName", this.Context["$HIDDEN1.MSOSPWebPartManager_OldDisplayModeName"].ToString());
            Erequest6Body.FormPostParameters.Add("MSOSPWebPartManager_StartWebPartEditingName", this.Context["$HIDDEN1.MSOSPWebPartManager_StartWebPartEditingName"].ToString());
            Erequest6Body.FormPostParameters.Add("__VIEWSTATE", this.Context["$HIDDEN1.__VIEWSTATE"].ToString());
            Erequest6Body.FormPostParameters.Add("__EVENTVALIDATION", this.Context["$HIDDEN1.__EVENTVALIDATION"].ToString());
            
            Erequest6Body.FormPostParameters.Add("InputKeywords", "");
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl00$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", this.myCourseCode);
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl01$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", this.myCourseCode);
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "<div></div>");
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl02$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField_spSave", this.myCourseCode + "\r\n<DIV></DIV>");
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl03$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", DateTime.Now.ToShortDateString());
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl04$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", DateTime.Now.ToShortDateString());
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl05$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$DateTimeField$DateTimeFieldDate", DateTime.Now.ToShortDateString());
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl04$ctl06$ctl00$ctl00$ctl0" +
                    "4$ctl00$ctl00$TextField", "100");
            Erequest6Body.FormPostParameters.Add(guidPrefix + guid + "$ctl00$ctl07$ctl00$owshiddenversion" +
                    "", this.Context["$HIDDEN1." + guidPrefix + guid + "$ctl00$ctl07$ctl00$owshidd" +
                    "enversion"].ToString());
            Erequest6Body.FormPostParameters.Add("attachmentsToBeRemovedFromServer", this.Context["$HIDDEN1.attachmentsToBeRemovedFromServer"].ToString());
            Erequest6Body.FormPostParameters.Add("RectGifUrl", this.Context["$HIDDEN1.RectGifUrl"].ToString());
            Erequest6Body.FormPostParameters.Add("fileupload0", "");
            Erequest6Body.FormPostParameters.Add("__spDummyText1", "");
            Erequest6Body.FormPostParameters.Add("__spDummyText2", "");
            Erequest6.Body = Erequest6Body;


            //ADD RULL TO VALIDATE ERROR
            // The Course Code is already in use. 
            ValidationRuleFindText validationRule2 = new ValidationRuleFindText();
            validationRule2.FindText = "The Course Code is already in use.";
            validationRule2.IgnoreCase = false;
            validationRule2.UseRegularExpression = false;
            validationRule2.PassIfTextFound = true;
            Erequest6.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
    

            yield return Erequest6;
            Erequest6 = null;
                

        }
    }

    }
