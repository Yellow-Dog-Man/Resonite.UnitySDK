
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRestrictionsSettings+Entry
// Generated on: čtvrtek 26. února 2026 10:04:48
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
    public partial class UserRestrictionsSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRestrictionsSettings+Entry")]
public partial class Entry : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.BlockType BlockType { get => BlockType_Element.Data; set => BlockType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlockType>, global::FrooxEngine.BlockType> BlockType_Element = new();
public global::System.Boolean IsFullyBanned { get => IsFullyBanned_Element.Data; set => IsFullyBanned_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsFullyBanned_Element = new();
public global::System.String Username { get => Username_Element.Data; set => Username_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Username_Element = new();
public global::System.String UserId { get => UserId_Element.Data; set => UserId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> UserId_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> MachineIDs = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> BannedWorldList = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlockType", BlockType_Element.Data.ToResoniteLinkField());
members.Add("IsFullyBanned", IsFullyBanned_Element.Data.ToResoniteLinkField());
members.Add("Username", Username_Element.Data.ToResoniteLinkField());
members.Add("UserId", UserId_Element.Data.ToResoniteLinkField());
members.Add("MachineIDs", new ResoniteLink.SyncList()
{
    Elements = MachineIDs.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
members.Add("BannedWorldList", new ResoniteLink.SyncList()
{
    Elements = BannedWorldList.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
            }
}
