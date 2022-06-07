using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _tablicaController : MonoBehaviour
{

  public InputField inputUser;//панель ввода
  public Button btnClick;//кнопка сохранения данных из панели ввода
  //Объявляем необходимые переменные
  public GameObject tablica;//Таблица
  public Text intensivnost1;
  public Text intensivnost2;
  public Text intensivnost3;
  public Text intensivnost4;
  public Text intensivnost5;

  ///////////////////////////
  public Text ugol1;
  public Text ugol2;
  public Text ugol3;
  public Text ugol4;
  public Text ugol5;
  ////////////////////
  public Text max1;
  public Text max2;
  public Text max3;
  public Text max4;
  public Text max5;
  ///////////////////
  public Text min1;
  public Text min2;
  public Text min3;
  public Text min4;
  public Text min5;

  // Use this for initialization
  void Start()
  {
    //Создаем обработчик для кнопки, который прослушивает нажатия кнопки
    btnClick.onClick.AddListener(ReadStringInput);


    tablica.gameObject.SetActive(false);//таблица по умолчанию закрыта
    //Поумолчанию данных в таблице нет, вместо них выставляем прочерки
    intensivnost1.text = "-";
    intensivnost2.text = "-";
    intensivnost3.text = "-";
    intensivnost4.text = "-";
    intensivnost5.text = "-";
    /////////////////////////
    ugol1.text = "-";
    ugol2.text = "-";
    ugol3.text = "-";
    ugol4.text = "-";
    ugol5.text = "-";
    /////////////////
    max1.text = "-";
    max2.text = "-";
    max3.text = "-";
    max4.text = "-";
    max5.text = "-";
    /////////////////
    min1.text = "-";
    min2.text = "-";
    min3.text = "-";
    min4.text = "-";
    min5.text = "-";
  }


  //Заполняем таблицу данными полученными из панели ввода
  public void ReadStringInput()
  {
    if (intensivnost1.text == "-")
    {
      intensivnost1.text = inputUser.text.ToString();
    }
    else if (ugol1.text == "-")
    {
      ugol1.text = inputUser.text.ToString();
    }
    else if (max1.text == "-")
    {
      max1.text = inputUser.text.ToString();
    }
    else if (min1.text == "-")
    {
      min1.text = inputUser.text.ToString();
    }

    /////////////////////////////////////////
    else if (intensivnost2.text == "-")
    {
      intensivnost2.text = inputUser.text.ToString();
    }
    else if (ugol2.text == "-")
    {
      ugol2.text = inputUser.text.ToString();
    }
    else if (max2.text == "-")
    {
      max2.text = inputUser.text.ToString();
    }
    else if (min2.text == "-")
    {
      min2.text = inputUser.text.ToString();
    }

    /////////////////////////////////////////
    else if (intensivnost3.text == "-")
    {
      intensivnost3.text = inputUser.text.ToString();
    }
    else if (ugol3.text == "-")
    {
      ugol3.text = inputUser.text.ToString();
    }
    else if (max3.text == "-")
    {
      max3.text = inputUser.text.ToString();
    }
    else if (min3.text == "-")
    {
      min3.text = inputUser.text.ToString();
    }

    /////////////////////////////////////////
    else if (intensivnost4.text == "-")
    {
      intensivnost4.text = inputUser.text.ToString();
    }
    else if (ugol4.text == "-")
    {
      ugol4.text = inputUser.text.ToString();
    }
    else if (max4.text == "-")
    {
      max4.text = inputUser.text.ToString();
    }
    else if (min4.text == "-")
    {
      min4.text = inputUser.text.ToString();
    }

    ////////////////////////////////////////
    else if (intensivnost5.text == "-")
    {
      intensivnost5.text = inputUser.text.ToString();
    }
    else if (ugol5.text == "-")
    {
      ugol5.text = inputUser.text.ToString();
    }
    else if (max5.text == "-")
    {
      max5.text = inputUser.text.ToString();
    }
    else if (min5.text == "-")
    {
      min5.text = inputUser.text.ToString();
    }
  }



  public void openTablica()
  {
    tablica.gameObject.SetActive(true);
    //функция открывающая таблицу
  }
  public void closeTablica()
  {
    tablica.gameObject.SetActive(false);
    //функция закрывающая таблицу
  }
}
