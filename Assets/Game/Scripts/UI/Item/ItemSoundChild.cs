using Common;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSoundChild : MonoBehaviour
{
    public Image imgIcon;
    public TMP_Text text;
    public Button button;
    public int id;
    public void OnInit(MainSoundInfo mainSoundInfo, int id)
    {
        this.id = id;
        //imgIcon.sprite = mainSoundInfo.soundImgs;
        text.text = mainSoundInfo.soundName;

    }
    public void OnClick_SelectButton()
    {
    }
}
