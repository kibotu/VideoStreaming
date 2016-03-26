using UnityEngine;

namespace Assets.Scripts
{
  public class StreamLoader : MonoBehaviour
  {
    void Update()
    {
      if (Input.GetKey(KeyCode.Escape))
      {
        Application.LoadLevel(0);
      }
    }
  }
}