using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cube : MonoBehaviour

    
{
    public bool collected = false;
    public bool respawning = false;
    float timeStamp = 0.0f;  
    float respawnTime = 2.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(1, 2, 1);

        if (collected == true)
        {
            if (!respawning)
            {
                //gameObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                timeStamp = Time.time;
            }
            respawning = true;
        }

        if (respawning)
        {
            float respawnTimeElapsed = Time.time - timeStamp;
            if (respawnTime <= respawnTimeElapsed)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                collected = false;
                respawning = false;
            }
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        
                



        
        

        
    }
}
