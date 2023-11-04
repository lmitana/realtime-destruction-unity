using UnityEngine;
using System.Collections;

public class LightLerp : MonoBehaviour {

    public float speed = 1;
    public float targetIntensity = 0;

    Light l;

    void Awake()
    {
        l = GetComponent<Light>();

        if (l == null) enabled = false;
    }

    void Update()
    {
        l.intensity = Mathf.Lerp(l.intensity, targetIntensity, Time.deltaTime * speed);

        if (l.intensity == targetIntensity) enabled = false;
    }

}
