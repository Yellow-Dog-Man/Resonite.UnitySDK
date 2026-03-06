
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoStreamingServicesSettings
// Generated on: pátek 6. března 2026 14:19:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoStreamingServicesSettings")]
public partial class VideoStreamingServicesSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.VideoStreamingServicesSettings>

{
    public global::NYoutubeDL.Options.CookiesBrowser UseCookiesFromBrowser { get => UseCookiesFromBrowser_Element.Data; set => UseCookiesFromBrowser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::NYoutubeDL.Options.CookiesBrowser>, global::NYoutubeDL.Options.CookiesBrowser> UseCookiesFromBrowser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseCookiesFromBrowser", UseCookiesFromBrowser_Element.ToLinkField(context));
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
