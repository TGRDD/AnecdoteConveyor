using System;
using UnityEngine;

[Serializable]
public class AnectodePageData
{
    [Tooltip("Уникальный идентификатор анекдота для сохранения данных")]
    public string SaveID;

    [Space(20f)]

    [Tooltip("Текст на странице анекдота")]
    public string AnecdoteText;

    [Tooltip("Изображение на странице анекдота")]
    public string AnecdoteSpriteName;
}
