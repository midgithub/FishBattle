﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UniRx;




public partial interface ITempBackPackView{
         UniRx.IObservable<Unit> OnTransBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnCloseBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnTransAllBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnArrangeBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnDecomposeBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnComposite_UIButtonClick{get;}

    
}

public sealed partial class TempBackPackView :
    BaseView,ITempBackPackView
{
    public const string NAME ="TempBackPackView";

    #region Element Bindings

    /// bind gameobject
        private UIButton TransBtn_UIButton;
    private UIButton CloseBtn_UIButton;
    private UILabel transLabel_UILabel;
    private UIButton TransAllBtn_UIButton;
    private UILabel transAllLabel_UILabel;
    private UIButton ArrangeBtn_UIButton;
    private UILabel arrayLabel_UILabel;
    private UIButton DecomposeBtn_UIButton;
    private UILabel decomposeLabel_UILabel;
    private UIButton Composite_UIButton;
    private GameObject TempAnchor;
    private GameObject BackAnchor;
    private UILabel CompositeLabel_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
                TransBtn_UIButton = root.FindScript<UIButton>("BtnAnchor/TransBtn");
        CloseBtn_UIButton = root.FindScript<UIButton>("BaseMainWindow/CloseBtn");
        transLabel_UILabel = root.FindScript<UILabel>("BtnAnchor/TransBtn/transLabel");
        TransAllBtn_UIButton = root.FindScript<UIButton>("BtnAnchor/TransAllBtn");
        transAllLabel_UILabel = root.FindScript<UILabel>("BtnAnchor/TransAllBtn/transAllLabel");
        ArrangeBtn_UIButton = root.FindScript<UIButton>("BtnAnchor/btngroup/ArrangeBtn");
        arrayLabel_UILabel = root.FindScript<UILabel>("BtnAnchor/btngroup/ArrangeBtn/arrayLabel");
        DecomposeBtn_UIButton = root.FindScript<UIButton>("BtnAnchor/btngroup/DecomposeBtn");
        decomposeLabel_UILabel = root.FindScript<UILabel>("BtnAnchor/btngroup/DecomposeBtn/decomposeLabel");
        Composite_UIButton = root.FindScript<UIButton>("BtnAnchor/btngroup/Composite");
        TempAnchor = root.FindGameObject("TempAnchor");
        BackAnchor = root.FindGameObject("BackAnchor");
        CompositeLabel_UILabel = root.FindScript<UILabel>("BtnAnchor/btngroup/Composite/CompositeLabel");

    }
    #endregion

    #region Event
    protected override void InitReactiveEvents(){
            TransBtn_UIButtonEvt = TransBtn_UIButton.AsObservable();
    CloseBtn_UIButtonEvt = CloseBtn_UIButton.AsObservable();
    TransAllBtn_UIButtonEvt = TransAllBtn_UIButton.AsObservable();
    ArrangeBtn_UIButtonEvt = ArrangeBtn_UIButton.AsObservable();
    DecomposeBtn_UIButtonEvt = DecomposeBtn_UIButton.AsObservable();
    Composite_UIButtonEvt = Composite_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
                TransBtn_UIButtonEvt = TransBtn_UIButtonEvt.CloseOnceNull();
        CloseBtn_UIButtonEvt = CloseBtn_UIButtonEvt.CloseOnceNull();
        TransAllBtn_UIButtonEvt = TransAllBtn_UIButtonEvt.CloseOnceNull();
        ArrangeBtn_UIButtonEvt = ArrangeBtn_UIButtonEvt.CloseOnceNull();
        DecomposeBtn_UIButtonEvt = DecomposeBtn_UIButtonEvt.CloseOnceNull();
        Composite_UIButtonEvt = Composite_UIButtonEvt.CloseOnceNull();

    }

        private Subject<Unit> TransBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnTransBtn_UIButtonClick{
        get {return TransBtn_UIButtonEvt;}
    }

    private Subject<Unit> CloseBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnCloseBtn_UIButtonClick{
        get {return CloseBtn_UIButtonEvt;}
    }

    private Subject<Unit> TransAllBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnTransAllBtn_UIButtonClick{
        get {return TransAllBtn_UIButtonEvt;}
    }

    private Subject<Unit> ArrangeBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnArrangeBtn_UIButtonClick{
        get {return ArrangeBtn_UIButtonEvt;}
    }

    private Subject<Unit> DecomposeBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnDecomposeBtn_UIButtonClick{
        get {return DecomposeBtn_UIButtonEvt;}
    }

    private Subject<Unit> Composite_UIButtonEvt;
    public UniRx.IObservable<Unit> OnComposite_UIButtonClick{
        get {return Composite_UIButtonEvt;}
    }


    
    
    #endregion
}