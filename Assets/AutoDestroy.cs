using System.Collections;
using UnityEngine;

class AutoDestroy : MonoBehaviour
{
    [SerializeField] float lifeTime = 5;
    [SerializeField] float maxDistance = 10;
    [SerializeField] bool destroyOnCollision;


    Vector3 startPosition;

    private void Start()
    {


        StartCoroutine(MyCoroutine());
        startPosition = transform.position;


    }



    IEnumerator MyCoroutine()
    {
        Debug.Log("AAA");

        yield return new WaitForSeconds(lifeTime);

        Debug.Log("BBB");
        Destroy(gameObject);
    }

    private void Update()
    {
        Vector3 cp = transform.position;
        bool isOutOfRange = Vector3.Distance(cp, startPosition) > maxDistance;
        if (isOutOfRange)
        {
            Destroy(gameObject);
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (destroyOnCollision)
        {
            Destroy(gameObject);
        }
    }
}