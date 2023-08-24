using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProcessBarComponent : BaseProcessBar
{
    [SerializeField]
    Transform tfHp;
    [SerializeField]
    Text txHp;

    private SpriteRenderer spriteRenderer;
    private float maxValue = -1;
    [SerializeField]
    private bool scaleY = false;

    private void Awake()
    {
        if (tfHp == null)
        {
            tfHp = transform;
        }
        spriteRenderer = tfHp.GetComponent<SpriteRenderer>();
    }

    public override void SetMaxValue(float max_value)
    {
        maxValue = max_value;
        SetTxHp((int)max_value);
    }

    public override void SetProcessBarValue(float value)
    {
        if (maxValue <= 0) return;
        SetValue(value);
    }

    private void SetValue(float value)
    {
        SetTxHp((int)value);
        float scale = value / maxValue;
        if (scale > 1.0f)
            scale = 1.0f;
        if (scale < 0.0f)
            scale = 0.0f;
        Vector3 vtScale = scaleY ? new Vector3(transform.localScale.x, scale, 1) : new Vector3(scale, transform.localScale.y, 1);
        tfHp.localScale = vtScale;
    }

    protected override void SetTxHp(int hp)
    {
        if (txHp != null)
            txHp.text = hp.ToString();
    }
}
