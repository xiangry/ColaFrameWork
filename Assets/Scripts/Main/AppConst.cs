﻿//----------------------------------------------
//            ColaFramework
// Copyright © 2018-2049 ColaFramework 马三小伙儿
//----------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColaFramework
{
    public class AppConst
    {
        public const bool DebugMode = false;                       //调试模式-用于内部测试

        /// <summary>
        /// 如果开启更新模式，前提必须启动框架自带服务器端。
        /// 否则就需要自己将StreamingAssets里面的所有内容
        /// 复制到自己的Webserver上面，并修改下面的WebUrl。
        /// </summary>
        public const bool UpdateMode = false;                       //更新模式-默认关闭 
        public const bool LuaByteMode = false;                       //Lua字节码模式-默认关闭 
        public const bool LuaBundleMode = false;                    //Lua代码AssetBundle模式

        public const int GameFrameRate = 30;                        //游戏帧频

        public const string AppName = "ColaFramework";               //应用程序名称
        public const string LuaTempDir = "Lua/";                    //临时目录
        public const string AppPrefix = AppName + "_";              //应用程序前缀
        public const string ExtName = ".cab";                   //AssetBundle的扩展名
        public const string AssetDir = "StreamingAssets";           
        public const string WebUrl = "http://localhost:6688/";      //测试更新地址

        /// <summary>
        /// StreamingAsset下的预装资源目录
        /// </summary>
        public static List<string> resbasePathList = new List<string>(){
        "config",
        "res_base",
        "Lua",
        };
    }
}

