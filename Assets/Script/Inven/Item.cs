using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{

    Gray = 0,
    Red,
    Green,
    Blue,
    Yellow,

}

[System.Serializable]
public struct Item
{

    public int attackPower;
    public int attackSpeed;
    public ItemType type;
    public ItemEffectSO so;
    [HideInInspector] public Guid guid;
    //�̿� ��¼����¼�� ���� ����

}
