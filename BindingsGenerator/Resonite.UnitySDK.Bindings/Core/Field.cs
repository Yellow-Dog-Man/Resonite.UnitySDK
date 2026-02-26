using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IField<TData>
{
    TData Data { get; set; }
}

[Serializable]
public class Field<TReference, TData> : IField<TData>
    where TReference : IWorldElement, new()
{
    [SerializeField]
    public TData Data { get; set; }

    [NonSerialized]
    public TReference Reference = new();

    public ResoniteLink.Field ToLinkField(IConversionContext context)
    {
        var linkField = Data.ToResoniteLinkField();

        // Self reference
        linkField.ID = context.GetIdOrAllocate(Reference);

        return linkField;
    }

    public ResoniteLink.Reference ToLinkReference(IConversionContext context)
    {
        var linkReference = new Reference();

        if (Data is IWorldElement targetElement)
            linkReference.TargetID = context.GetIdOrAllocate(targetElement);

        // Self reference
        linkReference.ID = context.GetIdOrAllocate(Reference);

        return linkReference;
    }

    public ResoniteLink.SyncPlayback ToLinkPlayback(IConversionContext context)
    {
        if (!(Data is PlaybackState playback))
            throw new InvalidOperationException("Field data is not playback state");

        var linkPlayback = playback.ToResoniteLink();

        // Self reference
        linkPlayback.ID = context.GetIdOrAllocate(Reference);

        return linkPlayback;
    }
}