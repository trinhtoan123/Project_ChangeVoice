using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base.DesignPattern;
public class BombfirePool : GenericObjectPool<ObjPoolController>
{
    public ObjPoolController GetBombfirePrefab(ObjPoolController bombfirePrefab)
    {
        PrefabPool(bombfirePrefab);
        ObjPoolController bombfireObj = GetPrefabInstance();
        if (bombfireObj)
        {
            bombfireObj.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        return bombfireObj;
    }
}