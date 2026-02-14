
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ReferenceRadio<>
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ReferenceRadio<>")]
public partial class ReferenceRadio<T> : global::FrooxEngine.UIX.Radio
	where T : class, global::FrooxEngine.IWorldElement

{
    public T OptionReference;
public global::FrooxEngine.SyncRef<T> TargetReference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OptionReference", OptionReference.ToResoniteReference(context));
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
}

}
}
