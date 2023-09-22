using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public enum SLOTSTATE                                   //½½·Ô »óÅÂ°ª
    {
        EMPTY,
        FULL
    }
                                                         
    public int id;                                          //½½·Ô¹øÈ£ 10
    public Item itemObject;
    public SLOTSTATE state = SLOTSTATE.EMPTY;



    private void ChangeStateTo(SLOTSTATE targetState)
    {
        state = targetState;
    }

    public void ItemGrabbed()
    {
        Destroy(itemObject.gameObject);
        ChangeStateTo(SLOTSTATE.EMPTY);
    }

    public void CreateItem(int id)
    {
        string itemPath = "Prefaps/Item_" + id.ToString("000");
        var itemGo = (GameObject)Instantiate(Resources.Load(itemPath));

        itemGo.transform.SetParent(this.transform);
        itemGo.transform.localPosition = Vector3.zero;
        itemGo.transform.localScale = Vector3.one;

        itemObject = itemGo.GetComponent<Item>();
        itemObject.Init(id, this);

        ChangeStateTo(SLOTSTATE.FULL);

    }

}
