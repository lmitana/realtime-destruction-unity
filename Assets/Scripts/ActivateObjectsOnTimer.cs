using UnityEngine;
using System.Collections;

public class ActivateObjectsOnTimer : MonoBehaviour
{
    public float activationDelay = 1;
    public bool startInactive;
    public bool repeat;
    public GameObject[] objectsToActivate;

    void OnEnable()
    {
        if (startInactive)
        {
            foreach (GameObject g in objectsToActivate)
            {
                if (g != null) g.SetActive(false);
            }
        }

        Invoke("Activate", activationDelay);
    }

    void Activate()
    {
        foreach (GameObject g in objectsToActivate)
        {
            if (g != null) g.SetActive(true);
        }

        if (repeat) Invoke("Activate", activationDelay);
    }
}
