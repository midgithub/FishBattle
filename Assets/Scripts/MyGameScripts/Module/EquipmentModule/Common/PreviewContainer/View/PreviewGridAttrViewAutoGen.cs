﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class PreviewGridAttrView : BaseView
{
    public const string NAME ="PreviewGridAttrView";

    #region Element Bindings

    /// bind gameobject
    public UIGrid GridContent_UIGrid;
    public UIWidget PreviewGridAttrView_UIWidget;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        GridContent_UIGrid = root.FindScript<UIGrid>("GridContent");
        PreviewGridAttrView_UIWidget = root.FindScript<UIWidget>("");

    }
    #endregion
}