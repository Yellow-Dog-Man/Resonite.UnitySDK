
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceMultiDriver<>
// Generated on: sobota 14. února 2026 8:58:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceMultiDriver<>")]
public partial class ReferenceMultiDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference;
public System.Collections.Generic.List<global::FrooxEngine.SyncRef<T>> Drives;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("Drives", new ResoniteLink.SyncList()
{
    Elements = Drives.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
