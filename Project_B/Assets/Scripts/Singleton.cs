using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton:MonoBehaviour                     //1���� �̱��� Ŭ���� ����
{
    public static Singleton Instance { get; private set; }              //�̱����� �ν��Ͻ� ������ ����


    public void Awake()                                                 //Awake �������� �ν��Ͻ� �˻�
    {
        if(Instance == null)                                              //�ν��Ͻ��� ���� ���
        {
            Instance = this;                                            //���� �ν��Ͻ��� Static �� �Է�
            DontDestroyOnLoad(gameObject);                              //DontDestroyOnLoad �ı����� �ʴ� ������Ʈ ����

        }
        else
        {                                                               //������ �ν��Ͻ��� ���� ��� �ı� ��Ų��
            Destroy(gameObject);
        }
    }

    public int playerScore = 0;                                          //���� ���ھ� int ����


    public void IncreaseScore(int amount)                                //���� ���ھ� ���� �Լ� ����
    {
        playerScore += amount;                                           //�����ش�
    }

    
}
