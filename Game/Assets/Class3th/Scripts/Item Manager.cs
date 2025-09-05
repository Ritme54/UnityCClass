using UnityEngine;
using UnityEngine.InputSystem;

public class ItemManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] Itemclass[  ] gameObjects;

    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {

            //Debug.Log(gameObjects[i].name);
            gameObjects[i].transform.gameObject.SetActive(false);
           

        }
        count = gameObjects.Length - 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
        if (Input.GetMouseButtonDown(0))
        {
            gameObjects[count].Activate();
        }
        if (Input.GetMouseButtonDown(1))
        {
            gameObjects[count].Activate1();
        }
    }

    void Swap()
    {
        gameObjects[count].transform.gameObject.SetActive(false);

        count= (count+1) % gameObjects.Length; //3+1=4=0 즉 처음으로 되돌아온다.

        gameObjects[count].transform.gameObject.SetActive(true);




    }
}
