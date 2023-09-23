using UnityEngine;

class MyMath : MonoBehaviour
{
   
    float Min(float a, float b)
    {
        float result;   //elhagyhato
        
        if (a < b)
        {
            result = a; //return a;
        }
        else
        {
            result = b; //return b;
        }

        return result;  //elhagyhato
           
        //return a < b ? a : b;

    }

}
