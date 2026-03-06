
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleStringDriver
// Generated on: pátek 6. března 2026 14:18:09
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleStringDriver")]
public partial class LocaleStringDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Target_Element = new();
public global::System.String Key { get => Key_Element.Data; set => Key_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Key_Element = new();
public global::System.String Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Format_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource> Locale { get => Locale_Element.Data; set => Locale_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.LocaleResource>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource>> Locale_Element = new();
public global::SyncDictionary<global::FrooxEngine.SyncDictionary<global::System.String,global::FrooxEngine.RelayRef<global::FrooxEngine.IField>>, global::System.String, Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField>, global::FrooxEngine.IField>> ArgumentSources = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Key", Key_Element.ToLinkField(context));
members.Add("Format", Format_Element.ToLinkField(context));
members.Add("Locale", Locale_Element.ToLinkReference(context));
members.Add("ArgumentSources", ArgumentSources.ToLinkDictionary(context, m => m.ToLinkReference(context)));
}
public  async System.Threading.Tasks.Task SetArgumentSource(global::System.String key, global::FrooxEngine.IField field, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "SetArgumentSource";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("key", key.ToData());
__message.Arguments.Add("field", new ResoniteLink.Data_Reference() { TargetID = context.GetId(field) });
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
