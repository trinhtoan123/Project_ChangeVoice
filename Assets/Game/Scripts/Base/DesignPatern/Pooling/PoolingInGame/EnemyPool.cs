using Base.DesignPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : GenericObjectPool<ObjPoolController>
{
    public ObjPoolController GetEnemyPrefab(ObjPoolController enemyPrefab)
    {
        PrefabPool(enemyPrefab);
        ObjPoolController enemy = GetPrefabInstance();
        if (enemy)
        {
            enemy.transform.SetParent(transform);
            enemy.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        return enemy;
    }
}
