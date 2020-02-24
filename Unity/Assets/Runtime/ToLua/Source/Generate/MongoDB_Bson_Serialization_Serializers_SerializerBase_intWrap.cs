﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_SerializerBase_intWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.SerializerBase<int>), typeof(System.Object), "SerializerBase_int");
		L.RegFunction("Deserialize", Deserialize);
		L.RegFunction("Serialize", Serialize);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("ValueType", get_ValueType, null);
		L.RegFunction("getValueType", get_ValueType);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Deserialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			MongoDB.Bson.Serialization.Serializers.SerializerBase<int> obj = (MongoDB.Bson.Serialization.Serializers.SerializerBase<int>)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.SerializerBase<int>>(L, 1);
			MongoDB.Bson.Serialization.BsonDeserializationContext arg0 = (MongoDB.Bson.Serialization.BsonDeserializationContext)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonDeserializationContext>(L, 2);
			MongoDB.Bson.Serialization.BsonDeserializationArgs arg1 = StackTraits<MongoDB.Bson.Serialization.BsonDeserializationArgs>.Check(L, 3);
			int o = obj.Deserialize(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Serialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			MongoDB.Bson.Serialization.Serializers.SerializerBase<int> obj = (MongoDB.Bson.Serialization.Serializers.SerializerBase<int>)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.SerializerBase<int>>(L, 1);
			MongoDB.Bson.Serialization.BsonSerializationContext arg0 = (MongoDB.Bson.Serialization.BsonSerializationContext)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonSerializationContext>(L, 2);
			MongoDB.Bson.Serialization.BsonSerializationArgs arg1 = StackTraits<MongoDB.Bson.Serialization.BsonSerializationArgs>.Check(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			obj.Serialize(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ValueType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Serializers.SerializerBase<int> obj = (MongoDB.Bson.Serialization.Serializers.SerializerBase<int>)o;
			System.Type ret = obj.ValueType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ValueType on a nil value");
		}
	}
}
