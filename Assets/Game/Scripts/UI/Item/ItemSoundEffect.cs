using Common;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ItemSoundEffect : MonoBehaviour
{
    public Image imgIcon;
    public TMP_Text text;
    public Button button;
    public int id;
    SoundEffect soundEffect;
    public void OnInit(MainSoundInfo mainSoundInfo,int id,SoundEffect soundEffect)
    {
        this.id = id;
        this.soundEffect = soundEffect;
        //imgIcon.sprite = mainSoundInfo.soundImgs;
        text.text = mainSoundInfo.soundName;

    }
    public void OnClick_SelectButton()
    {
        Observer.Instance.Notify("Button_Sound", id);
    }
}
