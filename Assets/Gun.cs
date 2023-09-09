using UnityEngine;

class Gun : MonoBehaviour
{
    [SerializeField] int ammo = 2;
    [SerializeField] int magazineSize = 2;
    [SerializeField] int magazineCount = 4;


    void Update()
    {

        bool shoot = Input.GetKeyDown(KeyCode.Space);

        if (shoot)
        {

            if (ammo > 0)
            {
                Debug.Log("PEW");
                ammo -= 1;
            }
            else
            {
                Debug.Log("*click*");

                if(magazineCount > 0)
                {
                    magazineCount-= 1;
                    ammo = magazineSize;                }
            }

        }

    }

}
