
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LoginDialog
// Generated on: pátek 13. února 2026 5:52:34
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LoginDialog")]
public partial class LoginDialog : global::FrooxEngine.Component

{
    public global::System.Boolean RegisterOnly;
public global::System.Boolean _interactionEnabled;
public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion;
public global::FrooxEngine.UIX.TextField _username;
public global::FrooxEngine.UIX.TextField _email;
public global::FrooxEngine.UIX.TextField _emailRepeat;
public global::FrooxEngine.UIX.TextField _password;
public global::FrooxEngine.UIX.TextField _passwordRepeat;
public global::FrooxEngine.UIX.TextField _recoveryCode;
public global::FrooxEngine.IntTextEditorParser _birthMonth;
public global::FrooxEngine.IntTextEditorParser _birthDay;
public global::FrooxEngine.IntTextEditorParser _birthYear;
public global::FrooxEngine.UIX.Checkbox _rememberLogin;
public global::FrooxEngine.UIX.Checkbox _resetUserId;
public global::FrooxEngine.UIX.Checkbox _policies;
public global::FrooxEngine.UIX.Button _registerButton;
public global::System.String _loginEmail;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RegisterOnly", RegisterOnly.ToResoniteLinkField());
members.Add("_interactionEnabled", _interactionEnabled.ToResoniteLinkField());
members.Add("_swapRegion", new ResoniteLink.Reference() { });
members.Add("_username", new ResoniteLink.Reference() { });
members.Add("_email", new ResoniteLink.Reference() { });
members.Add("_emailRepeat", new ResoniteLink.Reference() { });
members.Add("_password", new ResoniteLink.Reference() { });
members.Add("_passwordRepeat", new ResoniteLink.Reference() { });
members.Add("_recoveryCode", new ResoniteLink.Reference() { });
members.Add("_birthMonth", new ResoniteLink.Reference() { });
members.Add("_birthDay", new ResoniteLink.Reference() { });
members.Add("_birthYear", new ResoniteLink.Reference() { });
members.Add("_rememberLogin", new ResoniteLink.Reference() { });
members.Add("_resetUserId", new ResoniteLink.Reference() { });
members.Add("_policies", new ResoniteLink.Reference() { });
members.Add("_registerButton", new ResoniteLink.Reference() { });
members.Add("_loginEmail", _loginEmail.ToResoniteLinkField());
}

}
}
