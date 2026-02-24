
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRestrictionsSettings+Entry
// Generated on: úterý 24. února 2026 18:20:29
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
    public partial class UserRestrictionsSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRestrictionsSettings+Entry")]
public partial class Entry : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.BlockType BlockType;
public global::System.Boolean IsFullyBanned;
public global::System.String Username;
public global::System.String UserId;
public System.Collections.Generic.List<global::System.String> MachineIDs;
public System.Collections.Generic.List<global::System.String> BannedWorldList;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlockType", BlockType.ToResoniteLinkField());
members.Add("IsFullyBanned", IsFullyBanned.ToResoniteLinkField());
members.Add("Username", Username.ToResoniteLinkField());
members.Add("UserId", UserId.ToResoniteLinkField());
members.Add("MachineIDs", new ResoniteLink.SyncList()
{
    Elements = MachineIDs.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("BannedWorldList", new ResoniteLink.SyncList()
{
    Elements = BannedWorldList.ConvertList(m => m.ToResoniteLinkField())
});
}

}
            }
}
