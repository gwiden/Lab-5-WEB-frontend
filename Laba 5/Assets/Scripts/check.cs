using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class check : MonoBehaviour
{
    public Material gray; //�������� � ��������� ������
    public Material orange; //�������� � ����� ������

    void OnMouseEnter() // ����� ����������� ����� ������ ��������� �� �����
    {
        gameObject.GetComponent<Renderer>().material = orange; // ��������� ��������� �������� �� ����
    }
    void OnMouseExit() // ����� ����������� ����� ������ ��������� �������� �����
    {
        gameObject.GetComponent<Renderer>().material = gray; // ��������� ����� �������� �� ����
    }
    void OnMouseDown() // ����� ����������� ����� ������ ������� �� ����
    {
        print(gameObject.transform.name); //����� ����� � ����������� � ���� ����� ������ �����
    }
}
