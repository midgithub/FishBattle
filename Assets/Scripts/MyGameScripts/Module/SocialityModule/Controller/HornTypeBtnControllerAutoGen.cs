﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  HornTypeBtnController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IHornTypeBtnController
{
     UniRx.IObservable<Unit> OnHornTypeBtn_UIButtonClick{get;}

}

public partial class HornTypeBtnController:MonolessViewController<HornTypeBtn>, IHornTypeBtnController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        HornTypeBtn_UIButtonEvt = View.HornTypeBtn_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        HornTypeBtn_UIButtonEvt = HornTypeBtn_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> HornTypeBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnHornTypeBtn_UIButtonClick{
        get {return HornTypeBtn_UIButtonEvt;}
    }


}