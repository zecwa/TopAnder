using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{

    public float speed = 2.0f; // �G���x�[�^�[�̈ړ����x
    public float floorHeight = 5.0f; // �e�t���A�̍���
    public int currentFloor = 0; // ���݂̃t���A
    public int targetFloor = 0; // �ڕW�̃t���A

    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // �ڕW�̃t���A�Ɍ������Ĉړ�
        Vector3 targetPosition = initialPosition + new Vector3(0, floorHeight * targetFloor, 0);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // ���݂̃t���A���X�V
        if (transform.position == targetPosition)
        {
            currentFloor = targetFloor;
        }
    }
    //�G���x�[�^�[�̖ڕW�t���A��ݒ肷�郁�\�b�h
    public void SetTargetFloor(int floor)
    {
        targetFloor = floor;
    }

}
