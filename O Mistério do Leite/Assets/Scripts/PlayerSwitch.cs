using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    private Vector3 Offset = new Vector3(0, 2f, -10f);
    private Vector3 Velocity = Vector3.zero;
    private float SmoothTime = 0.20f;
    private bool PlayerGatoActive = true;

    [SerializeField] private Transform TargetGato;
    [SerializeField] private Transform TargetHumana;

    [SerializeField] private PlayerGatoController PlayerGato;
    [SerializeField] private PlayerHumanaController PlayerHumana;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHumana.enabled = false;
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
        if (PlayerGatoActive)
        {
            PlayerGato.enabled = false;
            PlayerHumana.enabled = true;
            PlayerGatoActive = false;
        }
        else
        {
            PlayerGato.enabled = true;
            PlayerHumana.enabled = false;
            PlayerGatoActive = true;
        }
    }
    private void LateUpdate()
    {
        if (PlayerGatoActive)
        {
            Vector3 TargetPosition = TargetGato.position + Offset;
            transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothTime);
        }
        else
        {
            Vector3 TargetPosition = TargetHumana.position + Offset;
            transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, SmoothTime);
        }
    }
}