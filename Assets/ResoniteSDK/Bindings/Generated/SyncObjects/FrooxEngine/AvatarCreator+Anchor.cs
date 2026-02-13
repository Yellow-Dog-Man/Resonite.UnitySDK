
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarCreator+Anchor
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ScaleDrive", new ResoniteLink.Reference() { });
members.Add("AnchorName", AnchorName.ToResoniteLinkField());
members.Add("IsRight", IsRight.ToResoniteLinkField());
members.Add("OtherSide", new ResoniteLink.Reference() { });
members.Add("Slot", new ResoniteLink.Reference() { });
members.Add("Slider", new ResoniteLink.Reference() { });
}

}
            }
}
