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
    }
}

public static class SlotHelper
{
    public static FrooxEngine.Slot GetSlot(this Transform transform) => transform.gameObject.GetSlot();

    public static FrooxEngine.Slot GetSlot(this GameObject gameObject)
    {
        var wrapper = gameObject.GetComponent<ResoniteSlot>();

        if (wrapper == null)
            wrapper = gameObject.AddComponent<ResoniteSlot>();

        return wrapper.Data;
    }
}
