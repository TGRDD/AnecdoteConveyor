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
        Transform menuControllersRoot = CreateEmpty("ControllersRoot").transform;
        MenuController mainController = CreateMenuController("MainController", menuControllersRoot);

        MenuPagePrefab menuPage = Resources.Load<MenuPagePrefab>(gameplayData._menuPrefabPath);
        Instantiate(menuPage, _canvasRoot);
    }

    public GameObject CreateEmpty(string name)
    {
        return Instantiate(new GameObject(name), null);
    }

    public MenuController CreateMenuController(string name, Transform root)
    {
        return Instantiate(new GameObject(name), root).AddComponent<MenuController>();
    }
}
