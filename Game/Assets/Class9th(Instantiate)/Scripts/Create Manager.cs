using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Linq;

public class CreateManager : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] GameObject prefab;
    [SerializeField] int count;
    [SerializeField] int index;
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
        //        Initialize();
        //StartCoroutine(Coroutine());
        Initialize();
        StartCoroutine(Scheduler());
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
    bool ExamineActive()
    {
        if (unitList == null || unitList.Count == 0) return false;
        for (int i = 0; i < unitList.Count; i++)
        {
            var go = unitList[i];
            if (go == null || !go.activeSelf)
                return false;
        }
        return true;
    }

    IEnumerator Scheduler()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
            var candidates = unitList.Where(clone => clone != null && !clone.activeSelf).ToList();
            if (candidates.Count == 0)
            {

                Debug.Log("All units are active.");
                yield break;
            }


            index = UnityEngine.Random.Range(0, candidates.Count);
            var selected = candidates[index];
            selected.SetActive(true);


            if (ExamineActive())
            {
                yield break;
            }

        }

    }

    IEnumerator Coroutine()
    {


        Debug.Log("Start");
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Exit");

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2.0f)
        {
            Debug.Log("Call");
            timer = 0.0f;
        }

    }
}



