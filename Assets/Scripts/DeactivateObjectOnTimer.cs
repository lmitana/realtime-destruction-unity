using UnityEngine;
using System.Collections;

public class DeactivateObjectOnTimer : MonoBehaviour
{
    public float deactivationDelay = 1;
    [Tooltip("Obect to deacivate. Leave empty to deactivate this object.")]
    public GameObject objectToDeactivate;

    void OnEnable()
    {
        if (objectToDeactivate == null) objectToDeactivate = gameObject;

        Invoke("Activate", deactivationDelay);
    }

    void Activate()
    {
        objectToDeactivate.SetActive(false);
    }

}
