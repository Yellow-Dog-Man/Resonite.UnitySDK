using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FrooxEngine
{
    [Serializable]
    public partial class Slot
    {
        public ResoniteSlot Wrapper;

        // We store it explicitly, because Unity doesn't allow accessing .transform from other threads
        public Transform Transform;
    }
}

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class ResoniteSlot : MonoBehaviour
{
    [SerializeField]
    public FrooxEngine.Slot Data = new FrooxEngine.Slot();

    [ExecuteInEditMode]
    private void Awake()
    {
        Data.Wrapper = this;
        Data.Transform = this.transform;
    }
}

public static class SlotHelper
{
    public static FrooxEngine.Slot GetSlot(this Transform transform)
    {
        if (transform == null)
            return null;

        return transform.gameObject.GetSlot();
    }

    public static FrooxEngine.Slot GetSlot(this GameObject gameObject)
    {
        if (gameObject == null)
            return null;

        var wrapper = gameObject.GetComponent<ResoniteSlot>();

        if (wrapper == null)
            wrapper = gameObject.AddComponent<ResoniteSlot>();

        return wrapper.Data;
    }
}
