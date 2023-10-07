using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetOffset;
    [SerializeField] Vector3 globalOffset;
    [SerializeField] float angularSpeed;


    void Update()
    {
        Vector3 targetPoint = GetTargetPoint();

        Vector3 dir = targetPoint - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(dir);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);


        // transform.LookAt(targetPoint);



    }

    Vector3 GetTargetPoint()
    {
        Vector3 targetPoint = target.position;
        targetPoint += globalOffset;
        targetPoint += target.TransformVector(targetOffset);
        return targetPoint;
    }

    void OnDrawGizmos()
    {
        Vector3 targetPoint = GetTargetPoint();
    }
}
