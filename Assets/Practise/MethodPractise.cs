using UnityEngine;

class MethodPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void OnValidate()
    {

        float pow = Mathf.Pow(12, 3);
        float abs = Mathf.Abs(-12);
        float sign = Mathf.Sign(-34);
        float rounded = Mathf.Round(22.65f);    //23
        float floor = Mathf.Floor(34.999f);     //34
        float ceiled = Mathf.Ceil(34.003f);     //34


    }

    float MyAbs(float number)
    {
        if (number < 0)
            return -number;
        else
            return number;
    }

}
