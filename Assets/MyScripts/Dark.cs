using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark : MonoBehaviour
{
 
    public GameObject dark = null;
   
    public CharacterController m_CharacterController = null;
    bool  _light; 
    // Start is called before the first frame update
    void Start()
    {
        dark.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad0))
        { _light = !_light; }


         if (_light)
            { 
            dark.SetActive(false);
            
            return;
        }

        if (!_light)
        {
            dark.SetActive(true);
            
            {
                    Vector3 startPosition = Vector3.zero;
                    startPosition.x = 115f;
                    startPosition.y = 542.7f;
                    startPosition.z = -271f;
                    m_CharacterController.transform.position = startPosition;

            }
            return;
        }

    }
}
