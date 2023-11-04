using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    [SerializeField] float invincibilityFrames = 2f;
    [SerializeField] float flickTime = 0.2f;

    int health;

    public void Damage(int damage)
    {
        if (health <= 0) return;


        health -= damage;
        
        StartCoroutine(StartInvincibility());


        if (health <= 0)
        {
            health = 0;
        }

        if (health <= 0)
        {
            Debug.Log("You are dead!");
        }
    }

    IEnumerator StartInvincibility()
    {
        Collider coll = GetComponentInChildren<Collider>();
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        
        coll.enabled = false;
        float maxTime = Time.time + invincibilityFrames;
        while (Time.time < maxTime)
        {
            yield return new WaitForSeconds(flickTime);
            
            foreach (Renderer renderer in renderers)
            {
                renderer.enabled = !renderer.enabled;
            }

        }

        foreach (Renderer renderer in renderers)
        {
            renderer.enabled = true;
        }

        coll.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            health = startHealth;
        }
    }
}
