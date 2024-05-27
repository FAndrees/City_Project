using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class Checkpoint : MonoBehaviour {
    public Material[] material;
    public GameObject m_Checkpoint;
    Renderer rend;
    public Collider target;
   
    void Start()
    {
   
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
  
    }
    void OnTriggerEnter(Collider target)
    {
        if (m_Checkpoint == target)
        {
            print("We hit the target trigger");
            rend.sharedMaterial = material[1];
        }
  
    }
    void OnTriggerExit(Collider target)
    {
        if (m_Checkpoint != target)
        {
            print("We destroy the target trigger");
            Destroy(gameObject);
        } 
    }
}

