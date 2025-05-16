using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Les2 : MonoBehaviour
{
   private Rigidbody rb;
    void Start()
    {
       rb = gameObject.AddComponent<Rigidbody>();
       rb.mass = 5;

        //rb.AddForce(transform.up * 100f,ForceMode.Force);





    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * Input.GetAxis("Horizontal") * 0.5f;
        transform.position += new Vector3(1f, 0f, 0f) * 0f * 0.05f;

        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(transform.up * 20f, ForceMode.Impulse);
        }

        




        //transform.position += transform.right * 0.1f;
       // transform.Rotate(Vector3.up, 1f);
        //transform.localScale = Vector3.one * 5f;
    }
}