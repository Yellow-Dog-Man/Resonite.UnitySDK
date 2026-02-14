
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorToColorX
// Generated on: sobota 14. února 2026 8:58:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorToColorX")]
public partial class ColorToColorX : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Color> SourceColor;
public global::FrooxEngine.IField<global::Renderite.Shared.ColorProfile> SourceProfile;
public global::Renderite.Shared.ColorProfile DefaultProfile;
public global::FrooxEngine.IField<UnityEngine.ColorX> Target;
public global::System.Boolean WriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SourceColor", SourceColor.ToResoniteReference(context));
members.Add("SourceProfile", SourceProfile.ToResoniteReference(context));
members.Add("DefaultProfile", DefaultProfile.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
}

}
}
