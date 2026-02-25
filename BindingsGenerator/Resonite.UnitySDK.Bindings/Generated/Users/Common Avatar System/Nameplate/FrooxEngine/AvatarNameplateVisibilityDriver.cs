
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarNameplateVisibilityDriver
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarNameplateVisibilityDriver")]
public partial class AvatarNameplateVisibilityDriver : global::FrooxEngine.Component

{
    public global::System.Boolean AlwaysShowToContacts;
public global::FrooxEngine.IField<global::System.Boolean> Visible;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AlwaysShowToContacts", AlwaysShowToContacts.ToResoniteLinkField());
members.Add("Visible", Visible.ToResoniteReference(context));
}

}
}
