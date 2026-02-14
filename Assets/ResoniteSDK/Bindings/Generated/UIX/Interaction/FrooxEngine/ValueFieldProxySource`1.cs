
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueFieldProxySource<>
// Generated on: sobota 14. února 2026 8:58:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueFieldProxySource<>")]
public partial class ValueFieldProxySource<T> : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabbable, global::FrooxEngine.IValueFieldProxySource
	

{
    public global::FrooxEngine.IField<T> Field;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field.ToResoniteReference(context));
}

}
}
