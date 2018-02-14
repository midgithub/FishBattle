﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class EveryDayMissionPanel : BaseView
{
    public const string NAME ="EveryDayMissionPanel";

    #region Element Bindings

    /// bind gameobject
    public UIButton ClickBtnBoxCollider_UIButton;
    public UIGrid UIGrid_Grid;
    public Transform SelectEffect_Transform;
    public UILabel MissionNumber_UILabel;
    public UIPanel mEveryDayMissionPanel;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        UIGrid_Grid = root.FindScript<UIGrid>("Grid");
        ClickBtnBoxCollider_UIButton = root.FindScript<UIButton>("BG/CloseBtn");
        SelectEffect_Transform = root.FindScript<Transform>("SelectEffect");
        MissionNumber_UILabel = root.FindScript<UILabel>("DesBg/Label");
        mEveryDayMissionPanel = root.FindScript<UIPanel>("");
    }
    #endregion
}