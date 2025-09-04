using UnityEngine;
using UnityEngine.InputSystem;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {

            //Debug.Log(gameObjects[i].name);
            gameObjects[i].SetActive(false);
           

        }
    }
    private void Update()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObjects[i].SetActive(true);
            }


        }
    }
}
