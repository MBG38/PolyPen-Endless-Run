using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;

    [SerializeField] private line _lineprefab;

    public const float resolution = 0.1f;



    private line _currentline;
    
    void Start()
    {
        _cam = Camera.main;
        
    }

   
    void Update()
    {
        Vector2 mousepos = _cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) _currentline = Instantiate(_lineprefab, mousepos, Quaternion.identity);

        if (Input.GetMouseButton(0)) _currentline.SetPosition(mousepos);


        
    }
}
