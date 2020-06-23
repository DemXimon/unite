using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class button : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    public GameObject newplace;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "Player")|| (other.tag=="Box"))
        { 
            obj.transform.position = newplace.transform.position;
        }
    }
}
  