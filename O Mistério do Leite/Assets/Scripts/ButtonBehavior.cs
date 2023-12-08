using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject Window;
    [SerializeField] private Sprite DoorOpened;
    private bool isEnabled = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerHumana") || collision.gameObject.CompareTag("PlayerGato") && !isEnabled)
        {
            isEnabled = true;
            GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
            //Door.SetActive(false);
            Window.SetActive(false);

            Door.GetComponent<AudioSource>().Play();
            //gameObject.SetActive(false);
            Door.GetComponent<BoxCollider2D>().enabled = false;
            Door.GetComponent<SpriteRenderer>().sprite = DoorOpened;

        }  
    }

//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        if (collision.gameObject.CompareTag("PlayerHumana") || collision.gameObject.CompareTag("PlayerGato"))
//            Door.SetActive(true);
//    }
}
