
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ButtonRelay<>
// Generated on: pondělí 2. března 2026 17:52:28
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ButtonRelay<>")]
public partial class ButtonRelay<T> : global::FrooxEngine.UIX.ButtonRelayBase
	

{
    public T Argument { get => Argument_Element.Data; set => Argument_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Argument_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Argument", Argument_Element.ToLinkField(context));
}

}
}
