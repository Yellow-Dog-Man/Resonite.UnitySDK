
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModelExportable
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ModelExportable")]
public partial class ModelExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.Slot Root;
public System.Collections.Generic.List<global::FrooxEngine.Component> OnlyComponents;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("OnlyComponents", new ResoniteLink.SyncList()
{
    Elements = OnlyComponents.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
