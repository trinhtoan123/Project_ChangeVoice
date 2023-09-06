using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundChild : MonoBehaviour
{
    [SerializeField] Transform posConten;
    [SerializeField] ItemSoundChild item;
    List<ItemSoundChild> _itemList = new List<ItemSoundChild>();

    // Start is called before the first frame update
    void Start()
    {
        Observer.Instance.AddObserver("Button_Sound", GameStart);
    }
    private void OnEnable()
    {
    }
    private void GameStart(object data)
    {
        SpawnItem_SoundEffect((int)data);
    }

    void SpawnItem_SoundEffect(int index)
    {
        int count = GameManager.Instance.CountItemChild(index);
        for (int i = 0; i < count; i++)
        {
            ItemSoundChild tmpCurrrentItem = null;
            if (i < _itemList.Count)
                tmpCurrrentItem = _itemList[i];
            if (tmpCurrrentItem == null)
            {
                tmpCurrrentItem = Instantiate(item, posConten);
                _itemList.Add(tmpCurrrentItem);
                tmpCurrrentItem.OnInit(GameManager.Instance.SoundInfoDict(i),i);
            }
        }
    }
}
