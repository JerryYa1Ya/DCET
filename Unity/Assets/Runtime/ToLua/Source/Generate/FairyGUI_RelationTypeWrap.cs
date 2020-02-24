﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_RelationTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.RelationType));
		L.RegConstant("Left_Left", FairyGUI.RelationType.Left_Left);
		L.RegConstant("Left_Center", FairyGUI.RelationType.Left_Center);
		L.RegConstant("Left_Right", FairyGUI.RelationType.Left_Right);
		L.RegConstant("Center_Center", FairyGUI.RelationType.Center_Center);
		L.RegConstant("Right_Left", FairyGUI.RelationType.Right_Left);
		L.RegConstant("Right_Center", FairyGUI.RelationType.Right_Center);
		L.RegConstant("Right_Right", FairyGUI.RelationType.Right_Right);
		L.RegConstant("Top_Top", FairyGUI.RelationType.Top_Top);
		L.RegConstant("Top_Middle", FairyGUI.RelationType.Top_Middle);
		L.RegConstant("Top_Bottom", FairyGUI.RelationType.Top_Bottom);
		L.RegConstant("Middle_Middle", FairyGUI.RelationType.Middle_Middle);
		L.RegConstant("Bottom_Top", FairyGUI.RelationType.Bottom_Top);
		L.RegConstant("Bottom_Middle", FairyGUI.RelationType.Bottom_Middle);
		L.RegConstant("Bottom_Bottom", FairyGUI.RelationType.Bottom_Bottom);
		L.RegConstant("Width", FairyGUI.RelationType.Width);
		L.RegConstant("Height", FairyGUI.RelationType.Height);
		L.RegConstant("LeftExt_Left", FairyGUI.RelationType.LeftExt_Left);
		L.RegConstant("LeftExt_Right", FairyGUI.RelationType.LeftExt_Right);
		L.RegConstant("RightExt_Left", FairyGUI.RelationType.RightExt_Left);
		L.RegConstant("RightExt_Right", FairyGUI.RelationType.RightExt_Right);
		L.RegConstant("TopExt_Top", FairyGUI.RelationType.TopExt_Top);
		L.RegConstant("TopExt_Bottom", FairyGUI.RelationType.TopExt_Bottom);
		L.RegConstant("BottomExt_Top", FairyGUI.RelationType.BottomExt_Top);
		L.RegConstant("BottomExt_Bottom", FairyGUI.RelationType.BottomExt_Bottom);
		L.RegConstant("Size", FairyGUI.RelationType.Size);
		L.EndEnum();
		TypeTraits<FairyGUI.RelationType>.Check = CheckType;
		StackTraits<FairyGUI.RelationType>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.RelationType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.RelationType), L, pos);
	}
}
