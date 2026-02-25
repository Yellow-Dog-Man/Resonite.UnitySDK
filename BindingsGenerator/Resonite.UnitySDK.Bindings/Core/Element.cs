using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Element<TReference, TData>
    where TReference : new()
{
    [SerializeField]
    public TData Data;

    [NonSerialized]
    public TReference Reference = new();
}