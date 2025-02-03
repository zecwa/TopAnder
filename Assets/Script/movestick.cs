using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movestick : MonoBehaviour
{
    //�㉺
    public float moveRange = 2.0f;
    //�ŏ����x
    public float minSpeed;
    //�ő呬�x
    public float maxSpeed;
    //�����ʒu
    private Vector3 initialPosition;
    //�ړ����x
    private float moveSpeed;
    //��������
    private bool movingUp = true;

    void Start()
    {
        // �����ʒu��ۑ�
        initialPosition = transform.position;
        //���x�����_��
        moveSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        // ���݂̈ʒu���擾
        Vector3 currentPosition = transform.position;
        // �㉺�̈ړ��͈͂��v�Z
        float upperLimit = initialPosition.y + moveRange;
        float lowerLimit = initialPosition.y - moveRange;

        // �㉺�Ɉړ�
        if (movingUp)
        {
            currentPosition.y += moveSpeed * Time.deltaTime;
            if (currentPosition.y >= upperLimit)
            {
                currentPosition.y = upperLimit;
                movingUp = false;
                moveSpeed = Random.Range(minSpeed, maxSpeed);
            }
        }
        else
        {
            currentPosition.y -= moveSpeed * Time.deltaTime;
            if (currentPosition.y <= lowerLimit)
            {
                currentPosition.y = lowerLimit;
                movingUp = true;
                moveSpeed = Random.Range(minSpeed, maxSpeed);
            }
        }

        // �V�����ʒu��ݒ�
        transform.position = currentPosition;
    }
}
