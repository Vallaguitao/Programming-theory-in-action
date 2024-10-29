using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject tiger;
    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject chicken;
    public void TigerButton()
    {
        GameManager.Instance.Canvas.SetActive(false);
        tiger.SetActive(true);
    }
    public void CatButton()
    {
        GameManager.Instance.Canvas.SetActive(false);
        cat.SetActive(true);
    }
    public void ChickenButton()
    {
        GameManager.Instance.Canvas.SetActive(false);
        chicken.SetActive(true);
    }
}
