using UnityEngine;
using UnityEngine.Events;

public class Detect : MonoBehaviour
{
    [SerializeField] UnityEvent Callback;



    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("A");
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("B");

        // score++;
        // Debug.Log("Á¡¼ö"+score);
        if (Callback != null)
        {
            Callback.Invoke();
          
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        //   Debug.Log("C");

    }




}
