
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatarBuilder+AvatarTemplate
// Generated on: úterý 24. února 2026 18:20:31
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.Slot TemplateRoot;
public global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate.Role OnlyForRole;
public global::System.Single Weight;
public global::System.Int32 MaxUsers;
public global::System.Boolean BlockCloudAvatar;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TemplateRoot", TemplateRoot.ToResoniteReference(context));
members.Add("OnlyForRole", OnlyForRole.ToResoniteLinkField());
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("MaxUsers", MaxUsers.ToResoniteLinkField());
members.Add("BlockCloudAvatar", BlockCloudAvatar.ToResoniteLinkField());
}

}
            }
}
