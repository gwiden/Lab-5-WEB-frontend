using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class rect_Mngr : MonoBehaviour
{
    public Camera Cam; //������� ������, �� ������� ����� ������ "Cheker.cs"

    void OnMouseEnter() // ����� ����������� ����� ������ ��������� �� �����
    {
        if (gameObject.transform.name == "rect 1") { Cam.GetComponent<Cheker>().null_check(1); } // �������, � ����������� �� ���� 
        if (gameObject.transform.name == "rect 2") { Cam.GetComponent<Cheker>().null_check(2); } // �� ����� ���� ������� ������,
        if (gameObject.transform.name == "rect 3") { Cam.GetComponent<Cheker>().null_check(3); } // �������� � ����� "null_check",
        if (gameObject.transform.name == "rect 4") { Cam.GetComponent<Cheker>().null_check(4); } // ����������� � ������� "Cheker.cs"
        if (gameObject.transform.name == "rect 5") { Cam.GetComponent<Cheker>().null_check(5); } // ������� ����� �� ������� ������,
        if (gameObject.transform.name == "rect 6") { Cam.GetComponent<Cheker>().null_check(6); } // � �������� ���������, ����� �����
        if (gameObject.transform.name == "rect 7") { Cam.GetComponent<Cheker>().null_check(7); }
        if (gameObject.transform.name == "rect 8") { Cam.GetComponent<Cheker>().null_check(8); }
        if (gameObject.transform.name == "rect 9") { Cam.GetComponent<Cheker>().null_check(9); }
        if (gameObject.transform.name == "rect 10") { Cam.GetComponent<Cheker>().null_check(10); }
        if (gameObject.transform.name == "rect 11") { Cam.GetComponent<Cheker>().null_check(11); }
        if (gameObject.transform.name == "rect 12") { Cam.GetComponent<Cheker>().null_check(12); }
        if (gameObject.transform.name == "rect 13") { Cam.GetComponent<Cheker>().null_check(13); } 
    }
    void OnMouseDown() // ����� ����������� ����� ������ ������� �� ����
    {
        if ((gameObject.transform.name == "rect 1") && Cam.GetComponent<Cheker>().rect1) { ConsoleWrite(); } // �������, � ����������� �� ���� 
        if ((gameObject.transform.name == "rect 2") && Cam.GetComponent<Cheker>().rect2) { ConsoleWrite(); } // �� ����� ���� ��������,
        if ((gameObject.transform.name == "rect 3") && Cam.GetComponent<Cheker>().rect3) { ConsoleWrite(); } // ������ ������ ��������
        if ((gameObject.transform.name == "rect 4") && Cam.GetComponent<Cheker>().rect4) { ConsoleWrite(); } // � ������ ������� ���������
        if ((gameObject.transform.name == "rect 5") && Cam.GetComponent<Cheker>().rect5) { ConsoleWrite(); } // ����������� � ������� "Cheker.cs"
        if ((gameObject.transform.name == "rect 6") && Cam.GetComponent<Cheker>().rect6) { ConsoleWrite(); } // ������� ����� �� ������� ������
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
