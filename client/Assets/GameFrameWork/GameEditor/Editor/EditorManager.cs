﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace GF
{
    //编辑器代码不能直接调用运行时的模块
    public static class EditorManager
    {
        [MenuItem("工具/导出资源/脚本")]
        public static void 导出脚本()
        {
            ExportLua.Export();
        }
    }
}