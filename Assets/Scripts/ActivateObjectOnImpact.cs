using UnityEngine;
using System.Collections;

public class ActivateObjectOnImpact : MonoBehaviour // ActivateObjectOnCollision
{
    public float activationForce = 20;
    public GameObject objectToActivate;

    void OnCollisionEnter(Collision c)
    {
        if (activationForce < c.relativeVelocity.sqrMagnitude)
        {
            if (objectToActivate != null) objectToActivate.SetActive(true);
        }
    }

    void OnCollisionExit(Collision c)
    {
        if (activationForce < c.relativeVelocity.sqrMagnitude)
        {
            if (objectToActivate != null) objectToActivate.SetActive(true);
        }
    }
}
