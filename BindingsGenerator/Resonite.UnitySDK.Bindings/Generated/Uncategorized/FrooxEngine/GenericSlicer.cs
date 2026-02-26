
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericSlicer
// Generated on: čtvrtek 26. února 2026 10:04:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericSlicer")]
public partial class GenericSlicer : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.GenericSlicer.SliceDrive>, global::FrooxEngine.GenericSlicer.SliceDrive> Targets = new();
public global::FrooxEngine.RootSpace Space = new();
public global::FrooxEngine.Slot _grabbedVisual { get => _grabbedVisual_Element.Data; set => _grabbedVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _grabbedVisual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Space", new ResoniteLink.SyncObject() { Members = Space.CollectMembers(context) });
members.Add("_grabbedVisual", _grabbedVisual_Element.Data.ToResoniteReference(context));
}

}
}
