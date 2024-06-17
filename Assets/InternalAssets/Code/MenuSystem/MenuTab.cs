using UnityEngine;

public class MenuTab : MonoBehaviour
{
    public string TabName => gameObject.name;

    private void OnEnable()
    {
        MenuController.OnNewTabOpened += Deactivate;
    }

    private void OnDisable()
    {
        MenuController.OnNewTabOpened -= Deactivate;
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
