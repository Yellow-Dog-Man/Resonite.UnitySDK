
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInfo
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInfo")]
public partial class UserInfo : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> Controllers;
public System.Collections.Generic.List<global::FrooxEngine.Slot> Hands;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Controllers", new ResoniteLink.SyncList()
{
    Elements = Controllers.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("Hands", new ResoniteLink.SyncList()
{
    Elements = Hands.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
