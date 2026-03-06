
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HostAccessSettings+Entry
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
    public partial class HostAccessSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HostAccessSettings+Entry")]
public partial class Entry : global::FrooxEngine.SyncObject

{
    public global::System.Boolean AllowHTTP_Requests { get => AllowHTTP_Requests_Element.Data; set => AllowHTTP_Requests_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowHTTP_Requests_Element = new();
public global::System.Boolean AllowWebsockets { get => AllowWebsockets_Element.Data; set => AllowWebsockets_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWebsockets_Element = new();
public global::System.Boolean AllowOSC_Receiving { get => AllowOSC_Receiving_Element.Data; set => AllowOSC_Receiving_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowOSC_Receiving_Element = new();
public global::System.Boolean AllowOSC_Sending { get => AllowOSC_Sending_Element.Data; set => AllowOSC_Sending_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowOSC_Sending_Element = new();
public global::System.Boolean HTTP_RequestsSet { get => HTTP_RequestsSet_Element.Data; set => HTTP_RequestsSet_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HTTP_RequestsSet_Element = new();
public global::System.Boolean WebsocketsSet { get => WebsocketsSet_Element.Data; set => WebsocketsSet_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WebsocketsSet_Element = new();
public global::System.Boolean OSC_SenderSet { get => OSC_SenderSet_Element.Data; set => OSC_SenderSet_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OSC_SenderSet_Element = new();
public global::System.Boolean OSC_ReceiverSet { get => OSC_ReceiverSet_Element.Data; set => OSC_ReceiverSet_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OSC_ReceiverSet_Element = new();
public global::System.String LastHyperlinkRequestReason { get => LastHyperlinkRequestReason_Element.Data; set => LastHyperlinkRequestReason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> LastHyperlinkRequestReason_Element = new();
public global::System.String LastWebsocketRequestReason { get => LastWebsocketRequestReason_Element.Data; set => LastWebsocketRequestReason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> LastWebsocketRequestReason_Element = new();
public global::System.String LastOSC_SenderRequestReason { get => LastOSC_SenderRequestReason_Element.Data; set => LastOSC_SenderRequestReason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> LastOSC_SenderRequestReason_Element = new();
public global::System.String LastOSC_ReceiverRequestReason { get => LastOSC_ReceiverRequestReason_Element.Data; set => LastOSC_ReceiverRequestReason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> LastOSC_ReceiverRequestReason_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.Int32>, global::System.Int32, Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32>> AllowedPorts = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.Int32>, global::System.Int32, Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32>> BlockedPorts = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowHTTP_Requests", AllowHTTP_Requests_Element.ToLinkField(context));
members.Add("AllowWebsockets", AllowWebsockets_Element.ToLinkField(context));
members.Add("AllowOSC_Receiving", AllowOSC_Receiving_Element.ToLinkField(context));
members.Add("AllowOSC_Sending", AllowOSC_Sending_Element.ToLinkField(context));
members.Add("HTTP_RequestsSet", HTTP_RequestsSet_Element.ToLinkField(context));
members.Add("WebsocketsSet", WebsocketsSet_Element.ToLinkField(context));
members.Add("OSC_SenderSet", OSC_SenderSet_Element.ToLinkField(context));
members.Add("OSC_ReceiverSet", OSC_ReceiverSet_Element.ToLinkField(context));
members.Add("LastHyperlinkRequestReason", LastHyperlinkRequestReason_Element.ToLinkField(context));
members.Add("LastWebsocketRequestReason", LastWebsocketRequestReason_Element.ToLinkField(context));
members.Add("LastOSC_SenderRequestReason", LastOSC_SenderRequestReason_Element.ToLinkField(context));
members.Add("LastOSC_ReceiverRequestReason", LastOSC_ReceiverRequestReason_Element.ToLinkField(context));
members.Add("AllowedPorts", AllowedPorts.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("BlockedPorts", BlockedPorts.ToLinkList(context, m => m.ToLinkField(context)));
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
