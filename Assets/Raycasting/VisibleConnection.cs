using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleConnection : MonoBehaviour
{
    [SerializeField] Transform other;
    [SerializeField] LineRenderer line;


    private void Update()
    {
        Vector3 p1 = transform.position;
        Vector3 p2 = other.position;

        Vector3[] points = { p1, p2 };

        line.SetPositions(points);
        line.positionCount = 2;
    }


}
