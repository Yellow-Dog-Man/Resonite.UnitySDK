using System;
using System.Collections.Generic;
using System.Text;

public static class SyncObjectConversionHelper
{
    public static ResoniteLink.SyncObject ToLinkSyncObject(this FrooxEngine.SyncObject syncObject, IConversionContext context)
    {
        var linkObject = new ResoniteLink.SyncObject();

        linkObject.Members = syncObject.CollectMembers(context);

        // Self ID
        linkObject.ID = context.GetIdOrAllocate(syncObject);

        return linkObject;
    }
}
