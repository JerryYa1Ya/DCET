﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_LazyBsonArraySerializerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.LazyBsonArraySerializer), typeof(MongoDB.Bson.Serialization.Serializers.BsonValueSerializerBase<MongoDB.Bson.LazyBsonArray>));
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Serializers_LazyBsonArraySerializer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Serializers_LazyBsonArraySerializer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Serializers.LazyBsonArraySerializer obj = new MongoDB.Bson.Serialization.Serializers.LazyBsonArraySerializer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Serializers.LazyBsonArraySerializer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
