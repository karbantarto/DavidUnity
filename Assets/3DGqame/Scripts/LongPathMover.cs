using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



[ExecuteAlways]
public class LongPathMover : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Transform movedObject;

    List<Transform> path = new List<Transform>();
    Transform nextTarget;
    bool positiveDirection = true;

    private void Start()
    {
        FindPoints();
        movedObject.position = path[0].position;
        nextTarget = path[1];
    }


    private void Update()
    {
        FindPoints();

        if (Application.isPlaying)
        {
            Move();
        }



    }

    private void FindPoints()
    {
        path.Clear();

        for (int i = 0; i < transform.childCount; i++)
        {
            path.Add(transform.GetChild(i));
        }
    }

    private void Move()
    {
        movedObject.position = Vector3.MoveTowards(movedObject.position, nextTarget.position, speed * Time.deltaTime);

        if (nextTarget.position == movedObject.position)
        {
            int currentIndex = path.IndexOf(nextTarget);

            if (positiveDirection)
            {
                if (currentIndex == path.Count - 1)
                {
                    positiveDirection = false;
                }
            }
            else
            {
                if (currentIndex == 0)
                    positiveDirection = true;
            }

            int nextIndex = currentIndex + (positiveDirection ? 1 : -1);
            nextTarget = path[nextIndex];


        }
    }



    void OnDrawGizmos()
    {
        for (int i = 0; i < path.Count - 1; i++)
        {
            Vector3 p1 = path[i].position;
            Vector3 p2 = path[i + 1].position;

            Gizmos.DrawLine(p1, p2);
        }
    }
}
