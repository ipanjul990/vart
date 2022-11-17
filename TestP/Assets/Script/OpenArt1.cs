using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenArt1 : MonoBehaviour
{
 
  public GameObject canvas;
    void PointerClickUp()
    {
      canvas.SetActive(true);
    }
}
