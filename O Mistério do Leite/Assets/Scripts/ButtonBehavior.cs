using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject Window;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerHumana") || collision.gameObject.CompareTag("PlayerGato"))
        {
            Door.SetActive(false);
            Window.SetActive(false);
        }  
    }

//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        if (collision.gameObject.CompareTag("PlayerHumana") || collision.gameObject.CompareTag("PlayerGato"))
//            Door.SetActive(true);
//    }
}
