
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarCreator+Anchor
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive { get => ScaleDrive_Element.Data; set => ScaleDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> ScaleDrive_Element = new();
public global::System.String AnchorName { get => AnchorName_Element.Data; set => AnchorName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> AnchorName_Element = new();
public global::System.Boolean IsRight { get => IsRight_Element.Data; set => IsRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsRight_Element = new();
public global::FrooxEngine.AvatarCreator.Anchor OtherSide { get => OtherSide_Element.Data; set => OtherSide_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AvatarCreator.Anchor>, global::FrooxEngine.AvatarCreator.Anchor> OtherSide_Element = new();
public global::FrooxEngine.Slot Slot { get => Slot_Element.Data; set => Slot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Slot_Element = new();
public global::FrooxEngine.Slider Slider { get => Slider_Element.Data; set => Slider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slider>, global::FrooxEngine.Slider> Slider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScaleDrive", ScaleDrive_Element.ToLinkReference(context));
members.Add("AnchorName", AnchorName_Element.ToLinkField(context));
members.Add("IsRight", IsRight_Element.ToLinkField(context));
members.Add("OtherSide", OtherSide_Element.ToLinkReference(context));
members.Add("Slot", Slot_Element.ToLinkReference(context));
members.Add("Slider", Slider_Element.ToLinkReference(context));
}

}
            }
}
