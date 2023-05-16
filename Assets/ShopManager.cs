using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{   
    public GameObject first;
    public GameObject Main;
    public GameObject Shop;
    public GameObject StartManu;
    public GameObject MainManu;
    public GameObject ShopManu;

    public void OnClickBottonToStart()
    {
        StartManu.SetActive(false);
        first.SetActive(false);
        MainManu.SetActive(true);
        Main.SetActive(true);
    }

    public void OnClickBottonToOpenShop()
    {
        MainManu.SetActive(false);
        Main.SetActive(false);
        ShopManu.SetActive(true);
        Shop.SetActive(true);
    }

    public void OnClickBottonToExitShop()
    {
        ShopManu.SetActive(false);
        Shop.SetActive(false);
        MainManu.SetActive(true);
        Main.SetActive(true);
    }
}
