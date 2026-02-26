using FrooxEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[Serializable]
public class SyncArray<TReference, TData>
    where TReference : IWorldElement, new()
{
    [SerializeField]
    public TData[] Data { get; set; }

    [NonSerialized]
    public TReference Reference = new();

    public ResoniteLink.SyncArray ToLinkArray(IConversionContext context)
    {
        var linkArray = Data.ToResoniteLinkArray();

        linkArray.ID = context.GetIdOrAllocate(Reference);

        return linkArray;
    }
}