using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        int collectedValue = 0;

        if (other.TryGetComponent(out Collectable collectable))
        {
            collectedValue += collectable.GetValue();
            collectable.Teleport();
        }
    }



}
