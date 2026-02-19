
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyEnumEditor<>
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("_textDrive", _textDrive.ToResoniteReference(context));
}

}
}
