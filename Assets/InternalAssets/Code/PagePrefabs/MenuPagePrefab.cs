using UnityEngine;
using UnityEngine.UI;

public class MenuPagePrefab : MonoBehaviour
{
    [SerializeField] private Button _categoryButtonPrefab;
    [SerializeField] private Transform _categoryButtonRoot;

    public void AddButton(MenuController controller)
    {
        Button obj = Instantiate(_categoryButtonPrefab, _categoryButtonRoot);
        obj.onClick.AddListener(controller.OpenFirstTab);
    }
}
