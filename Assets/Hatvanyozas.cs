using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatvanyozas : MonoBehaviour

{
    [SerializeField, Min(1)] int baseNumber = 1;
    [SerializeField, Min(1)] int exponent = 1;
    [SerializeField] int vegeredmeny;

    // Start is called before the first frame update
    void OnValidate()
    {
        vegeredmeny = 1;

        for (int i = 0; i < exponent; i++)
        {
            vegeredmeny = baseNumber * vegeredmeny;
        }
        //vegeredmeny = (baseNumber * baseNumber) * exponent;
    }

}
