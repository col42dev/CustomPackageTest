using System;
using UnityEditor;
using UnityEngine;

namespace MFG.PackageTest
{
    public static class Logger
    {
        [MenuItem("PackageTest/LogTest")]
        public static void HelloWorld()
        {
            UnityEngine.Debug.Log("HelloWorld");
        }
    }
}