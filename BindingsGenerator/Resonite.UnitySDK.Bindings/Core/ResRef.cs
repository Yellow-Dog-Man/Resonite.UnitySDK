using System;
using System.Collections.Generic;
using System.ComponentModel;
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
public struct ResRef<TComponent> : IEquatable<ResRef<TComponent>>
    where TComponent : ResoniteObject, FrooxEngine.IWorldElement, new()
{
    // Normally this would be marked as readonly, so it can't be re-assigned directly, instead forcing assigning the whole of
    // ResRef. However this prevents Unity serialization, which is what we need
    [SerializeReference]
    ResoniteComponent _container;

    public ResoniteComponent Container
    {
        get => _container;
        set
        {
            if (value == null)
                _container = null;
            else
            {
                // Ensure that container that's being assigned matches the type of this Resonite reference
                if (value.Data is not TComponent)
                    throw new ArgumentException($"Provided ResoniteComponent container does not hold Resonite component of type {typeof(TComponent).Name}");

                _container = value;
            }
        }
    }

    public TComponent? Binding => _container?.Data as TComponent;

    public ResRef(ResoniteComponent container)
    {
        if (container == null)
            throw new ArgumentNullException(nameof(container));

        // This will perform the type check
        Container = container;
    }

    public static implicit operator TComponent(ResRef<TComponent> reference) => reference.Binding;
    public static implicit operator UnityEngine.Object?(ResRef<TComponent> reference) => reference.Container;

    public bool Equals(ResRef<TComponent> other) => Container == other.Container;
    public static bool operator ==(ResRef<TComponent> left, ResRef<TComponent> right) => left.Equals(right);
    public static bool operator !=(ResRef<TComponent> left, ResRef<TComponent> right) => !left.Equals(right);

    // These are necessary so we can compare the references against null properly
    // This will equal true when the ResRef Container is null and we compare the ResRef itself against null
    public static bool operator ==(ResRef<TComponent> left, ResRef<TComponent>? right) => left.Equals(right ?? default);
    public static bool operator !=(ResRef<TComponent> left, ResRef<TComponent>? right) => !left.Equals(right ?? default);
    public static bool operator ==(ResRef<TComponent>? left, ResRef<TComponent> right) => right.Equals(left ?? default);
    public static bool operator !=(ResRef<TComponent>? left, ResRef<TComponent> right) => !right.Equals(left ?? default);

    public override bool Equals(object obj)
    {
        if(obj is null)
            return Container is null;

        if (obj is TComponent component)
            return Binding == component;

        if (obj is ResoniteComponent container)
            return Container == container;

        if (obj is ResRef<TComponent> reference)
            return Container == reference.Container;

        return false;
    }
}
