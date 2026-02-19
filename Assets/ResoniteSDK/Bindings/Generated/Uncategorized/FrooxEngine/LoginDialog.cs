
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LoginDialog
// Generated on: čtvrtek 19. února 2026 8:00:29
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RegisterOnly", RegisterOnly.ToResoniteLinkField());
members.Add("_interactionEnabled", _interactionEnabled.ToResoniteLinkField());
members.Add("_swapRegion", _swapRegion.ToResoniteReference(context));
members.Add("_username", _username.ToResoniteReference(context));
members.Add("_email", _email.ToResoniteReference(context));
members.Add("_emailRepeat", _emailRepeat.ToResoniteReference(context));
members.Add("_password", _password.ToResoniteReference(context));
members.Add("_passwordRepeat", _passwordRepeat.ToResoniteReference(context));
members.Add("_recoveryCode", _recoveryCode.ToResoniteReference(context));
members.Add("_birthMonth", _birthMonth.ToResoniteReference(context));
members.Add("_birthDay", _birthDay.ToResoniteReference(context));
members.Add("_birthYear", _birthYear.ToResoniteReference(context));
members.Add("_rememberLogin", _rememberLogin.ToResoniteReference(context));
members.Add("_resetUserId", _resetUserId.ToResoniteReference(context));
members.Add("_policies", _policies.ToResoniteReference(context));
members.Add("_registerButton", _registerButton.ToResoniteReference(context));
members.Add("_loginEmail", _loginEmail.ToResoniteLinkField());
}

}
}
