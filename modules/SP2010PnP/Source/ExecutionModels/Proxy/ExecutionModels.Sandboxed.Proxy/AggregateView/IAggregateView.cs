//===============================================================================
// Microsoft patterns & practices
// Developing Applications for SharePoint 2010
//===============================================================================
// Copyright Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://msdn.microsoft.com/en-us/library/ee663037.aspx)
//===============================================================================


using System.Data;

namespace ExecutionModels.Sandboxed.Proxy.AggregateView
{
    public interface IAggregateView
    {
        DataTable SetSiteData { set; }
    }
}


