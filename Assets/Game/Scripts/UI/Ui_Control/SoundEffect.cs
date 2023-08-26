using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TQT.UI;
public class SoundEffect : MonoBehaviour
{
    [SerializeField] Transform posConten;
    [SerializeField] ItemSoundEffect item;
    List<ItemSoundEffect> _itemList = new List<ItemSoundEffect>();
    MenuControl menuControl;

    public void Init()
    {
        menuControl = GetComponent<MenuControl>();
    }
    public void GameStart()
    {
        SpawnItem_SoundEffect();
    }
    void SpawnItem_SoundEffect()
    {
        int count = GameManager.Instance.CountItemEffect();
        for (int i = 0; i < count; i++)
        {
            ItemSoundEffect tmpCurrrentItem = null;
            if (i < _itemList.Count)
                tmpCurrrentItem = _itemList[i];
            if (tmpCurrrentItem == null)
            {
                tmpCurrrentItem = Instantiate(item, posConten);
                _itemList.Add(tmpCurrrentItem);
                tmpCurrrentItem.OnInit(GameManager.Instance.SoundInfoDict(i),i,this);
            }
        }
    }
    public void OnClickButton()
    {
        
    }
}
