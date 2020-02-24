﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_MaterialManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.MaterialManager), typeof(System.Object));
		L.RegFunction("GetMaterial", GetMaterial);
		L.RegFunction("DestroyMaterials", DestroyMaterials);
		L.RegFunction("RefreshMaterials", RefreshMaterials);
		L.RegFunction("Release", Release);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMaterial(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			FairyGUI.MaterialManager obj = (FairyGUI.MaterialManager)ToLua.CheckObject<FairyGUI.MaterialManager>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.BlendMode arg1 = (FairyGUI.BlendMode)LuaDLL.luaL_checknumber(L, 3);
			uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 4);
			bool arg3;
			FairyGUI.NMaterial o = obj.GetMaterial(arg0, arg1, arg2, out arg3);
			ToLua.PushObject(L, o);
			LuaDLL.lua_pushboolean(L, arg3);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyMaterials(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.MaterialManager obj = (FairyGUI.MaterialManager)ToLua.CheckObject<FairyGUI.MaterialManager>(L, 1);
			obj.DestroyMaterials();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshMaterials(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.MaterialManager obj = (FairyGUI.MaterialManager)ToLua.CheckObject<FairyGUI.MaterialManager>(L, 1);
			obj.RefreshMaterials();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Release(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.MaterialManager obj = (FairyGUI.MaterialManager)ToLua.CheckObject<FairyGUI.MaterialManager>(L, 1);
			obj.Release();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
