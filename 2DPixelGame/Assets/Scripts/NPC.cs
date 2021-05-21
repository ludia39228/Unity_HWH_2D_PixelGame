using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("商店介面")]
    public GameObject objShop;

    /// <summary>
    /// 玩家選取的武器
    /// 0 短刀
    /// 1戰斧
    /// 2匕首
    ///</summary>
    public int indexWeapon;

    /// <summary>
    /// 開啟商店介面
    /// </summary>

    public void OpenShop()
    {
        objShop.SetActive(true);
    }

    /// <summary>
    /// 關閉商店介面
    /// </summary>

    public void CloseShop()
    {
        objShop.SetActive(false);
    }


    /// <summary>
    /// 玩家選了哪一個武器
    /// </summary>
    /// 武器編號

    public void ChooseWeapon(int choose)
    {
        indexWeapon = choose;
    }


}
