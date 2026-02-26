
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatarBuilder+AvatarTemplate
// Generated on: čtvrtek 26. února 2026 10:04:49
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
    public partial class CommonAvatarBuilder
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatarBuilder+AvatarTemplate")]
public partial class AvatarTemplate : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot TemplateRoot { get => TemplateRoot_Element.Data; set => TemplateRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TemplateRoot_Element = new();
public global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate.Role OnlyForRole { get => OnlyForRole_Element.Data; set => OnlyForRole_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate.Role>, global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate.Role> OnlyForRole_Element = new();
public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public global::System.Int32 MaxUsers { get => MaxUsers_Element.Data; set => MaxUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxUsers_Element = new();
public global::System.Boolean BlockCloudAvatar { get => BlockCloudAvatar_Element.Data; set => BlockCloudAvatar_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlockCloudAvatar_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TemplateRoot", TemplateRoot_Element.Data.ToResoniteReference(context));
members.Add("OnlyForRole", OnlyForRole_Element.Data.ToResoniteLinkField());
members.Add("Weight", Weight_Element.Data.ToResoniteLinkField());
members.Add("MaxUsers", MaxUsers_Element.Data.ToResoniteLinkField());
members.Add("BlockCloudAvatar", BlockCloudAvatar_Element.Data.ToResoniteLinkField());
}

}
            }
}
