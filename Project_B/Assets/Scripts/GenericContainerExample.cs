using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intContainer;
    private GenericContainer<string> stringContainer;
    void Start()
    {
        intContainer = new GenericContainer<int>(10);          //int�� �����̳� ���� 10ĭ
        stringContainer = new GenericContainer<string>(15);    //String�� �����̳� ���� 15ĭ
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            intContainer.Add(Random.Range(0, 100));
            DisplayContainerItems(intContainer);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            string randomString = " item " + Random.Range(0, 100);
            stringContainer.Add(randomString);
            DisplayContainerItems(stringContainer);
        }
    }

    private void DisplayContainerItems<T>(GenericContainer<T> container)
    {//������ �����̳ʸ� debug.log���� �� �� �ְ� ���� �Լ�
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
