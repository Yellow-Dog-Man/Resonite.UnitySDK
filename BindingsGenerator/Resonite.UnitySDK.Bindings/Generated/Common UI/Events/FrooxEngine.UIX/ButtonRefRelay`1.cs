
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ButtonRefRelay<>
// Generated on: pátek 6. března 2026 14:18:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public Reference<global::FrooxEngine.SyncRef<T>, T> Argument_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Argument", Argument_Element.ToLinkReference(context));
}

}
}
