using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cheker : MonoBehaviour
{
    public GameObject rect_1;
    public GameObject rect_2;
    public GameObject rect_3;
    public GameObject rect_4;
    public GameObject rect_5;
    public GameObject rect_6;
    public GameObject rect_7; // все блоки представл€ют собой тип "игровой объект"
    public GameObject rect_8;
    public GameObject rect_9;
    public GameObject rect_10;
    public GameObject rect_11;
    public GameObject rect_12;
    public GameObject rect_13;
    public bool rect1 = false;
    public bool rect2 = false;
    public bool rect3 = false;
    public bool rect4 = false;
    public bool rect5 = false;
    public bool rect6 = false;
    public bool rect7 = false;  // булевые переменный участвующие в основной логике
    public bool rect8 = false;
    public bool rect9 = false;
    public bool rect10 = false;
    public bool rect11 = false;
    public bool rect12 = false;
    public bool rect13 = false;
    public Material orange;
    public Material gray;

    public void null_check(int num) //метод отвечающий за проверку первого соприкосновени€ курсора с любым блоком
    { //в метод передаетс€ номер блока с которым произошло соприкосновение курсора
        if (!rect1 && !rect2 && !rect3 && !rect4 && !rect5 && !rect6 && !rect7 && !rect8 && !rect9 && !rect10 && !rect11 && !rect12 && !rect13)
        { //если все "флажки" выключены значит курсор не касалс€ ни одного блока, тогда:
            if (num == 1) //если первое соприкосновение было с первым блоком тогда:
            {
                rect1 = true; // включаем флажок
                rect_1.GetComponent<Renderer>().material = orange; //и примен€ем оранжевый материал
            } //по такой же логике работают остальные блоки-услови€ метода
            if (num == 2)
            {
                rect2 = true;
                rect_2.GetComponent<Renderer>().material = orange;
            }
            if (num == 3)
            {
                rect3 = true;
                rect_3.GetComponent<Renderer>().material = orange;
            }
            if (num == 4)
            {
                rect4 = true;
                rect_4.GetComponent<Renderer>().material = orange;
            }
            if (num == 5)
            {
                rect5 = true;
                rect_5.GetComponent<Renderer>().material = orange;
            }
            if (num == 6)
            {
                rect6 = true;
                rect_6.GetComponent<Renderer>().material = orange;
            }
            if (num == 7)
            {
                rect7 = true;
                rect_7.GetComponent<Renderer>().material = orange;
            }
            if (num == 8)
            {
                rect8 = true;
                rect_8.GetComponent<Renderer>().material = orange;
            }
            if (num == 9)
            {
                rect9 = true;
                rect_9.GetComponent<Renderer>().material = orange;
            }
            if (num == 10)
            {
                rect10 = true;
                rect_10.GetComponent<Renderer>().material = orange;
            }
            if (num == 11)
            {
                rect11 = true;
                rect_11.GetComponent<Renderer>().material = orange;
            }
            if (num == 12)
            {
                rect12 = true;
                rect_12.GetComponent<Renderer>().material = orange;
            }
            if (num == 13)
            {
                rect13 = true;
                rect_13.GetComponent<Renderer>().material = orange;
            }
        } //если хот€бы один флажок включен, значит соприкосновение не первое,
        else { Check(num); } //тогда вызываем метод с главной логикой программы, а в качестве пораметра передает номер блока
    }

    void Check(int num)
    { 
        if (num == 1) //если тот блок на который мы перешли - блок под номером один, тогда:
        {
            if (rect4) // если флажок 4-го блока включен значит
            { //был совершен переход с блока номер 4, тогда:
                rect4 = false; //выключаем флажок номер 4 и
                rect_4.GetComponent<Renderer>().material = gray; //примен€ем к нему серый материал

                rect1 = true;  //включаем флажок номер 1 и
                rect_1.GetComponent<Renderer>().material = orange; //примен€ем к нему оранжевый материал
            }
        } //по такой же логике работают остальные блоки-услови€ метода
        if (num == 2)
        {
            if (rect1)
            {
                rect1 = false;
                rect_1.GetComponent<Renderer>().material = gray;

                rect2 = true;
                rect_2.GetComponent<Renderer>().material = orange;
            }
            else if (rect5)
            {
                rect5 = false;

                rect_5.GetComponent<Renderer>().material = gray;

                rect2 = true;
                rect_2.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 3)
        {
            if (rect2)
            {
                rect2 = false;
                rect_2.GetComponent<Renderer>().material = gray;

                rect3 = true;
                rect_3.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 4)
        {
            if (rect11)
            {
                rect11 = false;
                rect_11.GetComponent<Renderer>().material = gray;

                rect4 = true;
                rect_4.GetComponent<Renderer>().material = orange;
            }
            else if (rect1)
            {
                rect1 = false;
                rect_1.GetComponent<Renderer>().material = gray;

                rect4 = true;
                rect_4.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 5)
        {
            if (rect9)
            {
                rect9 = false;
                rect_9.GetComponent<Renderer>().material = gray;

                rect5 = true;
                rect_5.GetComponent<Renderer>().material = orange;
            }
            else if (rect2)
            {
                rect2 = false;
                rect_2.GetComponent<Renderer>().material = gray;

                rect5 = true;
                rect_5.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 6)
        {
            if (rect7)
            {
                rect7 = false;
                rect_7.GetComponent<Renderer>().material = gray;

                rect6 = true;
                rect_6.GetComponent<Renderer>().material = orange;
            }
            else if (rect5)
            {
                rect5 = false;
                rect_5.GetComponent<Renderer>().material = gray;

                rect6 = true;
                rect_6.GetComponent<Renderer>().material = orange;
            }
            else if (rect10)
            {
                rect10 = false;
                rect_10.GetComponent<Renderer>().material = gray;

                rect6 = true;
                rect_6.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 7)
        {
            if (rect3)
            {
                rect3 = false;
                rect_3.GetComponent<Renderer>().material = gray;

                rect7 = true;
                rect_7.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 8)
        {
            if (rect5)
            {
                rect5 = false;
                rect_5.GetComponent<Renderer>().material = gray;

                rect8 = true;
                rect_8.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 9)
        {
            if (rect13)
            {
                rect13 = false;
                rect_13.GetComponent<Renderer>().material = gray;

                rect9 = true;
                rect_9.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 10)
        {
            if (rect6)
            {
                rect6 = false;
                rect_6.GetComponent<Renderer>().material = gray;

                rect10 = true;
                rect_10.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 11)
        {
            if (rect12)
            {
                rect12 = false;
                rect_12.GetComponent<Renderer>().material = gray;

                rect11 = true;
                rect_11.GetComponent<Renderer>().material = orange;
            }
            else if (rect4)
            {
                rect4 = false;
                rect_4.GetComponent<Renderer>().material = gray;

                rect11 = true;
                rect_11.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 12)
        {
            if (rect8)
            {
                rect8 = false;
                rect_8.GetComponent<Renderer>().material = gray;

                rect12 = true;
                rect_12.GetComponent<Renderer>().material = orange;
            }
        }
        if (num == 13)
        {
            if (rect10)
            {
                rect10 = false;
                rect_10.GetComponent<Renderer>().material = gray;

                rect13 = true;
                rect_13.GetComponent<Renderer>().material = orange;
            }
            else if (rect9)
            {
                rect9 = false;
                rect_9.GetComponent<Renderer>().material = gray;

                rect13 = true;
                rect_13.GetComponent<Renderer>().material = orange;
            }
        }
    }
}
