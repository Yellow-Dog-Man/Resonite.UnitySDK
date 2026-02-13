
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyEnumEditor<>
// Generated on: pátek 13. února 2026 5:52:28
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyEnumEditor<>")]
public partial class LegacyEnumEditor<E> : global::FrooxEngine.LegacyFieldBase
	where E : struct, System.Enum

{
    public global::System.Boolean IsEnabled;
public E Value;
public global::FrooxEngine.IField<global::System.String> _textDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("_textDrive", new ResoniteLink.Reference() { });
}

}
}
