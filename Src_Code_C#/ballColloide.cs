using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballColloide : MonoBehaviour
{
    /*public Collider ��ײ��;
    private void Start()
    {
    }
    */
    private void OnCollisionEnter(Collision gameObject)
    {
        GameObject.Destroy(gameObject.gameObject, 3);
    }
}
