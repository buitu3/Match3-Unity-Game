using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_ONE;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_ONE;
                break;
            case eNormalType.TYPE_TWO:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_TWO;
                break;
            case eNormalType.TYPE_THREE:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_THREE;
                break;
            case eNormalType.TYPE_FOUR:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_FOUR;
                break;
            case eNormalType.TYPE_FIVE:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_FIVE;
                break;
            case eNormalType.TYPE_SIX:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_SIX;
                break;
            case eNormalType.TYPE_SEVEN:
                //prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
                prefabname = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_SEVEN;
                break;
        }

        return prefabname;
    }

    protected override Sprite GetPRefabSprite()
    {
        Sprite prefabSprite = null;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_ONE_Sprite;
                break;
            case eNormalType.TYPE_TWO:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_TWO_Sprite;
                break;
            case eNormalType.TYPE_THREE:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_THREE_Sprite;
                break;
            case eNormalType.TYPE_FOUR:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_FOUR_Sprite;
                break;
            case eNormalType.TYPE_FIVE:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_FIVE_Sprite;
                break;
            case eNormalType.TYPE_SIX:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_SIX_Sprite;
                break;
            case eNormalType.TYPE_SEVEN:
                prefabSprite = GameManager.m_cellSettings.PREFAB_NORMAL_TYPE_SEVEN_Sprite;
                break;
        }

        return prefabSprite;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
