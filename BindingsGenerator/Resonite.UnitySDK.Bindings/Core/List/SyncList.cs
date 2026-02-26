using FrooxEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SyncList<TReference, TElement>
    where TElement : new()
    where TReference : IWorldElement, new()
{
    [SerializeField]
    public List<TElement> Data { get; set; } = new List<TElement>();

    [NonSerialized]
    public TReference Reference = new();

    public int Count => Data.Count;

    public TElement Add()
    {
        var element = new TElement();
        Data.Add(element);
        return element;
    }

    public void RemoveAt(int index) => Data.RemoveAt(index);
    public void Clear() => Data.Clear();

    public TElement GetElement(int index) => Data[index];

    public ResoniteLink.SyncList ToLinkList(IConversionContext context, Func<TElement, ResoniteLink.Member> conversion)
    {
        var linkList = new ResoniteLink.SyncList();

        linkList.Elements = new List<ResoniteLink.Member>();

        if (Data != null)
            foreach (var element in Data)
                linkList.Elements.Add(conversion(element));

        // Self reference
        linkList.ID = context.GetIdOrAllocate(Reference);

        return linkList;
    }
}