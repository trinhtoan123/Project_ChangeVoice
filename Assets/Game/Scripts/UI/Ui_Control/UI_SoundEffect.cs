using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TQT.UI;

public class UI_SoundEffect : MonoBehaviour
{
    [SerializeField] SoundEffect soundEffect;
    MenuControl menuControl;

    public void Init()
    {
        menuControl = GetComponent<MenuControl>();
    } 
    public void Show()
    {
        menuControl.PlayShow();
        soundEffect.GameStart();
    }
    public void Hide()
    {
        menuControl.PlayHide();
    }
}
