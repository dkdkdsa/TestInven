using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Item/ItemData")]
public class ItemSO : ScriptableObject
{

    [SerializeField] private Item item;

    //��� ������ ��������Ʈ�� �Ǻ�
    [field:SerializeField] public List<Vector2Int> itemSizes { get; private set; } = new();

    public Item MakeItem()
    {

        Item copy = new Item
        {

            attackPower = item.attackPower,
            attackSpeed = item.attackSpeed,
            so = Instantiate(item.so),
            type = item.type,
            guid = Guid.NewGuid(),

        };

        return copy;

    }
}
