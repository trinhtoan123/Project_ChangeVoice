using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataVO:Singleton<DataVO>
{
    SoundVO soundInfo;

    public SoundVO SoundInfo
    {
        get
        {
            if (soundInfo == null)
            {
                soundInfo = new SoundVO();
            }
            return soundInfo;
        }
    }
}
