using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class rect_Mngr : MonoBehaviour
{
    public Camera Cam; //игровая камера, на которой весит скрипт "Cheker.cs"

    void OnMouseEnter() // метод срабатывает когда курсор находится на блоке
    {
        if (gameObject.transform.name == "rect 1") { Cam.GetComponent<Cheker>().null_check(1); } // условия, в зависимости от того 
        if (gameObject.transform.name == "rect 2") { Cam.GetComponent<Cheker>().null_check(2); } // на какой блок помещен скрипт,
        if (gameObject.transform.name == "rect 3") { Cam.GetComponent<Cheker>().null_check(3); } // передают в метод "null_check",
        if (gameObject.transform.name == "rect 4") { Cam.GetComponent<Cheker>().null_check(4); } // находящийся в скрипте "Cheker.cs"
        if (gameObject.transform.name == "rect 5") { Cam.GetComponent<Cheker>().null_check(5); } // который весит на игровой камере,
        if (gameObject.transform.name == "rect 6") { Cam.GetComponent<Cheker>().null_check(6); } // в качестве параметра, номер блока
        if (gameObject.transform.name == "rect 7") { Cam.GetComponent<Cheker>().null_check(7); }
        if (gameObject.transform.name == "rect 8") { Cam.GetComponent<Cheker>().null_check(8); }
        if (gameObject.transform.name == "rect 9") { Cam.GetComponent<Cheker>().null_check(9); }
        if (gameObject.transform.name == "rect 10") { Cam.GetComponent<Cheker>().null_check(10); }
        if (gameObject.transform.name == "rect 11") { Cam.GetComponent<Cheker>().null_check(11); }
        if (gameObject.transform.name == "rect 12") { Cam.GetComponent<Cheker>().null_check(12); }
        if (gameObject.transform.name == "rect 13") { Cam.GetComponent<Cheker>().null_check(13); } 
    }
    void OnMouseDown() // метод срабатывает когда курсор кликает на блок
    {
        if ((gameObject.transform.name == "rect 1") && Cam.GetComponent<Cheker>().rect1) { ConsoleWrite(); } // условия, в зависимости от того 
        if ((gameObject.transform.name == "rect 2") && Cam.GetComponent<Cheker>().rect2) { ConsoleWrite(); } // на какой блок нажимаем,
        if ((gameObject.transform.name == "rect 3") && Cam.GetComponent<Cheker>().rect3) { ConsoleWrite(); } // делает разные проверки
        if ((gameObject.transform.name == "rect 4") && Cam.GetComponent<Cheker>().rect4) { ConsoleWrite(); } // с разной булевой переменно
        if ((gameObject.transform.name == "rect 5") && Cam.GetComponent<Cheker>().rect5) { ConsoleWrite(); } // находящейся в скрипте "Cheker.cs"
        if ((gameObject.transform.name == "rect 6") && Cam.GetComponent<Cheker>().rect6) { ConsoleWrite(); } // который весит на игровой камере
        if ((gameObject.transform.name == "rect 7") && Cam.GetComponent<Cheker>().rect7) { ConsoleWrite(); }
        if ((gameObject.transform.name == "rect 8") && Cam.GetComponent<Cheker>().rect8) { ConsoleWrite(); }
        if ((gameObject.transform.name == "rect 9") && Cam.GetComponent<Cheker>().rect9) { ConsoleWrite(); }
        if ((gameObject.transform.name == "rect 10") && Cam.GetComponent<Cheker>().rect10) { ConsoleWrite(); }
        if ((gameObject.transform.name == "rect 11") && Cam.GetComponent<Cheker>().rect11) { ConsoleWrite(); }
        if ((gameObject.transform.name == "rect 12") && Cam.GetComponent<Cheker>().rect12) { ConsoleWrite(); }
        if ((gameObject.transform.name == "rect 13") && Cam.GetComponent<Cheker>().rect13) { ConsoleWrite(); }
    }
    void ConsoleWrite() {print(gameObject.transform.name); }
}
