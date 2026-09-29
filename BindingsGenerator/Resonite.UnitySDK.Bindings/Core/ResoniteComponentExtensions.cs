using FrooxEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class ResoniteComponentExtensions
{
    public static C AddResoniteComponent<C>(this GameObject gameObject, out ResoniteComponent container)
        where C : ResoniteObject, IWorldElement, new()
    {
        container = gameObject.AddComponent<ResoniteComponent>();
        return container.Initialize<C>();
    }

    public static ResRef<C> AddResoniteComponent<C>(this GameObject gameObject)
        where C : ResoniteObject, IWorldElement, new()
    {
        gameObject.AddResoniteComponent<C>(out var container);
        return new ResRef<C>(container);
    }

    public static ResRef<C> GetResoniteComponent<C>(this GameObject gameObject)
        where C : ResoniteObject, IWorldElement, new()
    {
        foreach (var c in gameObject.GetComponents<ResoniteComponent>())
            if (c.Data is C)
                return new ResRef<C>(c);

        return null;
    }

    public static void GetResoniteComponents<C>(this GameObject gameObject, List<C> results)
        where C : ResoniteObject, IWorldElement, new()
    {
        foreach (var c in gameObject.GetComponents<ResoniteComponent>())
            if (c.Data is C component)
                results.Add(component);
    }

    public static List<C> GetResoniteComponents<C>(this GameObject gameObject)
        where C : ResoniteObject, IWorldElement, new()
    {
        var list = new List<C>();
        GetResoniteComponents(gameObject, list);
        return list;
    }
}
