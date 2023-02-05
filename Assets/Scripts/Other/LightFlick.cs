using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlick : MonoBehaviour
{
    public Light light;

    public float minTime;
    public float maxTime;
    public float Timer;

    private void Start()
    {
        Timer = Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        flickerLight();
    }

    void flickerLight()
    {
        if (Timer> 0 )
        {
            Timer -= Time.deltaTime;
        }
        if (Timer<=0)
        {
            light.enabled = !light.enabled;
            Timer = Random.Range(minTime, maxTime);
        }
    }
}
