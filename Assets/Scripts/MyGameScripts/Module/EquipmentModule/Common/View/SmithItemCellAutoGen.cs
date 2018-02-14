﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class SmithItemCell : BaseView
{
    public const string NAME ="SmithItemCell";

    #region Element Bindings

    /// bind gameobject
    public GameObject ItemCellAnchor;
    public UILabel CountLbl_UILabel;
    public UILabel NameLbl_UILabel;
    public UIButton SmithItem_UIButton;
    public UISprite AddBg_UISprite;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        SmithItem_UIButton = root.FindScript<UIButton>("");
        ItemCellAnchor = root.FindGameObject("ItemCellAnchor");
        CountLbl_UILabel = root.FindScript<UILabel>("CountLbl");
        NameLbl_UILabel = root.FindScript<UILabel>("NameLbl");
        AddBg_UISprite = root.FindScript<UISprite>("AddBg");

    }
    #endregion
}