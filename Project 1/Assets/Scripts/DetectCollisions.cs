using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
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
        if (other.tag == "enemy")
        {
            Destroy(gameObject); 
            Destroy(other.gameObject);         
        }
    } 
    
    void OnCollisionEnter(Collision other) 
    { 
        if (other.gameObject.CompareTag("enemy")) 
        { 
            explosionParticle.Play();  
            Debug.Log("Shooooott");
        } 
    }
}
