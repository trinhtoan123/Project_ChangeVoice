using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base.DesignPattern;

public class ChainsawPool : GenericObjectPool<ObjPoolController>
{
    public ObjPoolController GetChainsawPrefab(ObjPoolController chainsawPrefab)
    {
        PrefabPool(chainsawPrefab);
        ObjPoolController chainsaw = GetPrefabInstance();
        if (chainsaw)
        {
            chainsaw.transform.SetParent(transform);
            chainsaw.transform.rotation = Quaternion.Euler(0, 0, 0);
            chainsaw.transform.localScale = new Vector3(5f,5f,1);
        }
        return chainsaw;
    }
}
