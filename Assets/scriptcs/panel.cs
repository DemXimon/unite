using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    [SerializeField] public GameObject newplace;
    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag =="Player"&& Input.GetKey(KeyCode.E))
        {
            Destroy(obj);
        }
    }
}
