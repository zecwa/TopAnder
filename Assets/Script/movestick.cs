using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movestick : MonoBehaviour
{
    //上下
    public float moveRange = 2.0f;
    //最小速度
    public float minSpeed;
    //最大速度
    public float maxSpeed;
    //初期位置
    private Vector3 initialPosition;
    //移動速度
    private float moveSpeed;
    //動く方向
    private bool movingUp = true;

    void Start()
    {
        // 初期位置を保存
        initialPosition = transform.position;
        //速度ランダム
        moveSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        // 現在の位置を取得
        Vector3 currentPosition = transform.position;
        // 上下の移動範囲を計算
        float upperLimit = initialPosition.y + moveRange;
        float lowerLimit = initialPosition.y - moveRange;

        // 上下に移動
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

        // 新しい位置を設定
        transform.position = currentPosition;
    }
}
