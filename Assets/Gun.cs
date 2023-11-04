using System;
using UnityEditor;
using UnityEngine;

class Gun : MonoBehaviour
{
    [SerializeField] int ammo = 10;

    [SerializeField] int magazineSize = 10;
    [SerializeField] int magazineCount = 5;


    [SerializeField] GameObject bulletPrototype;

    void Update()
    {
        bool shoot = Input.GetKeyDown(KeyCode.Space);

        if (shoot)
        {
            if (ammo > 0)
            {
                Bang();
                ammo--;
            }
            else
            {
                Click();

                if (magazineCount > 0)
                {
                    magazineCount--;
                    ammo = magazineSize;
                }
            }
        }
    }

    [SerializeField] AudioSource bangSound;
    [SerializeField] AudioSource clickSound;

    [SerializeField] float bulletSpeed;

    void Click()
    {
        if (clickSound != null)
            clickSound.Play();
    }

    void Bang()
    {
        if (bangSound != null)
            bangSound.Play();


        Vector3 p = transform.position;
        Quaternion r = Quaternion.LookRotation(transform.up);
        GameObject newBullet = Instantiate(bulletPrototype, p, r);

        Rigidbody newRb = newBullet.GetComponent<Rigidbody>();
        newRb.velocity = newBullet.transform.forward * bulletSpeed;

    }
}