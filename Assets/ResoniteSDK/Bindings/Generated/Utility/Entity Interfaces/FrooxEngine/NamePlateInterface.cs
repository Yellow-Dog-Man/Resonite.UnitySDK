
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NamePlateInterface
// Generated on: čtvrtek 19. února 2026 8:00:33
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Username", Username.ToResoniteReference(context));
members.Add("UserID", UserID.ToResoniteReference(context));
members.Add("IconURL", IconURL.ToResoniteReference(context));
members.Add("TargetUser", TargetUser.ToResoniteReference(context));
members.Add("TargetUserRef", TargetUserRef.ToResoniteReference(context));
members.Add("VoiceStream", VoiceStream.ToResoniteReference(context));
}

}
}
