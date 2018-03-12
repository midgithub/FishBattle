﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using AppDto;
using MyGameScripts.Gameplay.Player;
using System.Collections.Generic;
using UnityEngine;

public sealed class AttrLabelCell : BaseView
{
    public const string NAME ="AttrLabelCell";

    #region Element Bindings

    /// bind gameobject
    public UILabel Number_UILabel;
    public UILabel Name_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Number_UILabel = root.FindScript<UILabel>("Number");
        Name_UILabel = root.FindScript<UILabel>("Name");

    }
    #endregion
}


public partial class AttrLabelCellController : MonolessViewController<AttrLabelCell>
{
    private List<CharacterAbility> characterList = DataCache.getArrayByCls<CharacterAbility>();

    public void SetInfo(CharacterPropertyDto dto)
    {
        bool isPercent = false;

        if (characterList.Find(x => x.id == dto.propId) != null)
            isPercent = characterList.Find(x => x.id == dto.propId).per;

        if (dto.propId == GlobalAttr.Crew_Grow)
            _view.Number_UILabel.text = dto.propValue.ToString();
        else if (isPercent)
            _view.Number_UILabel.text = string.Format("{0}%", Mathf.Floor(dto.propValue * 100).ToString());
        else
            _view.Number_UILabel.text = Mathf.Floor(dto.propValue).ToString();

        _view.Name_UILabel.text = GlobalAttr.GetAttrName(dto.propId);
        //UIHelper.SetOtherIcon(_view.Icon_UISprite, "");
    }


}