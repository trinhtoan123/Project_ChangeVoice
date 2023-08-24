using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItemInList : MonoBehaviour
{
    #region Properties
    #endregion

    #region UnityFunctions
        void Awake()
        {

        }


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    #endregion

    #region Methods
    public static void Move<T>(List<T> list, int oldIndex, int newIndex)
    {
        List<T> tempList = new List<T>(list);
        T item = list[oldIndex];
        tempList.RemoveAt(oldIndex);
        list.Clear();
        int j = 0;
        for (int i = 0; i < tempList.Count + 1; i++)
        {
            list.Add(i == newIndex ? item : tempList[j]);
            j += i == newIndex ? 0 : 1;
        }
    }
    #endregion
}