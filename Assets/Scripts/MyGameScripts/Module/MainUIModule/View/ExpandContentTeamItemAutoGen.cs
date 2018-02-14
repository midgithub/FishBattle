﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class ExpandContentTeamItem : BaseView
{
    public const string NAME ="ExpandContentTeamItem";

    #region Element Bindings

    /// bind gameobject
    public UISprite Icon_UISprite;
    public UISprite factionIcon_UISprite;
    public UILabel playerLevel_UILabel;
    public UILabel playerName_UILabel;
    public UIButton ExpandContentTeamItem_UIButton;
    public UISprite magicIcon_UISprite;
    public UISprite Leave_UISprite;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Icon_UISprite = root.FindScript<UISprite>("IconBg/Icon");
        factionIcon_UISprite = root.FindScript<UISprite>("factionIcon");
        playerLevel_UILabel = root.FindScript<UILabel>("playerLevel");
        playerName_UILabel = root.FindScript<UILabel>("playerName");
        ExpandContentTeamItem_UIButton = root.FindScript<UIButton>("");
        magicIcon_UISprite = root.FindScript<UISprite>("magicIcon");
        Leave_UISprite = root.FindScript<UISprite>("Leave");

    }
    #endregion
}