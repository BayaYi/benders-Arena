using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter2Code : MonoBehaviour
{

    // Butona tıklanınca çalışacak fonksiyon
    public void TurnButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(10);
    }
}
