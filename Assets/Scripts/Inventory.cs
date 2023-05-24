using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory() {
        itemList = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.Chest, amount = 1 });
        /**AddItem(new Item { itemType = Item.ItemType.One, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Two, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Three, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Four, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Five, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Six, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Seven, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Eight, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Nine, amount = 1 });**/
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item) {
        itemList.Add(item);
    }

    public List<Item> GetItemList() {
        return itemList;
    }
}
