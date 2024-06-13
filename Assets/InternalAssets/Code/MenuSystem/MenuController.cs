using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private List<MenuTab> _tabsList = new List<MenuTab>();

    public void OpenNewTab(string tabName)
    {
        foreach (var tab in _tabsList)
        {
            tab.gameObject.SetActive(false);
        }

        _tabsList.FirstOrDefault(MenuTab => MenuTab.name == tabName).gameObject.SetActive(true);
    }
}
