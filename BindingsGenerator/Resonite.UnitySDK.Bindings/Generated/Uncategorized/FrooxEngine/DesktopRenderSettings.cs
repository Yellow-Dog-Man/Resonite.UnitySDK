
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopRenderSettings
// Generated on: pátek 6. března 2026 14:19:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopRenderSettings")]
public partial class DesktopRenderSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DesktopRenderSettings>

{
    public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
public global::System.Boolean SprintFieldOfViewZoom { get => SprintFieldOfViewZoom_Element.Data; set => SprintFieldOfViewZoom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SprintFieldOfViewZoom_Element = new();
public global::System.Boolean VSync { get => VSync_Element.Data; set => VSync_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VSync_Element = new();
public global::System.Boolean LimitFramerateWhenUnfocused { get => LimitFramerateWhenUnfocused_Element.Data; set => LimitFramerateWhenUnfocused_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LimitFramerateWhenUnfocused_Element = new();
public global::System.Int32 MaximumBackgroundFramerate { get => MaximumBackgroundFramerate_Element.Data; set => MaximumBackgroundFramerate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaximumBackgroundFramerate_Element = new();
public global::System.Boolean FramePacingOptionsEnabled { get => FramePacingOptionsEnabled_Element.Data; set => FramePacingOptionsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FramePacingOptionsEnabled_Element = new();
public global::System.Boolean BackgroundFramerateEnabled { get => BackgroundFramerateEnabled_Element.Data; set => BackgroundFramerateEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BackgroundFramerateEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("SprintFieldOfViewZoom", SprintFieldOfViewZoom_Element.ToLinkField(context));
members.Add("VSync", VSync_Element.ToLinkField(context));
members.Add("LimitFramerateWhenUnfocused", LimitFramerateWhenUnfocused_Element.ToLinkField(context));
members.Add("MaximumBackgroundFramerate", MaximumBackgroundFramerate_Element.ToLinkField(context));
members.Add("FramePacingOptionsEnabled", FramePacingOptionsEnabled_Element.ToLinkField(context));
members.Add("BackgroundFramerateEnabled", BackgroundFramerateEnabled_Element.ToLinkField(context));
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
