﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class GMCodeView : BaseView
{
    public const string NAME ="GMCodeView";

    #region Element Bindings

    /// bind gameobject
    public Transform Content_Transform;
    public UIInput txtInput_UIInput;
    public UIButton btnSend_UIButton;
    public UIGrid tabBtn_UIGrid;
    public UILabel lblDesc_UILabel;
    public UIScrollView scrollView_UIScrollView;
    public UIWidget Container_UIWidget;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Content_Transform = root.FindTrans("Content");
        txtInput_UIInput = root.FindScript<UIInput>("Content/txtInput");
        btnSend_UIButton = root.FindScript<UIButton>("Content/btnSend");
        tabBtn_UIGrid = root.FindScript<UIGrid>("Content/tabBtn");
        lblDesc_UILabel = root.FindScript<UILabel>("Content/lblDesc");
        scrollView_UIScrollView = root.FindScript<UIScrollView>("Content/scrollView");
        Container_UIWidget = root.FindScript<UIWidget>("Content/scrollView/Container");
    }
    #endregion
}