using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    private Vector3 Offset = new Vector3(0, 2f, -10f);
    private Vector3 Velocity = Vector3.zero;
    private float SmoothTime = 0.20f;
    private bool PlayerGatoActive = true;

   // [SerializeField] private Transform TargetGato;
   // [SerializeField] private Transform TargetHumana;

    //[SerializeField] private PlayerGatoController PlayerGato;
   // [SerializeField] private PlayerHumanaController PlayerHumana;

    [SerializeField] private GameObject PlayerG;
    [SerializeField] private GameObject PlayerH;

    // Start is called before the first frame update
    void Start()
    {
        PlayerH.GetComponent<PlayerHumanaController>().enabled = false; // PlayerHumana.enabled = false;
        PlayerH.GetComponent<BoxCollider2D>().enabled = false;
        PlayerH.GetComponent<CircleCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            SwitchPlayer();

        //if (PlayerGatoActive)
        //{
        //    Vector3 TargetPosition = TargetGato.position + Offset;
        //    transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothTime);
        //}
        //else
        //{
        //    Vector3 TargetPosition = TargetHumana.position + Offset;
        //    transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothTime);
        //}
    }

    public void SwitchPlayer()
    {
        //PlayerG.GetComponent<PlayerGatoController>().enabled = false;

        if (PlayerGatoActive)
        {
            PlayerG.GetComponent<PlayerGatoController>().enabled = false;

            //PlayerG.GetComponent<BoxCollider2D>().enabled = false;
            PlayerG.GetComponent<CircleCollider2D>().enabled = false;
            PlayerG.GetComponent<Rigidbody2D>().Sleep();

            PlayerH.GetComponent<PlayerHumanaController>().enabled = true;
            PlayerH.GetComponent<BoxCollider2D>().enabled = true;
            PlayerH.GetComponent<CircleCollider2D>().enabled = true;

            PlayerGatoActive = false;
        }
        else
        {
            PlayerH.GetComponent<PlayerHumanaController>().enabled = false;

            PlayerH.GetComponent<BoxCollider2D>().enabled = false;
            PlayerH.GetComponent<CircleCollider2D>().enabled = false;
            PlayerH.GetComponent<Rigidbody2D>().Sleep();

            PlayerG.GetComponent<PlayerGatoController>().enabled = true;
           // PlayerG.GetComponent<BoxCollider2D>().enabled = true;
            PlayerG.GetComponent<CircleCollider2D>().enabled = true;

            PlayerGatoActive = true;
        }

        //if (PlayerGatoActive)
        //{
        //    PlayerGato.enabled = false;
        //    PlayerHumana.enabled = true;
        //    PlayerGatoActive = false;
        //}
        //else
        //{
        //    PlayerGato.enabled = true;
        //    PlayerHumana.enabled = false;
        //    PlayerGatoActive = true;
        //}
    }
    private void LateUpdate()
    {
        if (PlayerGatoActive)
        {
            Vector3 TargetPosition = PlayerG.GetComponent<Transform>().position + Offset;
            //Vector3 TargetPosition = TargetGato.position + Offset;
            transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothTime);
        }
        else
        {
            Vector3 TargetPosition = PlayerH.GetComponent<Transform>().position + Offset;
            //Vector3 TargetPosition = TargetHumana.position + Offset;
            transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothTime);
        }
    }
}