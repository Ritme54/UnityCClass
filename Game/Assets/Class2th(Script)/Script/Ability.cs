using UnityEngine;

public class Ability : MonoBehaviour
{

    public int strength = 5;

    public Ability()
    {
        Debug.Log("Created Ability");


    }





    void Start()
    {
        Debug.Log("strength : " + strength);
    }


   

}
