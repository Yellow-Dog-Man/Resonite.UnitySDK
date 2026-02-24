
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInfo
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInfo")]
public partial class UserInfo : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> Controllers;
public System.Collections.Generic.List<global::FrooxEngine.Slot> Hands;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Controllers", new ResoniteLink.SyncList()
{
    Elements = Controllers.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Hands", new ResoniteLink.SyncList()
{
    Elements = Hands.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
