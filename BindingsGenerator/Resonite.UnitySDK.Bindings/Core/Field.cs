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
    public TData Data;

    [NonSerialized]
    public TReference Member = new();

    TData IField<TData>.Data { get => Data; set => Data = value; }

    public ResoniteLink.Field ToLinkField(IConversionContext context)
    {
        var linkField = Data.ToResoniteLinkField();

        // Self reference
        linkField.ID = context.GetIdOrAllocate(Member);

        return linkField;
    }

    public ResoniteLink.SyncPlayback ToLinkPlayback(IConversionContext context)
    {
        if (!(Data is PlaybackState playback))
            throw new InvalidOperationException("Field data is not playback state");

        var linkPlayback = playback.ToResoniteLink();

        // Self reference
        linkPlayback.ID = context.GetIdOrAllocate(Member);

        return linkPlayback;
    }
}