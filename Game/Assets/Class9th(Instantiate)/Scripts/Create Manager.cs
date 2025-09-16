using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] GameObject prefab;
    [SerializeField] int count;
    [SerializeField] List<GameObject> unitList;

   // private readonly List<GameObject> pool = new List<GameObject>();

    void Start()
    {

        // var instance = Instantiate(prefab, gameObject.transform);


        //  instance.transform.position += new Vector3(1, 0, 0);

        // for (int i = 0; i < poolSize; i++)
        // {
        // var instance = Instantiate(prefab, gameObject.transform);
        //     instance.SetActive(false); 
        //     pool.Add(instance);
        // }


        //Enum @Jump = instance.GetComponent<Enum>();
        Initialize();
    }

    void Initialize()
    {
        unitList.Capacity = 10;
        for (int i = 0; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, gameObject.transform);
            clone.SetActive(false);
            unitList.Add(clone);
        }
    }

    void Update()
    {
        

        timer += Time.deltaTime;

        if (timer>= 5.0f)
        {
            Debug.Log("Call");
            timer = 0.0f;
        }
        
        


        
    }



}
