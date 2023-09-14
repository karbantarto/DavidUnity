using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtSzamAtlaga : MonoBehaviour
{
    [SerializeField, Min(1)] int num1 = 1;
    [SerializeField, Min(1)] int num2 = 1;
    [SerializeField, Min(1)] int num3 = 1;
    [SerializeField, Min(1)] int num4 = 1;
    [SerializeField, Min(1)] int num5 = 1;
    [SerializeField] float average;

    // Start is called before the first frame update
    void OnValidate()
    {
        average = (float)(num1 + num2 + num3 + num4 + num5) / 5;
    }
    
}
