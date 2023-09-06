using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] UI_SoundEffect ui_soundEffect; 
    [SerializeField] UI_SoundEffectChild ui_SoundEffectChild; 
    [SerializeField] UI_GamePlay ui_GamePlay; 
    [SerializeField] UI_Home ui_home; 

    public void Init()
    {
        Instance = this;
        ui_home.Init(ui_soundEffect);
        ui_SoundEffectChild.Init();
        ui_soundEffect.Init();
    }
    public void GameStart()
    {
        ui_home.Show();
    }
}
