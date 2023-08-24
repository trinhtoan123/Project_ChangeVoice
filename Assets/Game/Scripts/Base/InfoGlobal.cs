using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Common
{
    [System.Serializable]
    public class AnimCommand
    {
        public const string Idle = "idle";
        public const string Shoot = "shoot";
        public const string AmmoOut = "ammoout";
        public const string Reload = "reload";
    }
    [System.Serializable]
    public class SpineInfo
    {
        public string path;
        public string skinName;
        //public SkeletonDataAsset dataAsset;
    }
}