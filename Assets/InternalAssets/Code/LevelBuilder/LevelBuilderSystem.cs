using System.Linq;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class LevelBuilderSystem : MonoBehaviour
{
    [SerializeField] private GameplayData gameplayData;
    [SerializeField] private Transform _canvasRoot;
    

    private void Start()
    {
        BuildProcces();
    }

    public void BuildProcces()
    {
        Transform gameRoot = CreateEmpty("GameSystems", _canvasRoot).transform;
        Transform menuControllersRoot = CreateEmpty("ControllersRoot", gameRoot).transform;
        MenuController mainController = CreateMenuController("MainController", menuControllersRoot);


        MenuPagePrefab menuPage = Resources.Load<MenuPagePrefab>(gameplayData._menuPrefabPath);
        Instantiate(menuPage, _canvasRoot);
        mainController.AddNewTab(menuPage.SelfTab);

        //TODO: SWAP TO FACTORY
        PagePrefab DefaultPage = Resources.Load<PagePrefab>(gameplayData._fullPagePrefabPath);

        foreach (var group in gameplayData._group)
        {
            Transform GroupRoot = CreateEmpty(group.GroupName, gameRoot).transform;
            MenuController groupController = GroupRoot.AddComponent<MenuController>();

            
            foreach (var page in group.anectodePageDatas)
            {

                PagePrefab instance = Instantiate(DefaultPage, GroupRoot);
                instance.gameObject.SetActive(false);

                groupController.AddNewTab(instance.SelfTab);
            }

            menuPage.AddButton(groupController);
        }
    }

    public GameObject CreateEmpty(string name)
    {
        return new GameObject(name);
    }

    public GameObject CreateEmpty(string name, Transform root)
    {
        GameObject obj = new GameObject(name);
        obj.transform.parent = root;
        return obj;
    }


    public MenuController CreateMenuController(string name, Transform root)
    {
        return CreateEmpty(name, root).AddComponent<MenuController>();
    }
}
