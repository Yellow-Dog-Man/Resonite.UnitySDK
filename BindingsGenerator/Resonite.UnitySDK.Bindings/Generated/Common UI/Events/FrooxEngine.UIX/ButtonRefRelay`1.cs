
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ButtonRefRelay<>
// Generated on: čtvrtek 26. února 2026 10:03:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ButtonRefRelay<>")]
public partial class ButtonRefRelay<T> : global::FrooxEngine.UIX.ButtonRelayBase
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Argument { get => Argument_Element.Data; set => Argument_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> Argument_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Argument", Argument_Element.Data.ToResoniteReference(context));
}

}
}
