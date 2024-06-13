using UnityEngine;

[CreateAssetMenu(fileName = "NewGameplayData", menuName = "GameData")]
public class GameplayData : ScriptableObject
{
    public AnecdoteGroup[] _group;
}
