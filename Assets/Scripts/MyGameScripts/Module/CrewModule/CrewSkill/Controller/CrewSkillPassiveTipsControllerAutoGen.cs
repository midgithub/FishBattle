﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  CrewSkillPassiveTipsController.cs
// the file is generated by tools
// **********************************************************************

using System;
using UniRx;

public partial class CrewSkillPassiveTipsController:MonolessViewController<CrewSkillPassiveTips>
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents()
    {
        btnMinus_UIButtonEvt = View.btnMinus_UIButton.AsObservable();
        btnAdd_UIButtonEvt = View.btnAdd_UIButton.AsObservable();
        btnMax_UIButtonEvt = View.btnMax_UIButton.AsObservable();
        btnUp_UIButtonEvt = View.btnUp_UIButton.AsObservable();
        btnUse_UIButtonEvt = View.btnUse_UIButton.AsObservable();
        btnForget_UIButtonEvt = View.btnForget_UIButton.AsObservable();
        btnLearn_UIButtonEvt = View.btnLearn_UIButton.AsObservable();
        btnWindowForget_UIButtonEvt = View.btnWindowForget_UIButton.AsObservable();
        btnCancel_UIButtonEvt = View.btnCancel_UIButton.AsObservable();
        btnBlackBG_UIButtonEvt = View.BlackBG_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        btnMinus_UIButtonEvt = btnMinus_UIButtonEvt.CloseOnceNull();
        btnAdd_UIButtonEvt = btnAdd_UIButtonEvt.CloseOnceNull();
        btnMax_UIButtonEvt = btnMax_UIButtonEvt.CloseOnceNull();
        btnUp_UIButtonEvt = btnUp_UIButtonEvt.CloseOnceNull();
        btnUse_UIButtonEvt = btnUse_UIButtonEvt.CloseOnceNull();
        btnForget_UIButtonEvt = btnForget_UIButtonEvt.CloseOnceNull();
        btnLearn_UIButtonEvt = btnLearn_UIButtonEvt.CloseOnceNull();
        btnWindowForget_UIButtonEvt = btnWindowForget_UIButtonEvt.CloseOnceNull();
        btnCancel_UIButtonEvt = btnCancel_UIButtonEvt.CloseOnceNull();
        btnBlackBG_UIButtonEvt = btnBlackBG_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> btnCancel_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnCancel_UIButtonEvt
    {
        get { return btnCancel_UIButtonEvt; }
    }

    private Subject<Unit> btnBlackBG_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnBlackBG_UIButtonEvt
    {
        get { return btnBlackBG_UIButtonEvt; }
    }

    private Subject<Unit> btnWindowForget_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnWindowsForget_UIButtonEvt
    {
        get { return btnWindowForget_UIButtonEvt; }
    }

    private Subject<Unit> btnMinus_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnMinus_UIButtonClick{
        get {return btnMinus_UIButtonEvt;}
    }

    private Subject<Unit> btnAdd_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnAdd_UIButtonClick{
        get {return btnAdd_UIButtonEvt;}
    }

    private Subject<Unit> btnMax_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnMax_UIButtonClick{
        get {return btnMax_UIButtonEvt;}
    }

    private Subject<Unit> btnUp_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnUp_UIButtonClick{
        get {return btnUp_UIButtonEvt;}
    }

    private Subject<Unit> btnUse_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnUse_UIButtonClick{
        get {return btnUse_UIButtonEvt;}
    }

    private Subject<Unit> btnForget_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnForget_UIButtonClick{
        get {return btnForget_UIButtonEvt;}
    }

    private Subject<Unit> btnLearn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnLearn_UIButtonClick{
        get {return btnLearn_UIButtonEvt;}
    }

    public UniRx.IObservable<string> InputValueChange
    {
        get { return View.btnNum_UIInput.OnValueChangeAsObservable(); }
    }

}