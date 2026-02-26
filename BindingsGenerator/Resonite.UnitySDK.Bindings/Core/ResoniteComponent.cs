using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public abstract class ResoniteComponent : MonoBehaviour
{
    public abstract ResoniteLink.Component CollectData(IConversionContext context);
    public abstract string TypeName { get; }
    public abstract ResoniteLink.RemoveComponent GenerateRemoval(IConversionContext context);
    public abstract void RemoveIDs(IConversionContext context);
}

public abstract class ResoniteComponent<C> : ResoniteComponent
    where C  : ResoniteObject, IWorldElement, new()
{
    [SerializeField]
    public C Data = new C();

    public override ResoniteLink.Component CollectData(IConversionContext context)
    {
        var component = new ResoniteLink.Component();

        component.ID = context.GetIdOrAllocate(Data);

        component.Members = new Dictionary<string, ResoniteLink.Member>();
        Data.CollectMembers(component.Members, context);

        return component;
    }

    public override ResoniteLink.RemoveComponent GenerateRemoval(IConversionContext context)
    {
        return new ResoniteLink.RemoveComponent()
        {
            MessageID = context.GetUniqueMessageId($"RemoveComponent_{typeof(C)}"),
            ComponentID = context.GetId(Data),
        };
    }

    public override void RemoveIDs(IConversionContext context)
    {
        // Remove ID for the component itself
        context.RemoveId(Data);

        // TODO!!! Remove ID's for all nested members when those are tracked!
    }

    public override string TypeName => typeof(C).GetCustomAttribute<ResoniteTypeNameAttribute>().TypeName;
}

