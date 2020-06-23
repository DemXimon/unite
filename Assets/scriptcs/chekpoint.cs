using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chekpoint : MonoBehaviour
{
    [SerializeField] public GameObject respawn;
    [SerializeField] public GameObject checkpoint;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Character character = collider.GetComponent<Character>();
        if (character)
        {
            respawn.transform.position = checkpoint.transform.position;
        }
    }
}
