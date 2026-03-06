
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GiggleTechSettings+Device
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
    public partial class GiggleTechSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GiggleTechSettings+Device")]
public partial class Device : global::FrooxEngine.SyncObject

{
    public global::System.String IP { get => IP_Element.Data; set => IP_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> IP_Element = new();
public global::System.Boolean IsConnected { get => IsConnected_Element.Data; set => IsConnected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsConnected_Element = new();
public global::System.Boolean UseDevice { get => UseDevice_Element.Data; set => UseDevice_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseDevice_Element = new();
public global::System.Boolean AlwaysTreatAsConnected { get => AlwaysTreatAsConnected_Element.Data; set => AlwaysTreatAsConnected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysTreatAsConnected_Element = new();
public global::System.String CustomName { get => CustomName_Element.Data; set => CustomName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CustomName_Element = new();
public global::System.Single IntensityScale { get => IntensityScale_Element.Data; set => IntensityScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IntensityScale_Element = new();
public global::System.Single MinimumIntensity { get => MinimumIntensity_Element.Data; set => MinimumIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumIntensity_Element = new();
public global::System.Single InitialActivationIntensity { get => InitialActivationIntensity_Element.Data; set => InitialActivationIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InitialActivationIntensity_Element = new();
public global::FrooxEngine.HapticPointMapping HapticPointMapping = new();
public global::System.Int32 HapticPointIndex { get => HapticPointIndex_Element.Data; set => HapticPointIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> HapticPointIndex_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IP", IP_Element.ToLinkField(context));
members.Add("IsConnected", IsConnected_Element.ToLinkField(context));
members.Add("UseDevice", UseDevice_Element.ToLinkField(context));
members.Add("AlwaysTreatAsConnected", AlwaysTreatAsConnected_Element.ToLinkField(context));
members.Add("CustomName", CustomName_Element.ToLinkField(context));
members.Add("IntensityScale", IntensityScale_Element.ToLinkField(context));
members.Add("MinimumIntensity", MinimumIntensity_Element.ToLinkField(context));
members.Add("InitialActivationIntensity", InitialActivationIntensity_Element.ToLinkField(context));
members.Add("HapticPointMapping", HapticPointMapping.ToLinkSyncObject(context));
members.Add("HapticPointIndex", HapticPointIndex_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task Remove(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Remove";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
            }
}
