using UnityEngine;

[RequireComponent (typeof(MenuTab))]
public class Page : MonoBehaviour
{
    private MenuTab _tab;
    public MenuTab SelfTab => _tab;

    private void OnValidate()
    {
        _tab = GetComponent<MenuTab>();
    }
}
