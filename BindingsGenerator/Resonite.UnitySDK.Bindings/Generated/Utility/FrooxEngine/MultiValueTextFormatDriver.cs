
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiValueTextFormatDriver
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiValueTextFormatDriver")]
public partial class MultiValueTextFormatDriver : global::FrooxEngine.Component

{
    public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.IField>, global::FrooxEngine.IField, Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField>, global::FrooxEngine.IField>> Sources = new();
public global::System.String Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Format_Element = new();
public global::FrooxEngine.IField<global::System.String> Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sources", Sources.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Format", Format_Element.ToLinkField(context));
members.Add("Text", Text_Element.ToLinkReference(context));
}

}
}
