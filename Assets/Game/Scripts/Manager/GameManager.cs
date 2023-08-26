using Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    Dictionary<string, MainSoundInfo> soundInfoDict;
    Dictionary<string, List<MainSoundInfo>> dataType = new Dictionary<string, List<MainSoundInfo>>();
    List<string> typeItem = new List<string>();
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        GameStart();
    }
    public void GameStart()
    {
        soundInfoDict = DataVO.Instance.SoundInfo.GetRecordSoundInfo();
    }
    public void GameEnd()
    {

    }
    public void AddToListType(string type, MainSoundInfo mainSound)
    {
        if (!typeItem.Contains(type))
            typeItem.Add(type);

        if (!dataType.ContainsKey(type))
        {
            List<MainSoundInfo> list = new List<MainSoundInfo>();
            dataType.Add(type, list);
            dataType[type].Add(mainSound);
        }
        else
        {
            dataType[type].Add(mainSound);
        }

    }
    public int CountItemEffect()
    {
        return dataType.Count;
    }
    public int CountItemChild(int index)
    {
        return dataType[typeItem[index]].Count;
    }
    public MainSoundInfo SoundInfoDict(int index)
    {
        return dataType[typeItem[index]][index];
    }
}
   
