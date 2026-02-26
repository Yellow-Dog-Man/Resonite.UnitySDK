using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[Serializable]
public class SyncArray<TReference, TData>
    where TReference : new()
{
    [SerializeField]
    public TData[] Data { get; set; }

    [NonSerialized]
    public TReference Reference = new();
}