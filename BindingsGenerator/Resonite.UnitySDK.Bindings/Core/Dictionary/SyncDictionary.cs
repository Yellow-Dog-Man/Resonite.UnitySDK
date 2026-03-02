using FrooxEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[Serializable]
public class SyncDictionary<TReference, TKey, TElement>
    where TElement : new()
    where TReference : IWorldElement, new()
{ 
    [SerializeField]
    public Dictionary<TKey, TElement> Data = new Dictionary<TKey, TElement>();

    [NonSerialized]
    public TReference Member = new();

    public int Count => Data.Count;

    public TElement Add(TKey key)
    {
        var element = new TElement();
        Data.Add(key, element);
        return element;
    }

    public TElement GetOrAdd(TKey key)
    {
        if (Data.TryGetValue(key, out var element))
            return element;

        return Add(key);
    }

    public bool Remove(TKey key) => Data.Remove(key);
    public void Clear() => Data.Clear();

    public ResoniteLink.SyncDictionary ToLinkDictionary(IConversionContext context, Func<TElement, ResoniteLink.Member> conversion)
    {
        var dict = Data.ToResoniteLinkDictionary(conversion);

        // Self reference
        dict.ID = context.GetIdOrAllocate(Member);

        return dict;
    }
}