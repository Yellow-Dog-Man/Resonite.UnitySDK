
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GamepadSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GamepadSettings")]
public partial class GamepadSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GamepadSettings>

{
    public global::System.Single ThumbstickLookSpeed { get => ThumbstickLookSpeed_Element.Data; set => ThumbstickLookSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThumbstickLookSpeed_Element = new();
public global::System.Single ThumbstickLookExponent { get => ThumbstickLookExponent_Element.Data; set => ThumbstickLookExponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThumbstickLookExponent_Element = new();
public global::System.Boolean UseGamepadWhenUnfocused { get => UseGamepadWhenUnfocused_Element.Data; set => UseGamepadWhenUnfocused_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseGamepadWhenUnfocused_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ThumbstickLookSpeed", ThumbstickLookSpeed_Element.ToLinkField(context));
members.Add("ThumbstickLookExponent", ThumbstickLookExponent_Element.ToLinkField(context));
members.Add("UseGamepadWhenUnfocused", UseGamepadWhenUnfocused_Element.ToLinkField(context));
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
