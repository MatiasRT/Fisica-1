using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    [SerializeField] SpriteRenderer sp1;
    [SerializeField] SpriteRenderer sp2;

    float width1;
    float width2;
    float height1;
    float height2;
    Vector2 pos1;
    Vector2 pos2;

    void Start()
    {
        sp1 = sp1.GetComponent<SpriteRenderer>();
        sp2 = sp2.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        width1 = sp1.bounds.size.x;
        width2 = sp2.bounds.size.x;

        height1 = sp1.bounds.size.y;
        height2 = sp2.bounds.size.y;

        pos1 = sp1.transform.position;
        pos2 = sp2.transform.position;

        Debug.Log(pos1);
        Debug.Log(pos2 + " asteroide");

        CheckCollision();
    }

    void CheckCollision()
    {
        Vector2 diff = pos1 - pos2;

        float diffX = Mathf.Abs(diff.x);
        float diffY = Mathf.Abs(diff.y);

        if(diffX <= (width1 / 2 + width2 / 2) && diffY <= (height1 / 2 + height2 / 2))
        {
            Debug.Log("Colision");
        }
    }
}