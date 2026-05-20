using UnityEngine;
[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Card Data")]
public class CardData : ScriptableObject
{
    public string cardName;
    [TextArea] public string descriptionTemplate;
    public int power ; 
    public int cost;
    public Rarity rarity;
    public string type;
    public string level;
    public Sprite image;

    public string GetDescription()
    {
        return descriptionTemplate
        .Replace("{power}", power.ToString())
        .Replace("{cost}", cost.ToString())
        .Replace("{current_level}", level);
    }
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}