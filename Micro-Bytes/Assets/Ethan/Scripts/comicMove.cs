using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class comicMove : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public Vector3 offsetComic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            transform.position = Vector2.Lerp(transform.position, mousePosition + offsetComic, moveSpeed);
        }
        this.GetComponent<RectTransform>().sizeDelta += new Vector2(Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Mouse ScrollWheel")) * 1500;
    }
}
