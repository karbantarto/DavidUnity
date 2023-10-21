using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Arrays : MonoBehaviour
{



    
    void Start()
    {
        int[] myFirstArray = new int[10];
        string[] myFirstStringArray = { "Alma", "Banan", "Citrom" };

        int element3 = myFirstArray[3];
        string element1 = myFirstStringArray[1];

        myFirstArray[3] = 123;

        for(int i = 0; i < myFirstArray.Length; i++)
        {
            myFirstArray[i] = i + 1;
        }

        //char myChar = 'x';          //' '

        string myString = "Bear";   //" "
        char[] myCharArray = myString.ToCharArray();

        myCharArray[2] = 'e';

        string myNewString = new string(myCharArray);
        Debug.Log(myNewString); // "Beer"






    }


    float GetProduct(float[] array) 
    {
        float product = 1;

        for (int i = 0; i < array.Length; i++) 
        {
            product *= array[i];
           
        }
        return product;
    }

    int[] MyMethod(int length, int power) 
    {
        int[] array = new int[length];

        for(int i = 0; i < array.Length; i++)
        {
            int n = i + 1;
            array[i] = i * i;
        }
        return array;
    }


    float MyMethod2(float[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        float value = array[0];

        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > value)
            {
                value = array[i];
            }
        }
        return value;
    }
    
    string[] ReveseString(string[] array)
    {
        string[] newStringArray = new string[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            newStringArray[i] = array[array.Length - 1 - i];
        
        }

        return newStringArray;
    }

    void Reverse(string[] array)
    {

    }
}
