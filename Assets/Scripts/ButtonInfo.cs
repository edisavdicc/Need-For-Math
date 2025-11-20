using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int itemID;
    public Text priceText;
    public GameObject shopManager;
    void Update()
    {
        priceText.text = "Pris: " + shopManager.GetComponent<ShopManager>().shopItems[2, itemID].ToString();
    }
}
