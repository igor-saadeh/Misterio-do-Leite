using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    [SerializeField] private Sprite DoorOpened;
    private bool isOpen = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player_Humana" && !isOpen)
        {
            isOpen = true;
            GetComponent<AudioSource>().Play();
            //gameObject.SetActive(false);
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = DoorOpened;

            
        }
    }
}
