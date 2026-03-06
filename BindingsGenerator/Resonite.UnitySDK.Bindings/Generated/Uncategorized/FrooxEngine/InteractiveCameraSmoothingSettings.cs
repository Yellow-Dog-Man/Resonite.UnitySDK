
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraSmoothingSettings
// Generated on: pátek 6. března 2026 14:19:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraSmoothingSettings")]
public partial class InteractiveCameraSmoothingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraSmoothingSettings>

{
    public global::System.Single PositionSmoothSpeed { get => PositionSmoothSpeed_Element.Data; set => PositionSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSmoothSpeed_Element = new();
public global::System.Single AngleSmoothSpeed { get => AngleSmoothSpeed_Element.Data; set => AngleSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngleSmoothSpeed_Element = new();
public global::System.Single FramingSmoothSpeed { get => FramingSmoothSpeed_Element.Data; set => FramingSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FramingSmoothSpeed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionSmoothSpeed", PositionSmoothSpeed_Element.ToLinkField(context));
members.Add("AngleSmoothSpeed", AngleSmoothSpeed_Element.ToLinkField(context));
members.Add("FramingSmoothSpeed", FramingSmoothSpeed_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task ResetToDefault(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ResetToDefault";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
