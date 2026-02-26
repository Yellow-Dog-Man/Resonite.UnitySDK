using FrooxEngine;
using System;
using System.Collections.Generic;
using System.Text;

public class SyncFieldList<TReference, TValue, TElement> : SyncList<TReference, TElement>
    where TReference : IWorldElement, new()
    where TElement : IField<TValue>, new()
{
    public void Add(TValue value) => Add().Data = value;

    public TValue this[int index]
    {
        get => Data[index].Data;
        set => Data[index].Data = value;
    }
}