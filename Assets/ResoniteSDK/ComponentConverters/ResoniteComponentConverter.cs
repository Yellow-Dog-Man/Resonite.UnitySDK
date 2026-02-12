using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    protected abstract void Initialize();
    public abstract void UpdateConversion();
    protected abstract void Cleanup();

    void OnDestroy()
    {
        Cleanup();
    }
}

public abstract class ResoniteComponentConverter<T> : ResoniteComponentConverter
    where T : Component
{
    protected sealed override void Initialize() => Initialize((T)Target);
    public sealed override void UpdateConversion() => UpdateConversion((T)Target);

    protected virtual void Initialize(T target) {  }
    protected abstract void UpdateConversion(T target);
}
