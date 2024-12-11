using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;
using System.Xml.Linq;

public class GameplayManager: MonoBehaviour { 
    private LineRenderer line;
    private Vector3 previousPosition;
    private GameObject currentLineObject;
    private int currentSortingOrder = 1;
    [SerializeField]
    private float lineWidth;
    [SerializeField] 
    private Slider lineWidthSlider;
    [SerializeField]
    private float minDistance = 0.1f;
    public Dictionary<string, Color32> colorDictionary;
    private Color32 selectedColor;

    private RectTransform crayon;
    [SerializeField]
    private GameObject object1, object2, object3, object4, object5, object6, object7, object8, object9, object10;

    private int _drawObject;



    private void Start()
    { 
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        lineWidth = 0.1f;
        lineWidthSlider.minValue = 0f;
        lineWidthSlider.maxValue = 1f;
        lineWidthSlider.value = 0.5f; // Default value
        lineWidth = 0.5f;
        previousPosition = transform.position;
        _drawObject = GameManager.Instance.Getdraw();

        colorDictionary = new Dictionary<string, Color32>
        {
            { "Merah", new Color32(255, 0, 0, 255) },             
            { "Hijau", new Color32(0, 255, 0, 255) },             
            { "Biru", new Color32(0, 0, 255, 255) },            
            { "Kuning", new Color32(255, 255, 0, 255) },
            { "Cyan", new Color32(0, 255, 255, 255) },       
            { "Magenta", new Color32(255, 0, 255, 255) },         
            { "Hitam", new Color32(0, 0, 0, 255) },                
            { "Putih", new Color32(255, 255, 255, 255) },          
            { "Abu-abu", new Color32(128, 128, 128, 255) },        
            { "Merah Muda", new Color32(255, 192, 203, 255) },     
            { "Oranye", new Color32(255, 165, 0, 255) },           
            { "Hijau Tua", new Color32(0, 128, 0, 255) },          
            { "Biru Tua", new Color32(0, 0, 128, 255) },           
            { "Coklat", new Color32(139, 69, 19, 255) },           
            { "Violet", new Color32(238, 130, 238, 255) },      
            { "Perak", new Color32(192, 192, 192, 255) },   
            { "Emas", new Color32(255, 215, 0, 255) },         
            { "Krem", new Color32(255, 253, 208, 255) },                    
            { "Lavender", new Color32(230, 230, 250, 255) },       
            { "Turquoise", new Color32(64, 224, 208, 255) },       
            { "Indigo", new Color32(75, 0, 130, 255) },           
            { "Coral", new Color32(255, 127, 80, 255) },        
            { "Salmon", new Color32(250, 128, 114, 255) },    
            { "Teal", new Color32(0, 128, 128, 255) },          
            { "Khaki", new Color32(240, 230, 140, 255) },       
            { "Peach", new Color32(255, 229, 180, 255) },        
            { "Mint", new Color32(189, 252, 201, 255) },       
            { "Tan", new Color32(210, 180, 140, 255) },          
            { "Plum", new Color32(221, 160, 221, 255) },          
            { "Maroon", new Color32(128, 0, 0, 255) },           
            { "Olive", new Color32(128, 128, 0, 255) }           
        };
        selectedColor = colorDictionary["Hitam"];
        SetDrawingObject();
    }

    public void SetDrawingObject()
    {
        switch (_drawObject)
        {
            case 1:
                object1.SetActive(true);
                break;
            case 2:
                object2.SetActive(true);
                break;
            case 3:
                object3.SetActive(true);
                break;
            case 4:
                object4.SetActive(true);
                break;
            case 5:
                object5.SetActive(true);
                break;
            case 6:
                object6.SetActive(true);
                break;
            case 7:
                object7.SetActive(true);
                break;
            case 8:
                object8.SetActive(true);
                break;
            case 9:
                object9.SetActive(true);
                break;
            case 10:
                object10.SetActive(true);
                break;

        }
    }
    private void Update()
    {
        ControlLine();
    }
    public void SetLineWidth(float value) {
        lineWidth = value;        
    }

    public void SetCrayon(RectTransform transform) {
        if (crayon != null)
        {
            crayon.pivot = new Vector2(crayon.pivot.x + .25f, crayon.pivot.y);
        }
        crayon = transform;
        crayon.pivot = new Vector2(crayon.pivot.x - .25f, crayon.pivot.y);
    }

