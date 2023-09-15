using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;


    public static T Instance
    {
        get
        {
            if(_instance == null)                                   //인스턴스가 없을 경우
            {
                _instance = FindObjectOfType<T>();                   //클래스 타입 찾는다
                if (_instance == null)
                {
                    GameObject obj = new GameObject();                //오브젝트 생성
                    obj.name = typeof(T).Name;                        //이름 설정
                    _instance = obj.AddComponent<T>();
                }
                    
            }
            return _instance;

        }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }



}
