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

#if UNITY_EDITOR
    private void OnValidate()
    {
        foreach (var group in _group)
        {
            foreach( var item in group.anectodePageDatas)
            {
                if (item.AnecdoteSpritePath.ToCharArray().Length > 0 && item.AnecdoteSpritePath.ToCharArray().Length < 2)
                {
                    item.AnecdoteSpritePath = "Sprites/Name";
                }
            }
        }
    }
#endif
}
