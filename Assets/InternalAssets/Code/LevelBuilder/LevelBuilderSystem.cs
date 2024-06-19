using System.Linq;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class LevelBuilderSystem : MonoBehaviour
{
    [SerializeField] private GameplayData gameplayData;
    [SerializeField] private Transform _canvasRoot;
    [SerializeField] private GameObject _emptyObject;

    private void Start()
    {
        BuildProcces();
    }

    public void BuildProcces()
    {
        PagePrefabFactory prefabFactory = new PagePrefabFactory(gameplayData);

        Transform gameRoot = CreateEmpty("GameSystems", _canvasRoot).transform;
        Transform menuControllersRoot = CreateEmpty("ControllersRoot", gameRoot).transform;
        MenuController mainController = CreateMenuController("MainController", menuControllersRoot);


        MenuPagePrefab menuPageLoad = Resources.Load<MenuPagePrefab>(gameplayData._menuPrefabPath);
        MenuPagePrefab menuPage = Instantiate(menuPageLoad, _canvasRoot);
        mainController.AddNewTab(menuPage.SelfTab);


        foreach (var group in gameplayData._group)
        {
            Transform GroupRoot = CreateEmpty(group.GroupName, _canvasRoot).transform;
            MenuController groupController = GroupRoot.AddComponent<MenuController>();

            
            foreach (var pageData in group.anectodePageDatas)
            {

                PagePrefab newPagePrefab = prefabFactory.CreatePage(pageData, out GameObject instance);
                Instantiate(newPagePrefab.transform.parent, _canvasRoot);
                instance.gameObject.SetActive(false);

                groupController.AddNewTab(newPagePrefab.SelfTab);
            }

            menuPage.AddButton(groupController);
            CreateEmpty(" ", _canvasRoot);
        }
    }

    public GameObject CreateEmpty(string name)
    {
        GameObject obj = Instantiate(_emptyObject);
        obj.name = name;
        return obj;
    }

    public GameObject CreateEmpty(string name, Transform root)
    {
        GameObject obj = Instantiate(_emptyObject);
        obj.name = name;
        obj.transform.SetParent(root);
        return obj;
    }


    public MenuController CreateMenuController(string name, Transform root)
    {
        return CreateEmpty(name, root).AddComponent<MenuController>();
    }
}
