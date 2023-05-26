using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public Vector2 passPosition;
    public float velocity = 1f;
    public Vector2 limit;


    public void TouchControl()
    {
        if (Input.GetMouseButton(0))
        {
            Move(Input.mousePosition.x - passPosition.x);
        }

        passPosition = Input.mousePosition;

        if (transform.position.x < limit.x) transform.position = new Vector3(limit.x, transform.position.y);
        else if (transform.position.x > limit.y) transform.position = new Vector3(limit.y, transform.position.y);
    }

    void Move(float speed)
    {
        transform.position += Vector3.right * Time.deltaTime * speed * velocity;
    }

    void Update()
    {
        TouchControl();
    }
}
