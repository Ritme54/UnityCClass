using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Selectable : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;

    private void Awake()
    {
        titleText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void Enter()
    {
        titleText.fontSize = 100;
    }
    public void Exit()
    {
        titleText.fontSize = 75;
    }
    public void Down()
    {
        titleText.fontSize = 50;
    }

}
