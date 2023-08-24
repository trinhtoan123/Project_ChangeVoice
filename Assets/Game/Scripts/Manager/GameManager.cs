using Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Dictionary<string, MainSoundInfo> soundInfoDict;

    public List<string>_soundTypeList = new List<string>();
    public List<string> SoundTypeList => _soundTypeList;

    private void Awake()
    {
        Instance= this;
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
        if (!_soundTypeList.Contains(type))
            _soundTypeList.Add(type);
    }
    public MainSoundInfo SoundInfoDict(int index)
    {
        return soundInfoDict[_soundTypeList[index]];
    }
}
