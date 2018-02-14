﻿public class NormalActionInfo : BaseActionInfo
{
	public const string TYPE = "normal";

	public float startTime; //action start time
	public float delayTime;//action delayed time

	//攻击动作是否可变化
	public bool AnimationChangeable = false;
	//（多段攻击的）攻击动作列表
	public string AttackerActions ;
	//（多段攻击的）攻击方向列表
	public string AttackerDirections;
	/**（多段攻击的）攻击时长列表*/
	public string AttackerDurations;

	public override void FillInfo(JsonActionInfo json)
	{
		base.FillInfo(json);
		startTime = json.startTime;
		delayTime = json.delayTime;
		
		AnimationChangeable = json.AnimationChangeable;
		AttackerActions = json.AttackerActions;
		AttackerDirections = json.AttackerDirections;
		AttackerDurations = json.AttackerDurations;
	}
}
