using UnityEngine;

[CreateAssetMenu(fileName = "NewGameplayData", menuName = "GameData")]
public class GameplayData : ScriptableObject
{
    public string _menuPrefabPath;
    public string _fullPagePrefabPath;
    public string _pageWithoutTextPrefabPath;
    public string _pageWithoutImagePrefabPath;

    [Header("Groups")]
    public AnecdoteGroup[] _group;
}
