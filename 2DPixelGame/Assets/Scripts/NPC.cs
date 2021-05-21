using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("商店介面")]
    public GameObject objShop;

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


}
