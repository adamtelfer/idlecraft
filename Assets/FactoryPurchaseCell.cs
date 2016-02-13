using UnityEngine;
using System.Collections;
using Assets;
using TMPro;

public class FactoryPurchaseCell : MonoBehaviour {

    public Factory factoryToPurchase;

    public FactoryPurchasePopupView parentView;

    public TextMeshProUGUI name;
    public TextMeshProUGUI description;
    public TextMeshProUGUI cost;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetFactory ( Factory f )
    {
        factoryToPurchase = f;

        name.text = f.name;
        description.text = f.description;
        cost.text = f.factoryBuildCost.food.ToString();
    }

    public void OnClick()
    {
        parentView.PurchaseAndClose(factoryToPurchase);
    }
}
