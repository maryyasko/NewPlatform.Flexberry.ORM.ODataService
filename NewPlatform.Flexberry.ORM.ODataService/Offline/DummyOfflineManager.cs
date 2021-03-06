﻿namespace NewPlatform.Flexberry.ORM.ODataService.Offline
{
    using System.Collections.Generic;
    using System.Web.OData.Query;

    using ICSSoft.STORMNET;

    public class DummyOfflineManager : BaseOfflineManager
    {
        protected override bool IsLockingRequired(ODataQueryOptions queryOptions, DataObject dataObject)
        {
            return false;
        }

        protected override bool IsUnlockingRequired(ODataQueryOptions queryOptions, DataObject dataObject)
        {
            return false;
        }

        public override bool LockObjects(ODataQueryOptions queryOptions, IEnumerable<DataObject> dataObjects)
        {
            return true;
        }

        public override bool UnlockObjects(ODataQueryOptions queryOptions, IEnumerable<DataObject> dataObjects)
        {
            return true;
        }
    }
}