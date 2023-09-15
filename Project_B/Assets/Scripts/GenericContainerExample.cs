using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intContainer;
    private GenericContainer<string> stringContainer;
    void Start()
    {
        intContainer = new GenericContainer<int>(10);          //int형 컨테이너 선언 10칸
        stringContainer = new GenericContainer<string>(15);    //String형 컨테이너 선언 15칸
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))                   //키보드 1 버튼
        {
            intContainer.Add(Random.Range(0, 100));            //0~100 랜덤 (int)
            DisplayContainerItems(intContainer);
        }                                                      //키보드 2 버튼
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            string randomString = " item " + Random.Range(0, 100);     //0~100 랜덤(String)
            stringContainer.Add(randomString);                         //문자열 -> item 0~100
            DisplayContainerItems(stringContainer);
        }
    }

    private void DisplayContainerItems<T>(GenericContainer<T> container)
    {//생성한 컨테이너를 debug.log에서 볼 수 있게 만든 함수
        T[] items = container.Getitems();
        string temp = "";
        for(int i = 0; i < items.Length; i++)
            if(items[i] != null)
            {
                temp += items[i].ToString() + " - ";
            }
            else
            {
                temp += "Empty - ";
            }
        Debug.Log(temp);
    }
}
