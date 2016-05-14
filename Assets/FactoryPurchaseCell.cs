using UnityEngine;
using System.Collections;
using Assets;
using TMPro;
using UnityEngine.UI;

public class FactoryPurchaseCell : MonoBehaviour {

    public FactoryConfig factoryToPurchase;

    public FactoryPurchasePopupView parentView;

    public TextMeshProUGUI name;
    public TextMeshProUGUI description;
    public TextMeshProUGUI cost;
    public TextMeshProUGUI numberOfFactories;

    public Button purchaseButton;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetFactory ( FactoryConfig f )
    {
        factoryToPurchase = f;

        name.text = f.name;
        description.text = f.description;
        cost.text = GameState.sharedState.costForFactoryType(f).gold.ToString();

        purchaseButton.interactable = GameState.sharedState.CanPurchaseFactory(f);

        numberOfFactories.text = string.Format("built {0}/{1} factories", GameState.sharedState.numberOfFactoryTypeOwned(f.factoryID), f.maxOfThisType);
        if (GameState.sharedState.numberOfFactoryTypeOwned(f.factoryID) >= f.maxOfThisType)
        {
            numberOfFactories.color = Color.red;
            numberOfFactories.fontStyle = FontStyles.Bold;
        } else
        {
            numberOfFactories.color = Color.black;
            numberOfFactories.fontStyle = FontStyles.Normal;
        }
    }

    public void OnPurchaseClick()
    {
        SetFactory(factoryToPurchase);
        parentView.PurchaseAndClose(factoryToPurchase);
    }
}
