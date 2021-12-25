using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemPlayerCultivation : SystemA
{
    private SystemPlayerCultivation() { }
    private static SystemPlayerCultivation _SystemInstance = null;
    float m_timer = 0;
    int times = 0;
    public override void update()
    {

        //if (m_timer >= 1)
        //{
        //    Debug.Log("m_timer:" + m_timer + "/n times:" + times);
        //    m_timer = 0;
        //    times += 1;
        //}
        //m_timer += Time.deltaTime;
    }

    public static SystemA getInstance()
    {
        if (_SystemInstance == null)
        {
            _SystemInstance = new SystemPlayerCultivation();
        }
        return _SystemInstance;
    }

}
