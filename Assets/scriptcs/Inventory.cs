using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    private Transform[] items = new Transform[4];

    private Character character;


    private void Awake()
    {
        character = FindObjectOfType<Character>();

        for (int i = 0; i < items.Length; i++)
        {
            items[i] = transform.GetChild(i);
            Debug.Log(items[i]);
        }
    }

    public void Refresh()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i < character.Items) items[i].gameObject.SetActive(true);
            else items[i].gameObject.SetActive(false);
        }
    }
}
