
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudServerStatus
// Generated on: čtvrtek 26. února 2026 10:03:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudServerStatus")]
public partial class CloudServerStatus : global::FrooxEngine.Component

{
    public global::SkyFrost.Base.ServerStatus Status { get => Status_Element.Data; set => Status_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::SkyFrost.Base.ServerStatus>, global::SkyFrost.Base.ServerStatus> Status_Element = new();
public global::System.Int32 ResponseTimeMilliseconds { get => ResponseTimeMilliseconds_Element.Data; set => ResponseTimeMilliseconds_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> ResponseTimeMilliseconds_Element = new();
public global::System.DateTime LastServerUpdateTime { get => LastServerUpdateTime_Element.Data; set => LastServerUpdateTime_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.DateTime>, global::System.DateTime> LastServerUpdateTime_Element = new();
public global::System.DateTime LastServerStateFetch { get => LastServerStateFetch_Element.Data; set => LastServerStateFetch_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.DateTime>, global::System.DateTime> LastServerStateFetch_Element = new();
public global::System.DateTime LastLocalServerResponseTime { get => LastLocalServerResponseTime_Element.Data; set => LastLocalServerResponseTime_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.DateTime>, global::System.DateTime> LastLocalServerResponseTime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Status", Status_Element.Data.ToResoniteLinkField());
members.Add("ResponseTimeMilliseconds", ResponseTimeMilliseconds_Element.Data.ToResoniteLinkField());
members.Add("LastServerUpdateTime", LastServerUpdateTime_Element.Data.ToResoniteLinkField());
members.Add("LastServerStateFetch", LastServerStateFetch_Element.Data.ToResoniteLinkField());
members.Add("LastLocalServerResponseTime", LastLocalServerResponseTime_Element.Data.ToResoniteLinkField());
}

}
}
