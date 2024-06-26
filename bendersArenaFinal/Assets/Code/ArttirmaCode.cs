using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArttirmaCode : MonoBehaviour
{
    [SerializeField] private Text txtDisplayNumber2;
    [SerializeField] private Text txtDisplayNumber3;
    [SerializeField] private Text txtDisplayNumber4;
    [SerializeField] private Text txtDisplayNumber5;
    [SerializeField] private Text txtDisplayNumber6;
    [SerializeField] private Text txtDisplayNumber7;
    [SerializeField] private Text txtDisplayNumber8;

    private int counter3 = 0;
    private int counter4 = 0;
    private int counter5 = 0;
    private int counter6 = 0;
    private int counter7 = 0;
    private int counter8 = 0;
    private int counter9 = 0;
    private int MaxValue = 7; // Artırma ve azaltma sınırları

    void Start()
    {
        LoadCounters(); // Kaydedilen değerleri yükle
        DisplayTheNumbers();
    }

    public void IncreaseAndDisplay2()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter3);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay3()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter4);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay4()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter5);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay5()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter6);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay6()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter7);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay7()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter8);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay8()
    {
        if (MaxValue > 0)
        {
            IncreaseTheValueBy1(ref counter9);
            MaxValue--;
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    private void IncreaseTheValueBy1(ref int value)
    {
        value++;
    }

    private void DisplayTheNumbers()
    {
        txtDisplayNumber2.text = counter3.ToString();
        txtDisplayNumber3.text = counter4.ToString();
        txtDisplayNumber4.text = counter5.ToString();
        txtDisplayNumber5.text = counter6.ToString();
        txtDisplayNumber6.text = counter7.ToString();
        txtDisplayNumber7.text = counter8.ToString();
        txtDisplayNumber8.text = counter9.ToString();
    }

    private void SaveCounters()
    {
        PlayerPrefs.SetInt("Counter3", counter3);
        PlayerPrefs.SetInt("Counter4", counter4);
        PlayerPrefs.SetInt("Counter5", counter5);
        PlayerPrefs.SetInt("Counter6", counter6);
        PlayerPrefs.SetInt("Counter7", counter7);
        PlayerPrefs.SetInt("Counter8", counter8);
        PlayerPrefs.SetInt("Counter9", counter9);
        PlayerPrefs.SetInt("MaxValue", MaxValue);
        PlayerPrefs.Save();
    }

    private void LoadCounters()
    {
        counter3 = PlayerPrefs.GetInt("Counter3", 0);
        counter4 = PlayerPrefs.GetInt("Counter4", 0);
        counter5 = PlayerPrefs.GetInt("Counter5", 0);
        counter6 = PlayerPrefs.GetInt("Counter6", 0);
        counter7 = PlayerPrefs.GetInt("Counter7", 0);
        counter8 = PlayerPrefs.GetInt("Counter8", 0);
        counter9 = PlayerPrefs.GetInt("Counter9", 0);
        MaxValue = PlayerPrefs.GetInt("MaxValue", 7);
    }

    public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
        counter3 = 0;
        counter4 = 0;
        counter5 = 0;
        counter6 = 0;
        counter7 = 0;
        counter8 = 0;
        counter9 = 0;
        MaxValue = 7;
        DisplayTheNumbers();
    }
}
