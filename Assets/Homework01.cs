using UnityEngine;

class Homework01 : MonoBehaviour
{
    [SerializeField] int pa;
    [SerializeField] int pb;
    [SerializeField] int pc;
    [SerializeField] bool isPythagorean;

    void OnValidate()
    {
        isPythagorean = pa * pa + pb * pb == pc * pc;
    }

}
