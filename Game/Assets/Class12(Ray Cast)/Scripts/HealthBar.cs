using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HealthBar : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth;
    [SerializeField] UnityEngine.UI.Slider slider;


    void Awake()
    {
        maxHealth = health;
        slider.maxValue = maxHealth;
    }


    void Start()
    {
        UpdateUI();
       slider.value = maxHealth;

    }

    public void Damage(float attack)
    {
        health -= attack;
        if (health < 0) health = 0;
        UpdateUI();
    }
    public void UpdateUI()
    {
        slider.value = health / maxHealth;
    }
    // Update is called once per frame
    void Update()
    {



    }




}
