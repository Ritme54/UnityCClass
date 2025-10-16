using UnityEngine;

public class HomeButton : MonoBehaviour
{
    [SerializeField] private SceneryManager _sceneryManager;




    public void ReturnToHome()
    {
        if (_sceneryManager != null)
        {
            _sceneryManager.LoadScene(0);
        }
        else
        {
         
            Debug.LogError("SceneryManager is not assigned to the HomeButton script in the Inspector.", this);
        }
    }
}