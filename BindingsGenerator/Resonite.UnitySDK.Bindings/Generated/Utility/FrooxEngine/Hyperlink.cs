
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Hyperlink
// Generated on: pátek 6. března 2026 14:19:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Hyperlink")]
public partial class Hyperlink : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IButtonPressReceiver

{
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::System.Boolean OpenOnce { get => OpenOnce_Element.Data; set => OpenOnce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OpenOnce_Element = new();
public global::System.String Reason { get => Reason_Element.Data; set => Reason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Reason_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkField(context));
members.Add("OpenOnce", OpenOnce_Element.ToLinkField(context));
members.Add("Reason", Reason_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task<global::System.Boolean> Open(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Open";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
