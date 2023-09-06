using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TQT.UI;

public class UI_Home : MonoBehaviour
{
    MenuControl menuControl;
    UI_SoundEffect ui_SoundEffect;
    public void Init(UI_SoundEffect ui_SoundEffect)
    {
        menuControl = GetComponent<MenuControl>();
        this.ui_SoundEffect = ui_SoundEffect;
    }
    public void Show()
    {
        menuControl.PlayShow();
    }
    public void Hide()
    {
        menuControl.PlayHide();
    }
    public void Onclick_SoundEffect()
    {
        ui_SoundEffect.Show();
        Hide();
    }
   
}
