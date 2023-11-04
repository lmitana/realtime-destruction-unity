using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour
{
    public float delay = 1;

    void OnEnable()
    {
        Destroy(gameObject, delay);
    }
}
