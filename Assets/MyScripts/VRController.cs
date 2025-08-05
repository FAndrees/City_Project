using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRController : MonoBehaviour
{
    public float m_Sensitivity = 0.1f;
    public float m_MaxSpeed = 0.7f;
  
    public SteamVR_Action_Boolean m_MovePress = null;
    //public SteamVR_Action_Vector2 m_MoveValue = null;

    private float m_Speed = 0.0f;
    private float m_Direction = 0.0f;

    private Vector3 movement = Vector3.zero;
    private CharacterController m_CharacterController = null;

    private Transform m_CameraRig = null;
    private Transform m_Head = null;

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        m_CameraRig = SteamVR_Render.Top().origin;
        m_Head = SteamVR_Render.Top().head;
    }

    private void Update()
    {
        HandleHead();
        HandleHeight();
        CalculateMovement();
        HandleTerrain();
        Reset();
    }

    private void HandleHead()
    {
        Vector3 oldPosition = m_CameraRig.position;
        Quaternion oldRotation = m_CameraRig.rotation;

        transform.eulerAngles = new Vector3(m_Head.rotation.eulerAngles.x, m_Head.rotation.eulerAngles.y, m_Head.rotation.eulerAngles.z);
        m_CameraRig.position = oldPosition;
        m_CameraRig.rotation = oldRotation;
    }

    private void CalculateMovement()
    {
        Vector3 orientationEuler = new Vector3(m_Direction, m_Head.rotation.eulerAngles.y, m_Head.rotation.eulerAngles.z);
        Quaternion orientation = Quaternion.Euler(orientationEuler);
        Vector3 movement = Vector3.zero;
      
        if (m_MovePress.state)
        {
            m_Speed += m_MoveValue.axis.y * m_Sensitivity;
            m_Speed = Mathf.Clamp(m_Speed, -m_MaxSpeed, m_MaxSpeed);
            movement += orientation * (m_Direction * Vector3.left + m_Speed * Vector3.forward) * Time.deltaTime;
        }
        m_CharacterController.Move(movement);

    }

    private void HandleHeight()
    {

        float HeadHeight = Mathf.Clamp(m_Head.localPosition.y, 1, 2);

        m_CharacterController.height = HeadHeight;
        Vector3 newCenter = Vector3.zero;
        newCenter.y = HeadHeight + 0.05f;
        newCenter.y += m_CharacterController.skinWidth;

        newCenter.x = m_Head.localPosition.x;
        newCenter.z = m_Head.localPosition.z;

        newCenter = Quaternion.Euler(0, -transform.eulerAngles.y, 0) * newCenter;
        m_CharacterController.center = newCenter;
    }
    private void HandleTerrain()
    {
        Ray raydown = new Ray(m_CharacterController.transform.position, transform.TransformDirection(Vector3.down));
        RaycastHit m_Terraindown;

        if (Physics.Raycast(raydown, out m_Terraindown))
        {
            Debug.Log("down" + m_Terraindown.point);
            Vector3 hitTerrain = m_Terraindown.point;
            Vector3 newPosition = Vector3.zero;
            newPosition.y = m_Terraindown.point.y + 0.05f;
            newPosition.x = m_CameraRig.position.x;
            newPosition.z = m_CameraRig.position.z;
            m_CharacterController.transform.position = newPosition;
        }

    }
    private void Reset()
    { 
    if (Input.GetKeyDown(KeyCode.Escape))
        { Vector3 startPosition = Vector3.zero;
            startPosition.x = 115f;
            startPosition.y = 342.7f;
            startPosition.z = -271f;
            m_CharacterController.transform.position = startPosition;
        }
    }
}


