using UnityEngine;
using UnityEngine.Rendering;

public class Control : MonoBehaviour
{
   [SerializeField] ForceMode forceMode;
    [SerializeField] float power;
    [SerializeField] Vector3 direction;
    [SerializeField] new Rigidbody rigidbody;



    private void Awake()
    {
        forceMode = ForceMode.Acceleration;
        rigidbody = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        direction.y = 0f;
        direction.Normalize();

    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction*power, forceMode);
    }

    public void Soar()
    {
        power = 10f;
        direction =Vector3.zero;
        forceMode = ForceMode.Impulse;

    }

    public void Revert()
        {
        power = 5f;
        direction = Vector3.zero;
        forceMode = ForceMode.Force;
    }



}
