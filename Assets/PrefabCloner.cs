using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{
    public GameObject prefab;
    public Text InputCloneAmount;
    public Text displayClonesLeft;
    public InputField IField;
    public int counter;


    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "";
    }

    void Update()
    {

    }

    public void ClonePrefab()
    {
        if (InputCloneAmount.text != "")

            IField.readOnly = true;
        int cloneAmount = int.Parse(InputCloneAmount.text);

        if (counter < cloneAmount)
        {
            Instantiate(prefab);
            counter++;
            displayClonesLeft.text = (cloneAmount - counter).ToString();
        }
        else
        {
            displayClonesLeft.text = "No hay más";
        }
      

        else
        {
            displayClonesLeft.text = "ERROR. Ingrese un valor";
        }
     
    }
}
