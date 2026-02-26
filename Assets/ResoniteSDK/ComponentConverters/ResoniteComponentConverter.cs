using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public abstract class ResoniteComponentConverter : MonoBehaviour
{
    [SerializeField]
    public Component Target;

    public void Initialize(Component target)
    {
        Target = target;

        // Run any initialization code
        Initialize();
    }

    public abstract void UpdateConversion(IConversionContext context);

    protected abstract void Initialize();
    protected abstract void Cleanup();

    [ExecuteInEditMode]
    void OnDestroy() => Cleanup();
}

/// <summary>
/// This is the best class to derive from when you need versatility in how the component converts. 
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class ResoniteComponentConverter<T> : ResoniteComponentConverter
    where T : Component
{
    protected sealed override void Initialize() => Initialize((T)Target);
    public sealed override void UpdateConversion(IConversionContext context) => UpdateConversion((T)Target, context);

    protected virtual void Initialize(T target) {  }
    protected abstract void UpdateConversion(T target, IConversionContext context);

    protected TComponent EnsureComponent<TComponent, TWrapper>(ref TWrapper wrapper, 
        Action<TComponent> onAdded = null)
        where TWrapper : ResoniteComponent<TComponent>
        where TComponent : ResoniteObject, FrooxEngine.IWorldElement, new()
    {
        if (wrapper == null)
            wrapper = gameObject.AddComponent<TWrapper>();

        var data = wrapper.Data;

        onAdded?.Invoke(data);

        return data;
    }
}

/// <summary>
/// This provides convenient way to define conversions that map 1:1 Unity component to a Resonite component.
/// It automatically handles the instantiation and cleanup, so you only need to worry about providing the conversion update code.
/// </summary>
/// <typeparam name="TUnity"></typeparam>
/// <typeparam name="TResoniteWrapper"></typeparam>
public abstract class ResoniteSingleComponentConverter<TUnity, TResoniteWrapper> : ResoniteComponentConverter<TUnity>
    where TUnity : Component
    where TResoniteWrapper : ResoniteComponent
{
    public TResoniteWrapper Binding;

    protected override void Initialize(TUnity target)
    {
        base.Initialize(target);

        Binding = gameObject.AddComponent<TResoniteWrapper>();
    }

    protected override void Cleanup()
    {
        // Cleanup the binding if it still exists
        if (Binding == null)
            return;

        DestroyImmediate(Binding);
    }
}
