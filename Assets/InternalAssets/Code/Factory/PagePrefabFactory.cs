using UnityEngine;

public struct PagePrefabFactory
{
    private GameplayData _gameplayData;

    public PagePrefabFactory(GameplayData gameplayData)
    {
        _gameplayData = gameplayData;
    }

    public PagePrefab CreatePage(AnectodePageData data, out GameObject obj)
    { 

        if (data.AnecdoteText == null)
        {
            obj = (GameObject)Resources.Load(_gameplayData._pageWithoutImagePrefabPath);
            return convertToPagePrefab(obj);
        }
        else if (data.AnecdoteSpritePath == null)
        {
            obj = (GameObject)Resources.Load(_gameplayData._pageWithoutTextPrefabPath);
            return convertToPagePrefab(obj);
        }
        else
        {
            obj = (GameObject)Resources.Load(_gameplayData._fullPagePrefabPath);
            return convertToPagePrefab(obj);
        }
    }

    public PagePrefab convertToPagePrefab(GameObject obj)
    {
        return obj.GetComponentInChildren<PagePrefab>();
    }
}
