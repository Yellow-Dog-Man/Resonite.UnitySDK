
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CursorSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CursorSettings")]
public partial class CursorSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.CursorSettings>

{
    public global::System.Single BaseCursorSize { get => BaseCursorSize_Element.Data; set => BaseCursorSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseCursorSize_Element = new();
public global::System.Single GrabMultiplier { get => GrabMultiplier_Element.Data; set => GrabMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GrabMultiplier_Element = new();
public global::System.Single InteractionMultiplier { get => InteractionMultiplier_Element.Data; set => InteractionMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InteractionMultiplier_Element = new();
public global::System.Single TextMultiplier { get => TextMultiplier_Element.Data; set => TextMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TextMultiplier_Element = new();
public global::System.Single SliderMultiplier { get => SliderMultiplier_Element.Data; set => SliderMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SliderMultiplier_Element = new();
public global::System.Boolean DirectCursorEnabled { get => DirectCursorEnabled_Element.Data; set => DirectCursorEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DirectCursorEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseCursorSize", BaseCursorSize_Element.ToLinkField(context));
members.Add("GrabMultiplier", GrabMultiplier_Element.ToLinkField(context));
members.Add("InteractionMultiplier", InteractionMultiplier_Element.ToLinkField(context));
members.Add("TextMultiplier", TextMultiplier_Element.ToLinkField(context));
members.Add("SliderMultiplier", SliderMultiplier_Element.ToLinkField(context));
members.Add("DirectCursorEnabled", DirectCursorEnabled_Element.ToLinkField(context));
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
