using UnityEngine;
using System.Collections;

public class ActivateObjectOnImpact2 : MonoBehaviour
{
    public float activationForce = 20;
    public GameObject objectToActivate;

    bool go = true;
    float velocity;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null || objectToActivate == null) go = false;
    }

    void FixedUpdate()
    {
        if (go)
        {
            if (!rb.isKinematic)
            {
                if (!rb.IsSleeping())
                {
                    var v = Mathf.Abs(rb.velocity.sqrMagnitude);

                    if ((v - velocity) > activationForce) objectToActivate.SetActive(true);

                    velocity = v;
                }
            }
        }
    }
}
