using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class check : MonoBehaviour
{
    public Material gray; //материал с оранжевым цветом
    public Material orange; //материал с серым цветом

    void OnMouseEnter() // метод срабатывает когда курсор находится на блоке
    {
        gameObject.GetComponent<Renderer>().material = orange; // применяем оранжевый материал на блок
    }
    void OnMouseExit() // метод срабатывает когда курсор перестает касаться блока
    {
        gameObject.GetComponent<Renderer>().material = gray; // применяем серый материал на блок
    }
    void OnMouseDown() // метод срабатывает когда курсор кликает на блок
    {
        print(gameObject.transform.name); //метод принт с параметрами в виде имени нашего блока
    }
}
