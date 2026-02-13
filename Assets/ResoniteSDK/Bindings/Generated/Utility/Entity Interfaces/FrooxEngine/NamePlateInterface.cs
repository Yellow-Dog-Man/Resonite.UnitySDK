
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NamePlateInterface
// Generated on: pátek 13. února 2026 23:23:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NamePlateInterface")]
public partial class NamePlateInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.String> Username;
public global::FrooxEngine.IField<global::System.String> UserID;
public global::FrooxEngine.IField<System.Uri> IconURL;
public global::FrooxEngine.SyncRef<global::FrooxEngine.User> TargetUser;
public global::FrooxEngine.UserRef TargetUserRef;
public global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource> VoiceStream;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Username", new ResoniteLink.Reference() { });
members.Add("UserID", new ResoniteLink.Reference() { });
members.Add("IconURL", new ResoniteLink.Reference() { });
members.Add("TargetUser", new ResoniteLink.Reference() { });
members.Add("TargetUserRef", new ResoniteLink.Reference() { });
members.Add("VoiceStream", new ResoniteLink.Reference() { });
}

}
}
