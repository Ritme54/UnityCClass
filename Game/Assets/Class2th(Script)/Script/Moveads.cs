using UnityEngine;

public class Moveads : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    float power = 1f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rb.AddForce(Vector3.left * power);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rb.AddForce(Vector3.right * power);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            rb.AddForce(Vector3.forward * power);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            rb.AddForce(Vector3.back * power);
        }
    }

    // Update is called once per frame
   
}
