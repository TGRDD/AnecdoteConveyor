using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PagePrefab : Page
{
    [SerializeField] private TextMeshProUGUI _textFill;
    [SerializeField] private Image _backGroundImage;
    [SerializeField] private Image _anecdoteImage;

    [SerializeField] private Button nextPageButton;
    [SerializeField] private Button previousPageButton;

    public TextMeshProUGUI TextFill => _textFill;
    public Image BackGroundImage => _backGroundImage;
    public Image AnecdoteImage => _anecdoteImage;



    public PagePrefab FillWithText(string Text)
    {
        _textFill.text = Text;
        return this;
    }

    public PagePrefab SetBackGroundSprite(Sprite BackGroundImage)
    {
        _backGroundImage.sprite = BackGroundImage;
        return this;
    }

    public PagePrefab SetAnectodeImageSprite(Sprite AnectodeImage)
    {
        _anecdoteImage.sprite = AnectodeImage;
        return this;
    }

    public PagePrefab InitNextPageButton(Sprite sprite, UnityAction call)
    {
        nextPageButton.image.sprite = sprite;
        nextPageButton.onClick.AddListener(call);
        return this;
    }

    public PagePrefab InitPreviousPageButton(Sprite sprite, UnityAction call)
    {
        previousPageButton.image.sprite = sprite;
        previousPageButton.onClick.AddListener(call);
        return this;
    }
}
