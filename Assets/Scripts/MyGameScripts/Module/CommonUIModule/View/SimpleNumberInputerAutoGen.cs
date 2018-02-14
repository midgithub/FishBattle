﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class SimpleNumberInputer : BaseView
{
    public const string NAME ="SimpleNumberInputer";

    #region Element Bindings

    /// bind gameobject
    public Transform InputNumberContent_Transform;
    public UIAnchor Content_UIAnchor;
    public UIEventListener CloseMask_UIEventListener;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        InputNumberContent_Transform = root.FindTrans("Content/InputNumberContent");
        Content_UIAnchor = root.FindScript<UIAnchor>("Content");
        CloseMask_UIEventListener = root.FindScript<UIEventListener>("CloseMask");
    }
    #endregion
}