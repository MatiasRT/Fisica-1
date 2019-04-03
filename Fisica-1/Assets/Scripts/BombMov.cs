using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMov : MonoBehaviour
{
    [SerializeField] float velInicial;
    [SerializeField] float vel;
    [SerializeField] float acc;
    float grav = 9.8f;

    void FixedUpdate()
    {
        if(vel > 0)
        {
            vel = velInicial - grav * Time.deltaTime; // Tiro vertical

            float mruv = transform.position.x + (vel * Time.deltaTime) + (acc * 0.5f * Mathf.Sqrt(Time.deltaTime));

            transform.position = new Vector3(transform.position.x, mruv, 0);
        }
        else
        {
           /* vel = grav * Time.deltaTime;    // Caida libre

            float mruv = transform.position.x + (vel * Time.deltaTime) + (acc * 0.5f * Mathf.Sqrt(Time.deltaTime));

            transform.position = new Vector3(transform.position.x, mruv, 0);*/
        }

    }

    void Update()
    {
        CheckBoundaries();
    }

    void CheckBoundaries()
    {
        /*if (transform.position.x < -8.0f)
            Destroy(this.gameObject);*/
    }

    
}
