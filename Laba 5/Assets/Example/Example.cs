using System;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    static double resultExp;
    static int served = 0;
    static int notServed = 0;
    static double serviceTime;
    static double mainTime;
    static double p;
    static double r;
    static System.Random random = new System.Random();
    [SerializeField] InputField Input;
    [SerializeField] Button start;

    void Start()
    {
        Input.text = "0";
        Button btn = start;
        btn.onClick.AddListener(Main);

    }
    public static double RandomExp(double parametr)
    {
        double current = random.NextDouble();
        return resultExp = Math.Log(1 - current) * (1/(-parametr));

    }
    void Main()
    {
        var prohod = Int32.Parse(Input.text);
        if (prohod>0)
        {
            for (int counter = 0; counter < prohod; counter++)
            {
                p = 0;
                r = 0;
                for (mainTime = 0; mainTime < 720;) // 30 суток
                {
                    var R = RandomExp(4);
                    //Debug.Log("resultExp(4): " + R);
                    mainTime += R;
                    p = mainTime;
                    if (p >= r)
                    {
                        served++;
                        R = RandomExp(3);
                        //Debug.Log("resultExp(3): " + R);
                        serviceTime += R;
                        R = RandomExp(3);
                        //Debug.Log("resultExp(3): " + R);
                        r = p + R;
                        //r = p + RandomExp(3);

                    }
                    else
                    {
                        notServed++;
                    }
                }
                //Debug.Log("Обслужено машин: " + served);
                //Debug.Log("Не обслужено машин: " + notServed);
            }
            Debug.Log("Обслужено машин среднее: " + served / prohod);
            Debug.Log("Не обслужено машин среднее: " + notServed / prohod);
        }
        else
        {
            Debug.Log("Введите число");
        }

    }
}
