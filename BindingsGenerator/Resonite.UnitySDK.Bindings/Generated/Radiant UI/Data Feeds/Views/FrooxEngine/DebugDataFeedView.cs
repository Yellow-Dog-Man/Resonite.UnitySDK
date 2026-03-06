
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugDataFeedView
// Generated on: pátek 6. března 2026 14:19:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugDataFeedView")]
public partial class DebugDataFeedView : global::FrooxEngine.DataFeedViewBase

{
    public global::FrooxEngine.IField<global::System.String> TargetOutput { get => TargetOutput_Element.Data; set => TargetOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> TargetOutput_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetOutput", TargetOutput_Element.ToLinkReference(context));
}

}
}
