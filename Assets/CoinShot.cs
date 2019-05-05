﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinShot : MonoBehaviour
{
    public float coinspeed;
    public GameObject template_coin;
    public float posx, posy;


    public void OnColliderEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
            // Start is called before the first frame update
            void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject temp = GameObject.Instantiate(template_coin);
            temp.transform.SetPositionAndRotation(new Vector3(posx,posy , 0), temp.transform.rotation);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(coinspeed, 0);

        }

    }
}