using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DedZone : MonoBehaviour
{
    //�g���K�[�ɓ������Ƃ��ɌĂ΂�郁�\�b�h
    private void OnTriggerEnter(Collider other)
    {
        //�v���C���[�̃^�O�����I�u�W�F�N�g�ɐG�ꂽ�ꍇ
        if(other.CompareTag("Player"))
        {
            //�Q�[���I�[�o�[�������Ăяo��
            GameOver();

        }
    }
    private void GameOver()
    {
        //�Q�[���I�[�o�[scene�ɑJ�ڂ���
        SceneManager.LoadScene("GameOverScene");
        //�܂��́A�Q�[���I�[�o�[��ʂ�\������Ȃǂ̏����������ɒǉ�
    }
}
