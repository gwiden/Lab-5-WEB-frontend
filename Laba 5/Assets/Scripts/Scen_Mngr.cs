using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scen_Mngr : MonoBehaviour
{
    public Button maket; //кнопка отвечающая за переключение сцен
    public Button restart; //кнопка отвечающая за перезавпуск сцены

    private void Awake()
    {
        maket.onClick.AddListener(MaketLoader); //на кнопку помещен метод отвечающий за смену сцены
        restart.onClick.AddListener(Reload); //на кнопку помещен метод отвечающий за перезапуск
    }
    void MaketLoader() //метод отвечающий за смену сцены
    {
        if (SceneManager.GetActiveScene().name == "Maket 1") { SceneManager.LoadScene("Maket 2"); }
        else { SceneManager.LoadScene("Maket 1"); }
    }
    void Reload() //метод отвечающий за перезапуск
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
