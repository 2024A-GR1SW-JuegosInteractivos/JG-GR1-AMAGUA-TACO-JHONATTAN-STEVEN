using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamera : MonoBehaviour
{
    [SerializeField] private GameObject cosaQueQuieroSegiuir;
  

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position= cosaQueQuieroSegiuir.transform.position + new Vector3 (0,0,0);
    }
}
