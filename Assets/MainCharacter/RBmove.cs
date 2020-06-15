using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBmove : MonoBehaviour
{
   
    public float speed = 5;
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpforce = 7;
    public SphereCollider col;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    void Update()
    {

        float v = Input.GetAxis("Vertical") *speed* Time.deltaTime;
        float h = Input.GetAxis("Horizontal") *speed* Time.deltaTime;

        //     Vector3 movement = transform.right * h;
        transform.Translate(h, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
}
