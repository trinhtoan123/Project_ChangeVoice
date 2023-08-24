using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] Transform posConten;
    [SerializeField] ItemSoundEffect item;
    [SerializeField] List<ItemSoundEffect> _itemList = new List<ItemSoundEffect>();
    void Start()
    {
        
    }
    private void OnEnable()
    {
        SpawnItem_SoundEffect();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnItem_SoundEffect()
    {
        int count = GameManager.Instance.SoundTypeList.Count;
       
        for (int i = 0; i < count; i++)
        {
            //ItemSoundEffect tmpCurrrentItem = Instantiate(item, posConten);
            //_itemList.Add(tmpCurrrentItem);
            //Debug.LogError("Item " + GameManager.Instance.SoundInfoDict(i).soundName);
            //tmpCurrrentItem.OnInit(GameManager.Instance.SoundInfoDict(i));
            //ItemSoundEffect tmpCurrrentItem = null;
            //if (i < _itemList.Count)
            //    tmpCurrrentItem = _itemList[i];
            //if (tmpCurrrentItem == null)
            //{
               
            //}
        }
    }
}
