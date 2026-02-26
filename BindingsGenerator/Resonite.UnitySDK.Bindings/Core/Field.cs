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
    where TReference : new()
{
    [SerializeField]
    public TData Data { get; set; }

    [NonSerialized]
    public TReference Reference = new();
}