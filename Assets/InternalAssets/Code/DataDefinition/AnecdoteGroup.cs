using System;
using UnityEngine;

[Serializable]
public class AnecdoteGroup
{
    [Tooltip("���������� ������������� ��������� ��������� ��� ���������� ������")]
    public string GroupName;

    [Tooltip("��� ���������� ��������� � ���������")]
    public AnectodePageData[] anectodePageDatas;
}
