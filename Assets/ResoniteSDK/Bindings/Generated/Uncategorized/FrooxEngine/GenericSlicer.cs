
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericSlicer
// Generated on: úterý 24. února 2026 18:20:12
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericSlicer")]
public partial class GenericSlicer : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public System.Collections.Generic.List<global::FrooxEngine.GenericSlicer.SliceDrive> Targets;
public global::FrooxEngine.RootSpace Space;
public global::FrooxEngine.Slot _grabbedVisual;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Space", new ResoniteLink.SyncObject() { Members = Space.CollectMembers(context) });
members.Add("_grabbedVisual", _grabbedVisual.ToResoniteReference(context));
}

}
}
