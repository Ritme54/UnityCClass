using UnityEngine;
[System.Serializable]
public class Ability
{
    [SerializeField] int strength = 5;

   // public int Strength { get {  }  }

    public Ability()
    {


        Debug.Log("Created Ability");


    }





    void Start()
    {
        Debug.Log("strength : " + strength);
    }


   

}
