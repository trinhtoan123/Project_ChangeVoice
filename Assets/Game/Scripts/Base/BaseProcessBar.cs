using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProcessBar : MonoBehaviour
{
    public virtual void SetMaxValue(float max_value)
    {
    }

    public virtual void SetProcessBarValue(float value)
    {
    }

    protected virtual void SetTxHp(int hp)
    {
    }

    protected virtual void SetTxMaxHp(int hp)
    {
    }

    public virtual void SetMaxValue(double max_value)
    {
    }

    public virtual void SetProcessBarValue(double value)
    {
    }
}
