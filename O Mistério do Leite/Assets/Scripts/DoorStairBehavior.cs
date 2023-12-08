using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStairBehavior : MonoBehaviour
{
    [SerializeField] private PlayerHumanaController PlayerH;
    [SerializeField] private PlayerGatoController PlayerG;
    [SerializeField] private Transform DoorStair;
    private bool IsPlayerHOnTrigger = false;
    private bool IsPlayerGOnTrigger = false;

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerHOnTrigger && PlayerH.IsUsingStairs())
        {
            PlayerH.gameObject.transform.position = DoorStair.position;
        }
        else if (IsPlayerGOnTrigger && PlayerG.IsUsingStairs())
        {
            PlayerG.gameObject.transform.position = DoorStair.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player_Humana")
            IsPlayerHOnTrigger = true;
        else if (collision.gameObject.name == "Player_Gato")
            IsPlayerGOnTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player_Humana")
            IsPlayerHOnTrigger = false;
        else if (collision.gameObject.name == "Player_Gato")
            IsPlayerGOnTrigger = false;
    }
}
