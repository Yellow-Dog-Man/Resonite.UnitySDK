using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ResoniteComponent : MonoBehaviour
{
    [SerializeReference]
    public ResoniteObject Data;

    public C Initialize<C>()
        where C : ResoniteObject, IWorldElement, new()
    {
        if (Data != null)
            throw new InvalidOperationException("This ResoniteComponent has already been initialized!");

        var typedData = new C();
        Data = typedData;

        return typedData;
    }

    public string TypeName => Data.GetType().GetCustomAttribute<ResoniteTypeNameAttribute>().TypeName;

    public ResoniteLink.Component CollectData(IConversionContext context)
    {
        var component = new ResoniteLink.Component();

        component.ID = context.GetIdOrAllocate((IWorldElement)Data);

        component.Members = new Dictionary<string, ResoniteLink.Member>();
        Data.CollectMembers(component.Members, context);

        return component;
    }

    public ResoniteLink.RemoveComponent GenerateRemoval(IConversionContext context)
    {
        return new ResoniteLink.RemoveComponent()
        {
            MessageID = context.GetUniqueMessageId($"RemoveComponent_{Data.GetType()}"),
            ComponentID = context.GetId((IWorldElement)Data),
        };
    }
    public void RemoveIDs(IConversionContext context)
    {
        // Remove ID for the component itself
        context.RemoveId((IWorldElement)Data);

        // TODO!!! Remove ID's for all nested members when those are tracked!
    }
}