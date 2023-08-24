using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base.DesignPattern;

public class SaberPool : GenericObjectPool<ObjPoolController>
{
    public ObjPoolController GetSaberPrefab(ObjPoolController saberPrefab)
    {
        PrefabPool(saberPrefab);
        ObjPoolController saberObj = GetPrefabInstance();
        if (saberObj)
        {
            saberObj.transform.rotation = Quaternion.Euler(0, 0, 0);
            saberObj.transform.position = this.transform.position;
        }
        return saberObj;
    }
}
