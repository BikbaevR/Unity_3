using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _lightController : MonoBehaviour
{
  //объявляем необходимые переменные
  public Light light1;
  public Light light_1;

  public GameObject shtuka1;
  public GameObject shtuka2;


  int intensity;
  public static int intensity1;

  bool f = false;
  Quaternion startRotation;
  Quaternion needRotaton;
  ////////////////////////////////////////////////////////////
  public GameObject ugol;
  string ugolText = "Угол поворота";
  public GameObject amper;
  string ampertext = "Микроампер (мкА)";
  double amp;
  public GameObject max;
  string maxText = "Максимально (мкА)";
  double temp = 0;
  public GameObject min;
  string minText = "Минимально (мкА)";
  double temp1 = 1;
  public GameObject intensivnostSveta;
  string intensivnost = "Интенсивность света";


  float speed = 0.01f;
  float offset = 0;
  float vel = 2.7f;
  int num = 10;

  // Use this for initialization
  void Start()
  {
    light1.enabled = false; //поумолчанию свет выключен
    light_1.enabled = false; //поумолчанию свет выключен


    needRotaton = Quaternion.AngleAxis(0f, new Vector3(1, 0, 0)); //присваиваем значение угла поворота при старте
    shtuka2.transform.Rotate(0, 0, 0); //присваиваем значение угла поворота при старте


  }

  // Update is called once per frame
  void Update()
  {
    amp = intensity1 * vel / num;
    ugol.GetComponent<TextMesh>().text = ugolText + ": " + shtuka2.transform.localEulerAngles.x.ToString("F0"); //вывод значения угла поворота на экран планшета
    amper.GetComponent<TextMesh>().text = ampertext + ": " + amp.ToString("F6"); //вывод значения микроамперметра на экран планшета
    max.GetComponent<TextMesh>().text = maxText + ": " + temp.ToString("F4"); //вывод максимального значения микроамперметра на экран планшета
    min.GetComponent<TextMesh>().text = minText + ": " + temp1.ToString("F4"); //вывод минимального значения микроамперметра на экран планшета
    intensivnostSveta.GetComponent<TextMesh>().text = intensivnost + ": " + intensity1; //вывод значения интенсивности света на экран планшета

    if (amp > temp) //поиск максимального значения полученного из микроамперметра
    {
      temp = amp;
    }

    if (shtuka2.transform.localEulerAngles.x != 0 & amp > 0) //поиск минимального значения полученного из микроамперметра
    {
      if (amp < temp1)
      {
        temp1 = amp;
      }
    }

    startRotation = transform.rotation; //получение угла поворота объекта в реальном времени

    light1.intensity = intensity1; //приравниване изменяемого значения яркости света к источнику света
    light_1.intensity = intensity; //приравниване изменяемого значения яркости света к источнику света

    //максимальные и минимальные пределы яркости испускаемого света
    if (intensity <= 0)
    {
      intensity = 0;
    }
    if (intensity >= 90)
    {
      intensity = 90;
    }
    if (intensity1 <= 0)
    {
      intensity1 = 0;
    }
    if (intensity1 >= 90)
    {
      intensity1 = 90;
    }



    if (shtuka2.transform.localEulerAngles.y >= 180 | shtuka2.transform.localEulerAngles.x > 90) //возвращение поляризационной пленки в ровное положение если ее угол больше чем 90
    {
      offset += speed;
      shtuka2.transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
      f = true;
      intensity = 90;
      intensity1 = 90;


    }
    //Debug.Log(shtuka2.transform.localEulerAngles.x + " " + intensity1);
  }


  public void LightOn() //функция включения света и присваивание ей интенсивности свечения
  {
    light1.enabled = true;
    light_1.enabled = true;
    intensity = 2;
    intensity1 = 2;
  }
  public void LightOff() //функция отклбчения света и присваивание ей интенсивности свечения
  {
    light1.enabled = false;
    light_1.enabled = false;
    intensity = 0;
    intensity1 = 0;
  }
  public void intesityPlus() //функция увеличения интенсивности света
  {
    intensity += 3;
    intensity1 += 3;
  }
  public void intesityMinus() //функиция уменьшения интенсивности света
  {
    intensity -= 3;
    intensity1 -= 3;
  }

  public void shtuka2RotatePlus() //функия поворота поляризационной пленки и одновременного уменьшения интенсивности света
  {
    shtuka2.transform.Rotate(+3, 0, 0);
    intensity1 -= 3;
  }
  public void shtuka2RotateMinus()
  {
    shtuka2.transform.Rotate(-3, 0, 0); //функия поворота поляризационной пленки и одновременного увеличения интенсивности света
    intensity1 += 3;

  }
  public void resetPlanshet() //функция обнуления результатов на экране планшета
  {
    temp = 0;
    temp1 = 1;
  }
}
