using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class releasebut : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    public GameObject oldplace;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player")
        {
            obj.transform.position = oldplace.transform.position;
        } 
    }

}
