using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType {
        Chest
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite() {
        switch (itemType) {
            default:
            case ItemType.Chest: return ItemAssets.Instance.chest;
            //case ItemType.One: return ItemAssets.Instance.one;
            //case ItemType.Two: return ItemAssests.Instance.two;
            //case ItemType.Three: return ItemAssets.Instance.three;
            //case ItemType.Four: return ItemAssets.Instance.four;
            //case ItemType.Five: return ItemAssets.Instance.five;
           // case ItemType.Six: return ItemAssets.Instance.six;
           // case ItemType.Seven: return ItemAssets.Instance.seven;
           // case ItemType.Eight: return ItemAssets.Instance.eight;
           // case ItemType.Nine: return ItemAssets.Instance.nine;
        }
    }
}
