using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ParticleSystem explosionParticle; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    { 
        if (other.tag == "Shoot")
        {
            explosionParticle.Play();        
        }
    } 
    private void OnCollisionEnter(Collision other) 
    { 
        if (other.gameObject.CompareTag("Shoot")) 
        { 
            explosionParticle.Play();  
        } 
    }
} 