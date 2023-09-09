using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LoopPractise : MonoBehaviour
{
    
    void Start()
    {

       // Debug.Log(1);
       // Debug.Log(2);
       // Debug.Log(3);

        //int i = 3;
        int found = 0;

        for (int i = 1; found < 100; i++)
        {
        
            if (i % 3 == 0 || i % 7 == 0)

            {
                Debug.Log(i);
                found++;
            }
            
           // i++;
            
           
        }
    }
}
