using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public abstract class ResoniteComponent : MonoBehaviour
{
    public abstract ResoniteLink.AddUpdateComponent CollectData(IConversionContext context);
    public abstract string TypeName { get; }
}

public abstract class ResoniteComponent<C> : ResoniteComponent
    where C  : ResoniteObject, new()
{
    [SerializeField]
    public C Data = new C();

    public override ResoniteLink.AddUpdateComponent CollectData(IConversionContext context)
    {
        var component = new ResoniteLink.Component();

        component.ID = context.GetIdOrAllocate(Data, out var allocated);

        component.Members = new Dictionary<string, ResoniteLink.Member>();
        Data.CollectMembers(component.Members);

        if (allocated)
        {
            // We're adding this component for the first time, so we need to indicate the type
            // TODO!!! Generics
            component.ComponentType = TypeName;

            return new ResoniteLink.AddComponent()
            {
                MessageID = context.GetUniqueMessageId($"AddComponent_{typeof(C)}"),
                ContainerSlotId = context.GetTransformSlotId(transform),
                Data = component,
            };
        }
        else
            return new ResoniteLink.UpdateComponent()
            {
                MessageID = context.GetUniqueMessageId($"UpdateComponent_{typeof(C)}"),
                Data = component
            };
    }

    public override string TypeName => typeof(C).GetCustomAttribute<ResoniteTypeNameAttribute>().TypeName;
}

