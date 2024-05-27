using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Clear_Flags : MonoBehaviour
{
   

    private Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
     
       

    }

    void Start()
    {
        
        cam.clearFlags = CameraClearFlags.SolidColor;


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            cam.clearFlags = CameraClearFlags.Skybox;
        }

    }
}