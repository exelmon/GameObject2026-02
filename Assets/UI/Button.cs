using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Skill;
    public GameObject Rank;
    public void ActiveInventory()
    {
        if (Inventory != null)
        {
            // 현재 상태의 반대(! 상태)로 설정
            Inventory.SetActive(!Inventory.activeSelf);
        }
    }
    public void ActiveSkill()
    {
        if (Skill != null)
        {
            // 현재 상태의 반대(! 상태)로 설정
            Skill.SetActive(!Skill.activeSelf);
        }
    }
    public void ActiveRank()
    {
        if (Rank != null)
        {
            // 현재 상태의 반대(! 상태)로 설정
            Rank.SetActive(!Rank.activeSelf);
        }
    }
}

