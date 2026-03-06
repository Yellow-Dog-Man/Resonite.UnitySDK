
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleSettings")]
public partial class LocaleSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocaleSettings>

{
    public global::System.String PrimaryInterfaceLocaleCode { get => PrimaryInterfaceLocaleCode_Element.Data; set => PrimaryInterfaceLocaleCode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PrimaryInterfaceLocaleCode_Element = new();
public global::System.String CultureLocaleCode { get => CultureLocaleCode_Element.Data; set => CultureLocaleCode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CultureLocaleCode_Element = new();
public global::System.Boolean UseImperialUnits { get => UseImperialUnits_Element.Data; set => UseImperialUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseImperialUnits_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PrimaryInterfaceLocaleCode", PrimaryInterfaceLocaleCode_Element.ToLinkField(context));
members.Add("CultureLocaleCode", CultureLocaleCode_Element.ToLinkField(context));
members.Add("UseImperialUnits", UseImperialUnits_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task SetCurrentLocale(global::System.String localeCode, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "SetCurrentLocale";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("localeCode", localeCode.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
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
