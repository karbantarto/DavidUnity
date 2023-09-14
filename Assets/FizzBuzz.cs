using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FizzBuzz : MonoBehaviour
{
    [SerializeField, Min(1)] int number = 1;


    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 1; i <= number; i++) 
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 5 == 0) 
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else
            {
                Debug.Log(i);
            }
        }

    }

}
