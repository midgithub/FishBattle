﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class CrewPropPoint : BaseView
{
    public const string NAME ="CrewPropPoint";

    #region Element Bindings

    /// bind gameobject
    public UITexture ttShow_UITexture;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        ttShow_UITexture = root.FindScript<UITexture>("ttShow");

    }
    #endregion
}