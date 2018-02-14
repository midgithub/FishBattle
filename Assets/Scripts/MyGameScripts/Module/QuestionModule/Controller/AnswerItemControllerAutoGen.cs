﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  TxtAnswerItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IAnswerItemController
{
     UniRx.IObservable<Unit> OnTxtAnswerItem_UIButtonClick{get;}

}

public partial class AnswerItemController : MonolessViewController<AnswerItem>, IAnswerItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        TxtAnswerItem_UIButtonEvt = View.AnswerItem_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        TxtAnswerItem_UIButtonEvt = TxtAnswerItem_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> TxtAnswerItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnTxtAnswerItem_UIButtonClick{
        get {return TxtAnswerItem_UIButtonEvt;}
    }


}