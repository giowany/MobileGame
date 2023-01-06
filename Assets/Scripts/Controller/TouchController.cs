using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public Vector2 passPosition;
    public float velocity = 1f;


    public void TouchControl()
    {
        if (Input.GetMouseButton(0))
        {
            Move(Input.mousePosition.x - passPosition.x);
        }

        passPosition = Input.mousePosition;
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
