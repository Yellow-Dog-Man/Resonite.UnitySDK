
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NamePlateInterface
// Generated on: čtvrtek 26. února 2026 10:04:50
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NamePlateInterface")]
public partial class NamePlateInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.String> Username { get => Username_Element.Data; set => Username_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Username_Element = new();
public global::FrooxEngine.IField<global::System.String> UserID { get => UserID_Element.Data; set => UserID_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> UserID_Element = new();
public global::FrooxEngine.IField<System.Uri> IconURL { get => IconURL_Element.Data; set => IconURL_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> IconURL_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.User> TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.User>>, global::FrooxEngine.SyncRef<global::FrooxEngine.User>> TargetUser_Element = new();
public global::FrooxEngine.UserRef TargetUserRef { get => TargetUserRef_Element.Data; set => TargetUserRef_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> TargetUserRef_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource> VoiceStream { get => VoiceStream_Element.Data; set => VoiceStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>> VoiceStream_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Username", Username_Element.Data.ToResoniteReference(context));
members.Add("UserID", UserID_Element.Data.ToResoniteReference(context));
members.Add("IconURL", IconURL_Element.Data.ToResoniteReference(context));
members.Add("TargetUser", TargetUser_Element.Data.ToResoniteReference(context));
members.Add("TargetUserRef", TargetUserRef_Element.Data.ToResoniteReference(context));
members.Add("VoiceStream", VoiceStream_Element.Data.ToResoniteReference(context));
}

}
}
