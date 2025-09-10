using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;
    [SerializeField] string[] titleList = new string[3] { "Start", "Option", "Quit" };



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Action[] actions = { Execute, Option, Quit };
        for (int i = 0; i < buttonList.Length; i++)
        {
            int index = i;
            buttonList[i].onClick.AddListener(() => actions[index]());

            buttonList[i].GetComponentInChildren<TextMeshProUGUI>().text = titleList[index];

        }
        
    }
    public void Execute()
    {
        Debug.Log("Execute");
    }

    public void Option()
    {
        Debug.Log("Option");

    }
    public void Quit()
    {
        Debug.Log("Quit");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
