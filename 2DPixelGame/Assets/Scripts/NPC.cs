using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("商店介面")]
    public GameObject objShop;

    /// <summary>
    /// 玩家選取的武器
    /// 0 短刀 1元
    /// 1戰斧  3元
    /// 2匕首  3元
    ///</summary>
    public int indexWeapon;

    /// <summary>
    /// 武器的價格、編號與選取武器相同
    /// </summary>
    private int[] priceWeapon = { 1, 2, 3 };

    private Player player;

    private void Start()
    {
        player = GameObject.Find("人物").GetComponent<Player>();
    }

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
    /// <summary>
    /// 購買武器
    /// 判斷玩家金幣是否足夠
    /// 購買後扣除金幣更新介面並顯示武器
    /// </summary>
    public void Buy()
    {
        if(player.coin >= priceWeapon[indexWeapon])
        {
            player.coin -= priceWeapon[indexWeapon];
            player.textCoin.text = "金幣:" + player.coin;
        }
    }

}
