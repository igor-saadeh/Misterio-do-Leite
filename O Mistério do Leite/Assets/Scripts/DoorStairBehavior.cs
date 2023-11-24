using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStairBehavior : MonoBehaviour
{
    [SerializeField] private PlayerHumanaController PlayerH;
    [SerializeField] private Transform DoorStair;
    private bool IsPlayerOnTrigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerOnTrigger && PlayerH.IsUsingStairs())
        {
            PlayerH.gameObject.transform.position = DoorStair.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsPlayerOnTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsPlayerOnTrigger = false;
    }
}
