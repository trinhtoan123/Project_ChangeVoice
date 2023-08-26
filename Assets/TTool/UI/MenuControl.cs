using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

namespace TQT.UI
{
    public class MenuControl : MonoBehaviour
    {
        public List<ItemActive> _item = new List<ItemActive>();
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void GetItem()
        {
            _item.Add(GetComponentInChildren<ItemActive>());
        }
        //public void OnDrawGizmosSelected()
        //{
        //    GetItem();
        //}
        public void Show()
        {
            for (int i = 0; i < _item.Count; i++)
            {
                _item[i].gameObject.SetActive(true);
            }
        }
        public void Hide()
        {
            for (int i = 0; i < _item.Count; i++)
            {
                _item[i].gameObject.SetActive(false);
            }
        }
    }

}
