using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class _podskazkiController : MonoBehaviour
{

  //Объявляем необходимые переменные
  public GameObject panelPodskazok;
  public Text textPodskazok;


  bool svetActive = false;
  bool plus_minus = false;
  bool noll = false;
  bool closeTabl = false;

  // Use this for initialization
  void Start()
  {
    panelPodskazok.gameObject.SetActive(false);//поумолчанию окно закрыто
    textPodskazok.text = "";//поумолчанию подсказка пуста
  }

  // Update is called once per frame
  void Update()
  {
    textPodskazok.text = "1. Для начала опыта необходимо нажать на кнопку 'Включить свет'";
    if (svetActive)
    {
      textPodskazok.text = "2. Отлично! Далее кнопками '+' '-' вы должны выбрать интенсивность света, которую можно увидеть на экране по нажатию кнопки 'Экран с результатами'";
    }
    if (svetActive && plus_minus)
    {
      textPodskazok.text = "3. После того как вы выбрали интенсивность света, запишите это значание в таблицу, далее вам нужно начать поворачивать поляризационную пленку, для этого служат кнопки '+' '-' в блоке 'Поворот поляризационной пленки' до того момента как пункт 'Интенсивность света' не окажется нулевым";
    }
    if (svetActive && plus_minus && noll)
    {
      textPodskazok.text = "4. Пункт 'Интенсивность света' должен стать нулевым, как только он окажется нулевым, запишите значене 'Угол поворота' в таблицу";
    }
    if (svetActive && plus_minus && noll && _lightController.intensity1 == 0)
    {
      textPodskazok.text = "5. Отлично! Теперь обратите внимание на пункты 'Максимально (мкА)' и 'Минимально (мкА)', вам нужно записать эти значание в таблицу, порядок таков - сначала 'Максимально (мкА)', затем 'Минимально (мкА)'. Для того что бы посмотреть результаты нажмите на кнопку 'Таблица'";
    }
    if (svetActive && plus_minus && noll && _lightController.intensity1 == 0 && closeTabl)
    {
      textPodskazok.text = "6. Теперь вы можете нажать на кнопку 'Отключить свет' и 'Обнулить значения' для того что бы начать все заново.";
    }
  }

  public void podskazkiOpen()
  {
    panelPodskazok.gameObject.SetActive(true);
    //открываем подсказку
  }
  public void podskazkiClose()
  {
    panelPodskazok.gameObject.SetActive(false);
    //закрываем подсказку
  }
  public void svetActiveBtn()
  {
    svetActive = true;
    //включаем свет
  }
  public void plus_minusBtn()
  {
    plus_minus = true;
    //нажали на кнопку "+, -"
  }
  public void nollBtn()
  {
    noll = true;
    //если интенсивность изменяем интенсивность света
  }
  public void closeTablBtn()
  {
    closeTabl = true;
    //закрыть таблицу
  }
  public void reset()
  {
    {
      svetActive = false;
      plus_minus = false;
      noll = false;
      //обнуление подсказок
    }
  }
}
