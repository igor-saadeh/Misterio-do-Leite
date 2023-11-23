using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    [SerializeField] private PlayerHumanaController PlayerH;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerH.IsInteractingPressed());

        if (PlayerH.IsInteractingPressed())
        {
            Debug.Log("2");
            Physics2D.IgnoreCollision(PlayerH.gameObject.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>(), false);
            Physics2D.IgnoreCollision(PlayerH.gameObject.GetComponent<CircleCollider2D>(), GetComponent<BoxCollider2D>(), false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player_Humana" && !PlayerH.IsInteractingPressed())
        {
            Debug.Log("1");
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<CircleCollider2D>(), GetComponent<BoxCollider2D>());
        }
    }
}
