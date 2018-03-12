﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class RedPackItem : BaseView
{
    public const string NAME ="RedPackItem";

    #region Element Bindings

    /// bind gameobject
    public UIButton RedPackItem_UIButton;
    public UILabel PlayerName_UILabel;
    public UILabel word_UILabel;
    public UISprite Open_Sprite;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        RedPackItem_UIButton = root.FindScript<UIButton>("");
        PlayerName_UILabel = root.FindScript<UILabel>("PlayerName");
        word_UILabel = root.FindScript<UILabel>("word");
        
    }
    #endregion
}