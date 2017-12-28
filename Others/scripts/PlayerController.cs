using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;

    public void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);

        body.MovePosition(body.position + movement * speed);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.Z))
        {
            Destroy(collision.gameObject);
        }
    }
}
