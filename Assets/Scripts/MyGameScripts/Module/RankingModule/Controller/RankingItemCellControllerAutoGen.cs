﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  RankingItemCellController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IRankingItemCellController
{
     UniRx.IObservable<Unit> OnRankingItemCell_UIButtonClick{get;}

}

public partial class RankingItemCellController:MonolessViewController<RankingItemCell>, IRankingItemCellController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        RankingItemCell_UIButtonEvt = View.RankingItemCell_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        RankingItemCell_UIButtonEvt = RankingItemCell_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> RankingItemCell_UIButtonEvt;
    public UniRx.IObservable<Unit> OnRankingItemCell_UIButtonClick{
        get {return RankingItemCell_UIButtonEvt;}
    }


}