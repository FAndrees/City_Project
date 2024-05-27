using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

[RequireComponent(typeof(Rigidbody))]
public class m_Checkpoint : MonoBehaviour
{
    public Vector3 m_Offset = Vector3.zero;
    [HideInInspector]
   

    public virtual void Action()
    {
        print("Action");
    }

    public void ApplyOffset(Transform hand)
    {
        transform.SetParent(hand);
        transform.localRotation = Quaternion.identity;
        transform.localPosition = m_Offset;
        transform.SetParent(null);
    }
}
