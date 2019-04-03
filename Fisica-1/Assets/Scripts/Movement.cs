using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float velInicial;
    [SerializeField] float vel;
    [SerializeField] float acc;

    void Update()
    {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        if (inputY > 0)         
            transform.position = new Vector3(transform.position.x, transform.position.y + (velInicial + (vel * Time.deltaTime)), 0);

        if (inputY < 0)
            transform.position = new Vector3(transform.position.x, transform.position.y - (velInicial + (vel * Time.deltaTime)), 0);

        float mruv1 = transform.position.x + (velInicial * Time.deltaTime) + (acc * 0.5f * Mathf.Sqrt(Time.deltaTime));
        float mruv2 = transform.position.x - (velInicial * Time.deltaTime) - (acc * 0.5f * Mathf.Sqrt(Time.deltaTime));

        if (inputX > 0)
            transform.position = new Vector3(mruv1, transform.position.y, 0);

        if (inputX < 0)
            transform.position = new Vector3(mruv2, transform.position.y, 0);
    }
}
