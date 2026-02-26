using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Reference<TReference, TData> : IField<TData>
    where TReference : IWorldElement, new()
    where TData : class
{
    public TData Data { get => _data as TData; set => _data = value as TData; }

    // We need to store the actual reference as object, because Unity hates when the reference is 
    // either an interface or a non-generic type
    [SerializeReference]
    object _data;

    public TReference Member = new();

    TData IField<TData>.Data { get => Data; set => Data = value; }

    public ResoniteLink.Reference ToLinkReference(IConversionContext context)
    {
        var linkReference = new Reference();

        if (Data is IWorldElement targetElement)
            linkReference.TargetID = context.GetIdOrAllocate(targetElement);

        // Self reference
        linkReference.ID = context.GetIdOrAllocate(Member);

        return linkReference;
    }
}