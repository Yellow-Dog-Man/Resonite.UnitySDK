using System;
using UnityEngine;

namespace ResoniteSDK {
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

        protected TComponent EnsureComponent<TComponent>(ref ResRef<TComponent> container, 
            Action<TComponent> onAdded = null)
            where TComponent : ResoniteObject, FrooxEngine.IWorldElement, new()
        {
            if (container == null)
            {
                container = gameObject.AddResoniteComponent<TComponent>();
                onAdded?.Invoke(container.Binding);
            }

            return container.Binding;
        }
    }

    /// <summary>
    /// This provides convenient way to define conversions that map 1:1 Unity component to a Resonite component.
    /// It automatically handles the instantiation and cleanup, so you only need to worry about providing the conversion update code.
    /// </summary>
    /// <typeparam name="TUnity"></typeparam>
    /// <typeparam name="TResonite"></typeparam>
    public abstract class ResoniteSingleComponentConverter<TUnity, TResonite> : ResoniteComponentConverter<TUnity>
        where TUnity : Component
        where TResonite : ResoniteObject, FrooxEngine.IWorldElement, new()
    {
        public ResoniteComponent Container;

        public TResonite Binding => Container?.Data as TResonite;

        protected override void Initialize(TUnity target)
        {
            base.Initialize(target);

            gameObject.AddResoniteComponent<TResonite>(out Container);
        }

        protected override void Cleanup()
        {
            // Cleanup the binding if it still exists
            if (Container == null)
                return;

            DestroyImmediate(Container);
        }
    }
}