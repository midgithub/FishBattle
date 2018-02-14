﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  CrewRewardItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface ICrewRewardItemController
{
     UniRx.IObservable<Unit> OnCrewRewardItem_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnIconSprite_UIButtonClick{get;}

}

public partial class CrewRewardItemController:MonolessViewController<CrewRewardItem>, ICrewRewardItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        CrewRewardItem_UIButtonEvt = View.CrewRewardItem_UIButton.AsObservable();
        IconSprite_UIButtonEvt = View.IconSprite_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        CrewRewardItem_UIButtonEvt = CrewRewardItem_UIButtonEvt.CloseOnceNull();
        IconSprite_UIButtonEvt = IconSprite_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> CrewRewardItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnCrewRewardItem_UIButtonClick{
        get {return CrewRewardItem_UIButtonEvt;}
    }

    private Subject<Unit> IconSprite_UIButtonEvt;
    public UniRx.IObservable<Unit> OnIconSprite_UIButtonClick{
        get {return IconSprite_UIButtonEvt;}
    }


}