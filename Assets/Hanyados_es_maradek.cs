using UnityEngine;

public class Hanyados_es_maradek : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;

    [SerializeField] int outDiv;
    [SerializeField] int outMod;


    // Start is called before the first frame update
    void OnValidate()
    {
        ///int num1 = 14;
        ///int num2 = 5;

        outMod = num1 % num2;
        outDiv = num1 / num2;

        ///Debug.Log($"Bemente: {num1}, {num2}");        
        ///Debug.Log($"Kimenet: {outDiv}, {outMod}  (Mivel {num1}-ben az {num2} megvan {outDiv}-szer. Maradék, a {outMod}.)");

    }
}
