using System;
using UnityEngine;

[Serializable]
public class AnecdoteGroup
{
    [Tooltip("Уникальный идентификатор категории анекдотов для сохранения данных")]
    public string GroupName;

    [Tooltip("Все экземпляры анекдотов в категории")]
    public AnectodePageData[] anectodePageDatas;
}
