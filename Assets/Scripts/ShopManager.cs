using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    float coins;
    public Text coinsText;
    public GameObject MathPanel;
    public GameObject gamePanels;
    public GameObject EndScreen;
    public GameObject Store;
    public GameObject player;
    public GameObject newCar;
    public GameManager GameManager;
    public Transform storeScreen;
   

   

    public void StartStore()
    {
        MathPanel.gameObject.SetActive(false);
        gamePanels.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(false);
        Store.gameObject.SetActive(true);

        coinsText.transform.SetParent(storeScreen);
        coinsText.transform.position = new Vector3(1100, 865, 0);
        coinsText.color = Color.white;
    }


    

    void Start()
    {
        

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 5;
        shopItems[2, 2] = 10;
        shopItems[2, 3] = 20;
        shopItems[2, 4] = 25;
    }

    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     

    }
        
    
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        
        if(coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemID];
            coinsText.text = "Poäng:" + coins.ToString();
        }
    }
    
    
   
    
}
