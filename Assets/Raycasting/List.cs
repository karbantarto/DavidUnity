using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Vector3> myFirstList = new List<Vector3>();

        myFirstList.Add(new Vector3(1, 2, 3));
        myFirstList.Add(transform.position);
        myFirstList.Add(Vector3.up);

        Vector3 element = myFirstList[1];

        for (int i = 0; i < myFirstList.Count; i++)
        {
            Vector3 item = myFirstList[i];
            Debug.Log(item);
        }

        foreach (Vector3 item in myFirstList)
        {
            Debug.Log(item);
        }
    }

 
    void Update()
    {
        
    }
}
