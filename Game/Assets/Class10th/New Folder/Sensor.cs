

using UnityEngine;


public class Sensor : MonoBehaviour
{
    //[SerializeField]
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "New tag")
        {
           other.gameObject.GetComponent<Control>().Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
   private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "New tag")
        {
            other.gameObject.GetComponent<Control>().Revert();
        }
    }




}





