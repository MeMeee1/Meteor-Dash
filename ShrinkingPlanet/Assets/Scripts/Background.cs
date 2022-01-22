using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    #region Variables
    [SerializeField] Sprite[] sprites;
    [SerializeField] Image image;
    #endregion

    #region Unity Base Methods
    // Start is called before the first frame update
    void Start()
    {
        float f = Random.Range(0, sprites.Length);
        image.sprite = sprites[(int)f];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
