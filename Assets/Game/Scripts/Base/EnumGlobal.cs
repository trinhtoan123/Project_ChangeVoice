using UnityEngine;

namespace Common
{
    public enum SoundState
    {
        Idle,
        Play
    }
    public enum GamePhase
    {
        None,
        Play,
        Pause
    }
    public enum GameMode
    {
        Single,
        Hold,
        Shake
    }
    [System.Serializable]
    public struct SoundInfo
    {
        public string soundId;
        public string soundType;
        public string soundName;
        public string soundImg;
        public string soundClip;
        public string folderType;
    }
    [System.Serializable]
    public class MainSoundInfo
    {
        public string soundId;
        public string soundName;
        public string soundType;
        [HideInInspector]
        public string folderType;
        public Sprite soundImgs;
        public AudioClip soundClip ;
    }
    [System.Serializable]
    public class SoundEffect
    {
        public string soundName;
        public Sprite soundImgs;
    }

}