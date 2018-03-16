﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameCore_UtilLogWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("UtilLog");
		L.RegFunction("Init", Init);
		L.RegFunction("Exit", Exit);
		L.RegFunction("Log", Log);
		L.RegFunction("LogError", LogError);
		L.RegFunction("LogWarning", LogWarning);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GameCore.UtilLog.Init();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GameCore.UtilLog.Exit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				GameCore.UtilLog.Log(arg0);
				return 0;
			}
			else if (TypeChecker.CheckTypes<string>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				GameCore.UtilLog.Log(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GameCore.UtilLog.Log");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				GameCore.UtilLog.LogError(arg0);
				return 0;
			}
			else if (TypeChecker.CheckTypes<string>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				GameCore.UtilLog.LogError(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GameCore.UtilLog.LogError");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				GameCore.UtilLog.LogWarning(arg0);
				return 0;
			}
			else if (TypeChecker.CheckTypes<string>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				GameCore.UtilLog.LogWarning(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GameCore.UtilLog.LogWarning");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
