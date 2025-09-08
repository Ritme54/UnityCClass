using UnityEngine;
using UnityEngine.Animations;

public class Character : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float movespeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


       // transform.position = new Vector3(1, 1, 1);

       // Debug.Log("p "+transform.position);
        
        

    }

    // Update is called once per frame
    void Update()
    {           //transform.position += new Vector3(0, 0, 1); 

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxis("Jump");
        direction.z = Input.GetAxisRaw("Vertical");
        direction.Normalize();

        // Time.deltaTime
        //마지막 프레임 이후의 완료되는 시간.
        transform.position = transform.position + direction*Time.deltaTime* movespeed;


        //float x = Input.GetAxis("Horizontal");
        //Vector3 direction = Vector3.right;
        //transform.position += direction * x * Time.deltaTime*moveSpeed;


        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += Vector3.forward;
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //   
        //    transform.position += Vector3.left;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //   
        //    transform.position += Vector3.back;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //   
        //    transform.position += Vector3.right;
        //}
    }
}
