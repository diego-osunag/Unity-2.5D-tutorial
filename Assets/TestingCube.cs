using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
  public class TestingCube : MonoBehaviour
  {      
      void Update()
      {
        if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
        {
          return;
        }

        if (VirtualInputManager.Instance.MoveRight)
        {
          this.gameObject.transform.Translate(Vector3.forward * 10f * Time.deltaTime);
          this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (VirtualInputManager.Instance.MoveLeft)
        {
          this.gameObject.transform.Translate(Vector3.forward * 10f * Time.deltaTime);
          this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
      }
  }   
}