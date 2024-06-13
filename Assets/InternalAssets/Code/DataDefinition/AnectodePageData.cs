using System;
using UnityEngine;

[Serializable]
public class AnectodePageData
{
    [Tooltip("���������� ������������� �������� ��� ���������� ������")]
    public string SaveID;

    [Space(20f)]

    [Tooltip("����� �� �������� ��������")]
    public string AnecdoteText;

    [Tooltip("����������� �� �������� ��������")]
    public string AnecdoteSpriteName;
}
