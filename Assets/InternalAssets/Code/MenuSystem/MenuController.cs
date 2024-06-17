using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static event Action OnNewTabOpened;

    [SerializeField] private List<MenuTab> _tabsList = new List<MenuTab>();

    public void OpenNewTab(string tabName)
    {
        OnNewTabOpened?.Invoke();

        _tabsList.FirstOrDefault(MenuTab => MenuTab.name == tabName).gameObject.SetActive(true);
    }

    public void OpenFirstTab()
    {
        if (_tabsList == null) throw new ArgumentNullException($"ERROR: {gameObject.name} current TabList is null");
        else if (_tabsList.Count == 0) throw new ArgumentNullException($"ERROR: {gameObject.name} current TabList is empty");
        OpenNewTab(_tabsList.First().name);
    }

    public void AddNewTab(MenuTab tab)
    {
        _tabsList.Add(tab);
    }
}
