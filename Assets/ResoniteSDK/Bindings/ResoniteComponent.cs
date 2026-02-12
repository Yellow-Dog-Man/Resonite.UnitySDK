using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResoniteComponent : MonoBehaviour
{
    public abstract ResoniteLink.Component CollectData();
}

public abstract class ResoniteComponent<C> : ResoniteComponent
    where C  : ResoniteObject
{
    [SerializeField]
    public C Data;

    public override ResoniteLink.Component CollectData()
    {
        var component = new ResoniteLink.Component();

        component.Members = new Dictionary<string, ResoniteLink.Member>();
        Data.CollectMembers(component.Members);

        return component;
    }
}

