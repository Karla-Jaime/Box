using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
          //vector up, 1x y 0y
        rb2d.AddForce(Vector2.up * 1000, ForceMode2D.Force);
    }
}


