using Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundVO : BaseMutilVO
{
    public SoundVO()
    {
        LoadDataByDirectories<BaseVO>("SoundInfo");
    }
    public Dictionary<string, MainSoundInfo> GetRecordSoundInfo()
    {
        Dictionary<string, MainSoundInfo> info = DataVO.Instance.SoundInfo.GetDictDataByName("data_sounds_info");
        return info;
    }

    public Dictionary<string, MainSoundInfo> GetDictDataByName(string file_name)
    {
        Dictionary<string, MainSoundInfo> dictData = new Dictionary<string, MainSoundInfo>();
        if (dic_Data.ContainsKey(file_name))
        {
            SoundInfo[] lstSubInfo = dic_Data[file_name].GetDatas<SoundInfo>();
            for (int i = 0; i < lstSubInfo.Length; i++)
            {
                string dictKey = lstSubInfo[i].soundId;
                MainSoundInfo soundInfo = new MainSoundInfo();
                soundInfo.soundId = dictKey;
                soundInfo.soundName = lstSubInfo[i].soundName;
                soundInfo.soundType = lstSubInfo[i].soundType;
                soundInfo.folderType = lstSubInfo[i].folderType;
                soundInfo.soundImgs = GetSpriteFromResources(lstSubInfo[i].soundImg);
                soundInfo.soundClip = GetAudioClipFromResources(lstSubInfo[i].folderType, lstSubInfo[i].soundClip);
                dictData[dictKey] = soundInfo;

                GameManager.Instance.AddToListType(soundInfo.soundType, soundInfo);
            }
        }

        return dictData;
    }

    Sprite GetSpriteFromResources(string spriteName)
    {
        Sprite spriteSound = null;
        spriteSound = Resources.Load<Sprite>("Sprites" + "/" + spriteName);
        return spriteSound;
    }

    public static AudioClip GetAudioClipFromResources(string typeName, string audioClipName)
    {
        AudioClip audioClipSound = null;
        audioClipSound = Resources.Load<AudioClip>("AudioClips" + "/" + typeName + "/" + audioClipName);
        return audioClipSound;
    }
}
