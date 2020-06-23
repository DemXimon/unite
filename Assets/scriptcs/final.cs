using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    [SerializeField] public int number;
    [SerializeField] public GameObject text;
    [SerializeField] public string newLevel;
    private void OnTriggerStay2D(Collider2D coll)
    {
        Character character = coll.GetComponent<Character>();
        if (character.Items == number && coll.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(newLevel);
        }  
    }
}
