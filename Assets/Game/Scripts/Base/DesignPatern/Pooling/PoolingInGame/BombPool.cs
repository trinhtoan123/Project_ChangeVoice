using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base.DesignPattern;
public class BombPool : GenericObjectPool<ObjPoolController>
{
    public ObjPoolController GetBombPrefab(ObjPoolController bombPrefab)
    {
        PrefabPool(bombPrefab);
        ObjPoolController bombObj = GetPrefabInstance();
        if (bombObj)
        {
            bombObj.transform.rotation = Quaternion.Euler(0, 0, 0);
            bombObj.transform.position = this.transform.position;
        }
        return bombObj;
    }
}