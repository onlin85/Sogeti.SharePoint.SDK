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

namespace PartnerPortalBVT
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    using PartnerPortalBVT.Settings;

    /// <summary>
    /// This Test verify the text in the Collapsable control in the ExtranetProductPage page
    /// </summary>


    public class VerifyCollapsableControlExtranetProductPage : WebTest
    {
        string fbaURL = CustConfig.GetFBAURL;
        string fbaUserName = CustConfig.Partner1FBAUserName;
        string fbaUserPassword = CustConfig.FBAUserPassword;

        public VerifyCollapsableControlExtranetProductPage()
        {
            this.PreAuthenticate = true;
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Initialize validation rules that apply to all requests in the WebTest
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }

            WebTestRequest request1 = new WebTestRequest(fbaURL + "/sites/ProductCatalog/Product.aspx");
            request1.ThinkTime = 22;
            request1.ExpectedResponseUrl = fbaURL + "/_layouts/login.aspx?ReturnUrl=%2fsites%2fProductCatalog" +
                "%2fProduct.aspx%3fsku%3d6000000000&sku=6000000000";
            request1.QueryStringParameters.Add("sku", "6000000000", false, false);
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request1.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest(fbaURL + "/_layouts/login.aspx");
            request2.Method = "POST";
            request2.ExpectedResponseUrl = fbaURL + "/sites/ProductCatalog/Product.aspx?sku=6000000000";
            request2.QueryStringParameters.Add("ReturnUrl", "%2fsites%2fProductCatalog%2fProduct.aspx%3fsku%3d6000000000", false, false);
            request2.QueryStringParameters.Add("sku", "6000000000", false, false);
            FormPostHttpBody request2Body = new FormPostHttpBody();
            request2Body.FormPostParameters.Add("__LASTFOCUS", this.Context["$HIDDEN1.__LASTFOCUS"].ToString());
            request2Body.FormPostParameters.Add("__VIEWSTATE", this.Context["$HIDDEN1.__VIEWSTATE"].ToString());
            request2Body.FormPostParameters.Add("__EVENTTARGET", this.Context["$HIDDEN1.__EVENTTARGET"].ToString());
            request2Body.FormPostParameters.Add("__EVENTARGUMENT", this.Context["$HIDDEN1.__EVENTARGUMENT"].ToString());
            request2Body.FormPostParameters.Add("__EVENTVALIDATION", this.Context["$HIDDEN1.__EVENTVALIDATION"].ToString());
            request2Body.FormPostParameters.Add("ctl00$PlaceHolderMain$login$UserName", fbaUserName);
            request2Body.FormPostParameters.Add("ctl00$PlaceHolderMain$login$password", fbaUserPassword);
            request2Body.FormPostParameters.Add("ctl00$PlaceHolderMain$login$login", "Sign In");
            request2Body.FormPostParameters.Add("__spDummyText1", "");
            request2Body.FormPostParameters.Add("__spDummyText2", "");
            request2.Body = request2Body;


            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.High))
            {
                ValidationRuleFindText validationRule3 = new ValidationRuleFindText();
                validationRule3.FindText = "This page is the Business Data Catalog (BDC) profile page for the product business entity.";
                validationRule3.IgnoreCase = true;
                validationRule3.UseRegularExpression = false;
                validationRule3.PassIfTextFound = true;
                request2.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule3.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.High))
            {
                ValidationRuleFindText validationRule4 = new ValidationRuleFindText();
                validationRule4.FindText = "The ProductDetailsWebPart shows details of the current product from the BDC. The BDC gets the product details from the product catalog LOB service.";
                validationRule4.IgnoreCase = true;
                validationRule4.UseRegularExpression = false;
                validationRule4.PassIfTextFound = true;
                request2.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule4.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.High))
            {
                ValidationRuleFindText validationRule5 = new ValidationRuleFindText();
                validationRule5.FindText = "The PricingWebPart shows the current partner’s price for this product. This Web parts get pricing information from the pricing repository.";
                validationRule5.IgnoreCase = true;
                validationRule5.UseRegularExpression = false;
                validationRule5.PassIfTextFound = true;
                request2.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule5.Validate);
            }

            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.High))
            {
                ValidationRuleFindText validationRule6 = new ValidationRuleFindText();
                validationRule6.FindText = "The DiscountsWebPart also uses the pricing repository to show the discounts related to this product for this partner.";
                validationRule6.IgnoreCase = true;
                validationRule6.UseRegularExpression = false;
                validationRule6.PassIfTextFound = true;
                request2.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule6.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.High))
            {
                ValidationRuleFindText validationRule7 = new ValidationRuleFindText();
                validationRule7.FindText = "The RelatedPartsWebPart uses AJAX to retrieve information on  parts that are related to the current product.";
                validationRule7.IgnoreCase = true;
                validationRule7.UseRegularExpression = false;
                validationRule7.PassIfTextFound = true;
                request2.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule7.Validate);
            }

            yield return request2;
            request2 = null;
        }
    }
}
