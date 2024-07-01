using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cosaQueQuieroSegiuir;


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cosaQueQuieroSegiuir.transform.position + new Vector3(0, 0, 0);
    }
}
