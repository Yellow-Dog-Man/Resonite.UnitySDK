
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraRenderSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraRenderSettings")]
public partial class InteractiveCameraRenderSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraRenderSettings>

{
    public global::System.Boolean HideAllBadges { get => HideAllBadges_Element.Data; set => HideAllBadges_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideAllBadges_Element = new();
public global::System.Boolean HideAllLasers { get => HideAllLasers_Element.Data; set => HideAllLasers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideAllLasers_Element = new();
public global::System.Boolean ForceEyesOnCamera { get => ForceEyesOnCamera_Element.Data; set => ForceEyesOnCamera_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceEyesOnCamera_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HideAllBadges", HideAllBadges_Element.ToLinkField(context));
members.Add("HideAllLasers", HideAllLasers_Element.ToLinkField(context));
members.Add("ForceEyesOnCamera", ForceEyesOnCamera_Element.ToLinkField(context));
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
