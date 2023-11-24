using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player_Humana")
        {
            GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);
        }
    }
}
