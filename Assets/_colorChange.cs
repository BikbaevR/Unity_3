using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _colorChange : MonoBehaviour
{

  //Объявляем необходимые переменные
  public GameObject svet;
  public Material svetMat;
  public GameObject foto;
  public Material fotoMat;
  public GameObject blocLamp;
  public GameObject blocPit;
  public Material blocPitMat;
  public GameObject polarPlenk;
  public GameObject polarPlenk1;
  public GameObject polarPlenk2;
  public GameObject polarPlenk3;
  public GameObject amper;
  public GameObject planshet;
  public Material planshetMat;


  public void svetUp()
  {
    svet.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void svetOut()
  {
    svet.GetComponent<Renderer>().material = svetMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  public void fotoUp()
  {
    foto.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void fotoOut()
  {
    foto.GetComponent<Renderer>().material = svetMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }
  public void blocLampchUp()
  {
    blocLamp.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void blocLampchOut()
  {
    blocLamp.GetComponent<Renderer>().material = svetMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }
  public void blocPitUp()
  {
    blocPit.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void blocPitOut()
  {
    blocPit.GetComponent<Renderer>().material = blocPitMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }
  public void polPlenkUp()
  {
    polarPlenk.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    polarPlenk1.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    polarPlenk2.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    polarPlenk3.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void polPlenkOut()
  {
    polarPlenk.GetComponent<Renderer>().material = svetMat;
    polarPlenk1.GetComponent<Renderer>().material = svetMat;
    polarPlenk2.GetComponent<Renderer>().material = svetMat;
    polarPlenk3.GetComponent<Renderer>().material = svetMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }
  public void amperUp()
  {
    amper.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void amperOut()
  {
    amper.GetComponent<Renderer>().material = svetMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }
  public void planshetUp()
  {
    planshet.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку 
  }
  public void planshetOut()
  {
    planshet.GetComponent<Renderer>().material = planshetMat;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }
}
