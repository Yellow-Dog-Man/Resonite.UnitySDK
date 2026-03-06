
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeterTool
// Generated on: pátek 6. března 2026 14:19:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeterTool")]
public partial class MeterTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> _indicationColor { get => _indicationColor_Element.Data; set => _indicationColor_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>> _indicationColor_Element = new();
public global::FrooxEngine.MeterTool.Mode MeterMode { get => MeterMode_Element.Data; set => MeterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MeterTool.Mode>, global::FrooxEngine.MeterTool.Mode> MeterMode_Element = new();
public global::System.Boolean MeasureInObjectSpace { get => MeasureInObjectSpace_Element.Data; set => MeasureInObjectSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MeasureInObjectSpace_Element = new();
public global::System.Boolean RaycastIgnoresUsers { get => RaycastIgnoresUsers_Element.Data; set => RaycastIgnoresUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RaycastIgnoresUsers_Element = new();
public global::System.Boolean MultiPoint { get => MultiPoint_Element.Data; set => MultiPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MultiPoint_Element = new();
public global::FrooxEngine.Slot _lastPoint { get => _lastPoint_Element.Data; set => _lastPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _lastPoint_Element = new();
public global::FrooxEngine.DistanceMeter _currentMeter { get => _currentMeter_Element.Data; set => _currentMeter_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.DistanceMeter>, global::FrooxEngine.DistanceMeter> _currentMeter_Element = new();
public global::FrooxEngine.LineTransform _currentLineTransform { get => _currentLineTransform_Element.Data; set => _currentLineTransform_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LineTransform>, global::FrooxEngine.LineTransform> _currentLineTransform_Element = new();
public global::System.String FormatNumber { get => FormatNumber_Element.Data; set => FormatNumber_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FormatNumber_Element = new();
public global::System.String FormatUnit { get => FormatUnit_Element.Data; set => FormatUnit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FormatUnit_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_indicationColor", _indicationColor_Element.ToLinkReference(context));
members.Add("MeterMode", MeterMode_Element.ToLinkField(context));
members.Add("MeasureInObjectSpace", MeasureInObjectSpace_Element.ToLinkField(context));
members.Add("RaycastIgnoresUsers", RaycastIgnoresUsers_Element.ToLinkField(context));
members.Add("MultiPoint", MultiPoint_Element.ToLinkField(context));
members.Add("_lastPoint", _lastPoint_Element.ToLinkReference(context));
members.Add("_currentMeter", _currentMeter_Element.ToLinkReference(context));
members.Add("_currentLineTransform", _currentLineTransform_Element.ToLinkReference(context));
members.Add("FormatNumber", FormatNumber_Element.ToLinkField(context));
members.Add("FormatUnit", FormatUnit_Element.ToLinkField(context));
}
public static async System.Threading.Tasks.Task<global::System.Boolean> FilterUsers(global::FrooxEngine.ICollider collider, IConversionContext context)
{
        var __message = new ResoniteLink.CallStaticSyncMethod();
        __message.MethodName = "FilterUsers";
__message.TargetType = "[FrooxEngine]FrooxEngine.MeterTool";
__message.Arguments.Add("collider", new ResoniteLink.Data_Reference() { TargetID = context.GetId(collider) });
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
