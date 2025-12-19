using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenUI : MonoBehaviour
{
    private GameObject _startPage;
    private GameObject _playPage;
    private GameObject _statsPage;
    private GameObject _shopPage;

    private void Start()
    {
        _startPage = GameObject.Find("StartPage");
        _playPage = GameObject.Find("PlayPage");
        _statsPage = GameObject.Find("StatsPage");
        _shopPage = GameObject.Find("ShopPage");

        ShowStartPage();
    }
    
    // Page Navigation Methods
    public void ShowStartPage()
    {
        _startPage.SetActive(true);
        _playPage.SetActive(false);
        _statsPage.SetActive(false);
        _shopPage.SetActive(false);
    }
    public void ShowPlayPage()
    {
        _startPage.SetActive(false);
        _playPage.SetActive(true);
        _statsPage.SetActive(false);
        _shopPage.SetActive(false);
    }
    public void ShowStatsPage()
    {
        _startPage.SetActive(false);
        _playPage.SetActive(false);
        _statsPage.SetActive(true);
        _shopPage.SetActive(false);
    }
    public void ShowShopPage()
    {
        _startPage.SetActive(false);
        _playPage.SetActive(false);
        _statsPage.SetActive(false);
        _shopPage.SetActive(true);
    }
    
    // Scene Loading Methods
    public void SoloStart()
    {
        SceneManager.LoadScene("Solo");
    }
    public void VersusStart()
    {
        SceneManager.LoadScene("Versus");
    }
    public void PartyStart()
    {
        SceneManager.LoadScene("Party");
    }
    public void CoopStart()
    {
        SceneManager.LoadScene("Co-op");
    }
    
}
