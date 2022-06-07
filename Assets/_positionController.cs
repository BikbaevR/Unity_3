using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _positionController : MonoBehaviour
{

  //объявляем необходимые переменные
  bool move = false;
  Vector3 startPosition;
  Vector3 needPosition;
  float speed = 0.01f;
  float offset = 0;
  Quaternion startRotation;
  Quaternion needRotaton;

  public Camera mainCamera;




  public void MoveAparat()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-0.23f, 4f, 2.61f);
      needRotaton = Quaternion.AngleAxis(180f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }

  public void MoveSvet()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(1.2f, 3.83f, 0.56f);
      needRotaton = Quaternion.AngleAxis(180f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }
  public void MovePriemnik()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-1.73f, 3.83f, 0.56f);
      needRotaton = Quaternion.AngleAxis(180f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }
  public void MovePitLamp()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(2.36f, 2.67f, 0.56f);
      needRotaton = Quaternion.AngleAxis(180f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }
  public void MoveBlocPit()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-0.32f, 2.94f, -5.06f);
      needRotaton = Quaternion.AngleAxis(0f, new Vector3(0, 0, 0));
      //позиция и угол поворота для камеры
    }

  }
  public void MovePlenki()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(0.05f, 3.83f, 0.56f);
      needRotaton = Quaternion.AngleAxis(180f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }
  public void MoveAmper()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-4.71f, 3.14f, -1.68f);
      needRotaton = Quaternion.AngleAxis(90, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }
  public void MovePlanshet()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-2.55f, 2.74f, 0.26f);
      needRotaton = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }

  // Update is called once per frame
  void Update()
  {
    //Проверяем позицию камеры в реальном времени
    startRotation = mainCamera.transform.rotation;
    startPosition = mainCamera.transform.position;

    if (move)//если нажата кнопка перемещения камеры
    {
      offset += speed;//данная конструкция увеливает скорость передвижения по времени
      mainCamera.transform.position = Vector3.Lerp(startPosition, needPosition, offset); //плавно изменяем позицию
      mainCamera.transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);//плавно измеяем угол поворота

      if (offset >= 1)
      {
        move = false;
        offset = 0;
      }



    }

    //Debug.Log(mainCamera.transform.position);
  }


}
