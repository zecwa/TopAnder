using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DedZone : MonoBehaviour
{
    //トリガーに入ったときに呼ばれるメソッド
    private void OnTriggerEnter(Collider other)
    {
        //プレイヤーのタグを持つオブジェクトに触れた場合
        if(other.CompareTag("Player"))
        {
            //ゲームオーバー処理を呼び出す
            GameOver();

        }
    }
    private void GameOver()
    {
        //ゲームオーバーsceneに遷移する
        SceneManager.LoadScene("GameOverScene");
        //または、ゲームオーバー画面を表示するなどの処理をここに追加
    }
}
