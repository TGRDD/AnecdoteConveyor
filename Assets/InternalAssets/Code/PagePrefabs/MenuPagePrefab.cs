using UnityEngine;
using UnityEngine.UI;

public class MenuPagePrefab : Page
{
    [SerializeField] private Button _categoryButtonPrefab;
    [SerializeField] private Transform _categoryButtonRoot;

    public void AddButton(MenuController controller)
    {
        Button obj = Instantiate(_categoryButtonPrefab);
        obj.transform.SetParent(_categoryButtonRoot);
        obj.onClick.AddListener(controller.OpenFirstTab);
    }
}
