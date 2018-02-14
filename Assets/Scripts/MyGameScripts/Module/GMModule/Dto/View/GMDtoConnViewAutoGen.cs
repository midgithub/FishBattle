﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class GMDtoConnView : BaseView
{
    public const string NAME ="GMDtoConnView";

    #region Element Bindings

    /// bind gameobject
    public GameObject chbStart;
    public UIInput txtInput_UIInput;
    public UIButton btnConfirm_UIButton;
    public UIButton btnClear_UIButton;
    public UIWidget Container_UIWidget;
    public UILabel lblInfo_UILabel;
    public UIScrollView scrollViewRight_UIScrollView;
    public UIWidget containerList_UIWidget;
    public GameObject chbShield;
    public UIScrollView scrollViewLeft_UIScrollView;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        chbStart = root.FindGameObject("Content/chbStart");
        txtInput_UIInput = root.FindScript<UIInput>("Content/txtInput");
        btnConfirm_UIButton = root.FindScript<UIButton>("Content/btnConfirm");
        btnClear_UIButton = root.FindScript<UIButton>("Content/btnClear");
        Container_UIWidget = root.FindScript<UIWidget>("Content/scrollViewRight/Container");
        lblInfo_UILabel = root.FindScript<UILabel>("Content/scrollViewRight/Container/lblInfo");
        scrollViewRight_UIScrollView = root.FindScript<UIScrollView>("Content/scrollViewRight");
        containerList_UIWidget = root.FindScript<UIWidget>("Content/scrollViewLeft/containerList");
        chbShield = root.FindGameObject("Content/chbShield");
        scrollViewLeft_UIScrollView = root.FindScript<UIScrollView>("Content/scrollViewLeft");

    }
    #endregion
}