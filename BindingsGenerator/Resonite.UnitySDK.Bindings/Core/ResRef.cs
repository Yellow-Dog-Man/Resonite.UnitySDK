using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

/// <summary>
/// Reference to a Resonite component that keeps both the container Unity MonoBehavior and provides
/// implicit casting to both Unity Object type and the Binding type.
/// This is returned by the attach methods to the container can be life-cycle managed properly.
/// Name is kept short to avoid a lot of verbosity since it'll be likely used often in converters
/// </summary>
/// <typeparam name="TComponent">Type of Resonite component</typeparam>
[Serializable]
public class ResRef<TComponent>
    where TComponent : ResoniteObject, FrooxEngine.IWorldElement, new()
{
    [SerializeReference]
    public readonly ResoniteComponent Container;
    public TComponent Binding => (TComponent)Container.Data;

    public ResRef(ResoniteComponent container)
    {
        if (container == null)
            throw new ArgumentNullException(nameof(container));

        if (container.Data is not TComponent)
            throw new ArgumentException($"Provided ResoniteComponent container does not hold Resonite component of type {typeof(TComponent).Name}");

        this.Container = container;
    }

    public static implicit operator TComponent(ResRef<TComponent> reference) => reference.Binding;
    public static implicit operator UnityEngine.Object?(ResRef<TComponent> reference) => reference.Container;
}
