using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scen_Mngr : MonoBehaviour
{
    public Button maket; //������ ���������� �� ������������ ����
    public Button restart; //������ ���������� �� ����������� �����

    private void Awake()
    {
        maket.onClick.AddListener(MaketLoader); //�� ������ ������� ����� ���������� �� ����� �����
        restart.onClick.AddListener(Reload); //�� ������ ������� ����� ���������� �� ����������
    }
    void MaketLoader() //����� ���������� �� ����� �����
    {
        if (SceneManager.GetActiveScene().name == "Maket 1") { SceneManager.LoadScene("Maket 2"); }
        else { SceneManager.LoadScene("Maket 1"); }
    }
    void Reload() //����� ���������� �� ����������
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
