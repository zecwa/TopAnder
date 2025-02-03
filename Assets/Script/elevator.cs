using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{

    public float speed = 2.0f; // エレベーターの移動速度
    public float floorHeight = 5.0f; // 各フロアの高さ
    public int currentFloor = 0; // 現在のフロア
    public int targetFloor = 0; // 目標のフロア

    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 目標のフロアに向かって移動
        Vector3 targetPosition = initialPosition + new Vector3(0, floorHeight * targetFloor, 0);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // 現在のフロアを更新
        if (transform.position == targetPosition)
        {
            currentFloor = targetFloor;
        }
    }
    //エレベーターの目標フロアを設定するメソッド
    public void SetTargetFloor(int floor)
    {
        targetFloor = floor;
    }

}