    public void SetSelectedColor(string colorName)
    {
        switch (colorName)
        {
            case "Merah":
                selectedColor = colorDictionary["Merah"];
                break;
            case "Hijau":
                selectedColor = colorDictionary["Hijau"];
                break;
            case "Biru":
                selectedColor = colorDictionary["Biru"];
                break;
            case "Kuning":
                selectedColor = colorDictionary["Kuning"];
                break;
            case "Cyan":
                selectedColor = colorDictionary["Cyan"];
                break;
            case "Magenta":
                selectedColor = colorDictionary["Magenta"];
                break;
            case "Hitam":
                selectedColor = colorDictionary["Hitam"];
                Debug.Log("nigga");
                break;
            case "Putih":
                selectedColor = colorDictionary["Putih"];
                break;
            case "Abu-abu":
                selectedColor = colorDictionary["Abu-abu"];
                break;
            case "Merah Muda":
                selectedColor = colorDictionary["Merah Muda"];
                break;
            case "Oranye":
                selectedColor = colorDictionary["Oranye"];
                break;
            case "Hijau Tua":
                selectedColor = colorDictionary["Hijau Tua"];
                break;
            case "Biru Tua":
                selectedColor = colorDictionary["Biru Tua"];
                break;
            case "Coklat":
                selectedColor = colorDictionary["Coklat"];
                break;
            case "Violet":
                selectedColor = colorDictionary["Violet"];
                break;
            case "Perak":
                selectedColor = colorDictionary["Perak"];
                break;
            case "Emas":
                selectedColor = colorDictionary["Emas"];
                break;
            case "Krem":
                selectedColor = colorDictionary["Krem"];
                break;
            case "Lavender":
                selectedColor = colorDictionary["Lavender"];
                break;
            case "Turquoise":
                selectedColor = colorDictionary["Turquoise"];
                break;
            case "Indigo":
                selectedColor = colorDictionary["Indigo"];
                break;
            case "Coral":
                selectedColor = colorDictionary["Coral"];
                break;
            case "Salmon":
                selectedColor = colorDictionary["Salmon"];
                break;
            case "Teal":
                selectedColor = colorDictionary["Teal"];
                break;
            case "Khaki":
                selectedColor = colorDictionary["Khaki"];
                break;
            case "Peach":
                selectedColor = colorDictionary["Peach"];
                break;
            case "Mint":
                selectedColor = colorDictionary["Mint"];
                break;
            case "Tan":
                selectedColor = colorDictionary["Tan"];
                break;
            case "Plum":
                selectedColor = colorDictionary["Plum"];
                break;
            case "Maroon":
                selectedColor = colorDictionary["Maroon"];
                break;
            case "Olive":
                selectedColor = colorDictionary["Olive"];
                break;
            default:
                selectedColor = colorDictionary["Hitam"]; 
                break;
        }
    }

    public void ControlLine()
    {
        if (Input.GetMouseButtonDown(0))  // Saat mouse ditekan
        {
            CreateNewLine();  // Membuat objek LineRenderer baru setiap kali mouse ditekan
            Vector3 startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            startPosition.z = 0f;
            line.SetPosition(0, startPosition);
            previousPosition = startPosition;  // Simpan posisi awal
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;


            if (Vector3.Distance(currentPosition, previousPosition) > minDistance)
            {


                if (previousPosition == transform.position)
                {
                    line.SetPosition(0, currentPosition);
                }
                else
                {
                    line.positionCount++;
                    line.SetPosition(line.positionCount - 1, currentPosition);
                }
                previousPosition = currentPosition;
            }


        }
    }
    private void CreateNewLine()
    {
        
        currentLineObject = new GameObject("LineObject"); 
        line = currentLineObject.AddComponent<LineRenderer>();  
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.sortingOrder = currentSortingOrder;
        currentSortingOrder++;
        line.useWorldSpace = false;
        line.maskInteraction = SpriteMaskInteraction.VisibleOutsideMask;
        line.startWidth = lineWidth;  
        line.endWidth = lineWidth;   
        line.positionCount = 0;
        line.startColor = selectedColor;
        line.endColor = selectedColor;
        currentLineObject.transform.SetParent(transform);
    }
}

