using UnityEngine;
using System.Collections;

public class RadialRigibodyActivation : MonoBehaviour
{
    public LayerMask activationLayer;
    public float radius = 5;
    public float speed = 10;
    public bool visualize;

    void OnEnable()
    {
        var colliders = Physics.OverlapSphere(transform.position, radius, activationLayer.value);

        foreach (Collider c in colliders)
        {
            var rb = c.gameObject.GetComponent<Rigidbody>();
            var distance = Vector3.Distance(transform.position, c.gameObject.transform.position);
            StartCoroutine(ActivateRigidbody(rb, distance * 1 / speed));
        }
    }

    IEnumerator ActivateRigidbody(Rigidbody rb, float delay)
    {
        yield return new WaitForSeconds(delay);
        if (rb != null)
        {
            rb.isKinematic = false;

            if (visualize) rb.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
