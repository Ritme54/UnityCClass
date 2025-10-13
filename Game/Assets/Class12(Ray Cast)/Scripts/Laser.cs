using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] float maxDistance = 100.0f;
    [SerializeField] float attack;
    [SerializeField] LayerMask layerMask;


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);
            if (Physics.Raycast(ray, out raycastHit, maxDistance))
            {
                raycastHit.collider.gameObject.GetComponent<HealthBar>().Damage(attack);

                Debug.Log(raycastHit.collider.name);

                if (Physics.Raycast(ray, out raycastHit, maxDistance))
                {
                    raycastHit.collider.gameObject.GetComponent<HealthBar>().Damage(attack);

                }

               


            }
        }   
    }
}
