using TMPro;
using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public GameObject tank,fuel;
    public TextMeshProUGUI tankPosition,fuelPositionText;

    public ObjectManager fuelPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tankPosition.text = tank.transform.position + "";
        fuelPosition = fuel.GetComponent<ObjectManager>();
        fuelPositionText.text = fuelPosition.objPosition + "";

    }
}
