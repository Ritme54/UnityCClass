using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Robot : MonoBehaviour
{
    [SerializeField] Ability ability;
   



    private void Awake()
    {//Awake : 객체가 생성될 때 호출되는 함수로,
     //객체가 비활성화 되어있을 때에도 호출되며,
     //단 한번만 호출되는 이벤트 함수이다.
        
        //ability = new Ability();

        Debug.Log("Awake");

    //    Debug.Log(ability.Strength);

    }
    private void OnEnable()
    {
        //객체가 활성화되었을때, 호출되는 이벤트 함수이다.
        Debug.Log("OnEnable");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start : 객체가 생성되었을 때 호출되며, 단 한번만 호출되는 이벤트 함수입니다.

        Debug.Log("start");



    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time Step에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수이다.
        Debug.Log("FixedUpdate");
    }


    // Update is called once per frame
    void Update()
    { //객체가 활성화되는 동안 매 프레임마다 호출되는 이벤트 함수이다.
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        //한 프레임의 마지막 단계에서 호출되는 이벤트 함수입니다.
        Debug.Log("LateUpdate");
    }

    

}
