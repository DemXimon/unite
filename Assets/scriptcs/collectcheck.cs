using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcheck : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    [SerializeField] public int number;
    [SerializeField] public GameObject text;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Character character = collider.GetComponent<Character>();
        if (character)
        {
            if (character.Items==number)
            {
                Destroy(obj);
            }
            else
            {
                text.SetActive(true);
            }
        }
    }
}
