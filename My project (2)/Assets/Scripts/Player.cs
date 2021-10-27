using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : NetworkBehaviour
{
    public float health = 10f;
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(1,0.1f,0);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(-1,0.1f,0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(0,0.1f,1);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(0,0.1f,-1);
            }
        }
    }
    void Update()
    {
            HandleMovement();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            GetComponent<Renderer>().material.color = Color.red;
            Destroy(other.gameObject);
            health ++;
        }
        if (other.gameObject.layer == 8)
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Destroy(other.gameObject);
            health ++;
        }
        if (other.gameObject.layer == 9)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            Destroy(other.gameObject);
            health ++;
        }
    }  
}