using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Robot : MonoBehaviour
{
    [SerializeField] Ability ability;
   



    private void Awake()
    {//Awake : ��ü�� ������ �� ȣ��Ǵ� �Լ���,
     //��ü�� ��Ȱ��ȭ �Ǿ����� ������ ȣ��Ǹ�,
     //�� �ѹ��� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
        
        //ability = new Ability();

        Debug.Log("Awake");

    //    Debug.Log(ability.Strength);

    }
    private void OnEnable()
    {
        //��ü�� Ȱ��ȭ�Ǿ�����, ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
        Debug.Log("OnEnable");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start : ��ü�� �����Ǿ��� �� ȣ��Ǹ�, �� �ѹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("start");



    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time Step�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
        Debug.Log("FixedUpdate");
    }


    // Update is called once per frame
    void Update()
    { //��ü�� Ȱ��ȭ�Ǵ� ���� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��̴�.
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        //�� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("LateUpdate");
    }

    

}
