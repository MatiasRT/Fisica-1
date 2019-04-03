using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsMov : MonoBehaviour
{
    [SerializeField] float velInicial;
    [SerializeField] float vel;

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - (velInicial + (vel * Time.deltaTime)), transform.position.y, 0);
    }

    void Update()
    {
        CheckBoundaries();
    }

    void CheckBoundaries()
    {
        if(transform.position.x < -8.0f)
            Destroy(this.gameObject);
    }
}