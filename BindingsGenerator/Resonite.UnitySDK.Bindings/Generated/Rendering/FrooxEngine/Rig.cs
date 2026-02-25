
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Rig
// Generated on: středa 25. února 2026 16:14:17
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Rig")]
public partial class Rig : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> Bones;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Bones", new ResoniteLink.SyncList()
{
    Elements = Bones.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
