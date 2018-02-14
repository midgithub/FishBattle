﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class S3PopupList : BaseView
{
    public const string NAME = "S3PopupList";

    #region Element Bindings

    /// bind gameobject
    public GameObject itemContent;
    public UILabel PopupLabel_UILabel;
    public UISprite Bg_UISprite;
    public GameObject itemList;
    public UIButton Bg_UIButton;
    public UISprite ItemListBg_UISprite;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        itemContent = root.FindGameObject("itemList/itemContent");
        PopupLabel_UILabel = root.FindScript<UILabel>("Bg/PopupLabel");
        Bg_UISprite = root.FindScript<UISprite>("Bg");
        itemList = root.FindGameObject("itemList");
        Bg_UIButton = root.FindScript<UIButton>("Bg");
        ItemListBg_UISprite = root.FindScript<UISprite>("itemList/ItemListBg");

    }
    #endregion
}