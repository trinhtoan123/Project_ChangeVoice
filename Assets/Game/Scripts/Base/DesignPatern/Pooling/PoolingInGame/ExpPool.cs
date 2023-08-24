using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base.DesignPattern;

public class ExpPool : GenericObjectPool<ObjPoolController>
{
    public ObjPoolController GetExpPrefab(ObjPoolController expPrefab)
    {
        PrefabPool(expPrefab);
        ObjPoolController exp = GetPrefabInstance();
        if (exp)
        {
            exp.transform.SetParent(transform);
            exp.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        return exp;
    }
}