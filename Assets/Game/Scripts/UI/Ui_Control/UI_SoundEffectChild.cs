using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TQT.UI;

public class UI_SoundEffectChild : MonoBehaviour
{
    MenuControl menuControl;
    public void Init()
    {
        menuControl = GetComponent<MenuControl>();
    }
    public void Show()
    {
        menuControl.PlayShow();
    }
    public void Hide()
    {
        menuControl.PlayHide();
    }
}
