
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarCreator+Anchor
// Generated on: středa 25. února 2026 16:14:35
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
    public partial class AvatarCreator
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarCreator+Anchor")]
public partial class Anchor : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive;
public global::System.String AnchorName;
public global::System.Boolean IsRight;
public global::FrooxEngine.AvatarCreator.Anchor OtherSide;
public global::FrooxEngine.Slot Slot;
public global::FrooxEngine.Slider Slider;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScaleDrive", ScaleDrive.ToResoniteReference(context));
members.Add("AnchorName", AnchorName.ToResoniteLinkField());
members.Add("IsRight", IsRight.ToResoniteLinkField());
members.Add("OtherSide", OtherSide.ToResoniteReference(context));
members.Add("Slot", Slot.ToResoniteReference(context));
members.Add("Slider", Slider.ToResoniteReference(context));
}

}
            }
}
