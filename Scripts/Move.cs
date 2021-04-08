using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float speed = 5f;
    public Camera cam;
    Vector2 vector;
    Vector2 vectorM;

    // Update is called once per frame
    void Update()
    {
        vector.y = Input.GetAxisRaw("Vertical");
        vector.x = Input.GetAxisRaw("Horizontal");
        vectorM = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + vector * speed * Time.fixedDeltaTime);

        Vector2 ternTo = vectorM - rigidbody.position;
        float angl = Mathf.Atan2(ternTo.y, ternTo.x) * Mathf.Rad2Deg - 90f;
        rigidbody.rotation = angl;

    }

}
