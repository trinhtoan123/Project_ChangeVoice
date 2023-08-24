using Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemBase : MonoBehaviour
{
    public Image imgIcon;
    public TMP_Text text;
    public Button button;
    public virtual void OnInit(MainSoundInfo mainSoundInfo)
    {
        //imgIcon.sprite = mainSoundInfo.soundImgs;
        text.text = mainSoundInfo.soundName;
    }
}
