using UnityEngine;
using UnityEngine.UIElements;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    int health;

    public void Damage(int damage)
    {
        if (health <= 0) return;


        health -= damage;


        if (health <= 0)
        {
            health = 0;
        }

        if (health <= 0)
        {
            Debug.Log("You are dead!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            health = startHealth;
        }
    }
}
