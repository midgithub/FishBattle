﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  EquipmentInsetMedallionViewController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IEquipmentInsetMedallionViewController
{
     UniRx.IObservable<Unit> OnMakeBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnInsetBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnTipsBtn_UIButtonClick{get;}

}

public partial class EquipmentInsetMedallionViewController:MonolessViewController<EquipmentInsetMedallionView>, IEquipmentInsetMedallionViewController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        MakeBtn_UIButtonEvt = View.MakeBtn_UIButton.AsObservable();
        InsetBtn_UIButtonEvt = View.InsetBtn_UIButton.AsObservable();
        TipsBtn_UIButtonEvt = View.TipsBtn_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        MakeBtn_UIButtonEvt = MakeBtn_UIButtonEvt.CloseOnceNull();
        InsetBtn_UIButtonEvt = InsetBtn_UIButtonEvt.CloseOnceNull();
        TipsBtn_UIButtonEvt = TipsBtn_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> MakeBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnMakeBtn_UIButtonClick{
        get {return MakeBtn_UIButtonEvt;}
    }

    private Subject<Unit> InsetBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnInsetBtn_UIButtonClick{
        get {return InsetBtn_UIButtonEvt;}
    }

    private Subject<Unit> TipsBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnTipsBtn_UIButtonClick{
        get {return TipsBtn_UIButtonEvt;}
    }


}