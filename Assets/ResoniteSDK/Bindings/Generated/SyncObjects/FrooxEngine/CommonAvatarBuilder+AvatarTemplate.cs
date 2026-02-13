
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatarBuilder+AvatarTemplate
// Generated on: pátek 13. února 2026 23:23:19
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TemplateRoot", new ResoniteLink.Reference() { });
members.Add("OnlyForRole", OnlyForRole.ToResoniteLinkField());
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("MaxUsers", MaxUsers.ToResoniteLinkField());
members.Add("BlockCloudAvatar", BlockCloudAvatar.ToResoniteLinkField());
}

}
            }
}
