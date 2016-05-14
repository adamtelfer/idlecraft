using UnityEngine;
using System.Collections;
using Assets;
using Google2u;
using UnityEngine.UI;
using TMPro;

public class TradeOfferCell : MonoBehaviour {

    private MarketPopupView _parent;
    private EconomyDBRow _config;

    public Button purchaseButton;
    public Image economyIcon;
    public TextMeshProUGUI currentAmountOfEconomy;
    public TextMeshProUGUI currentSaleAmount;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Refresh()
    {
        Economy.EconomyType thisType = Economy.getTypeForConfig(_config);

        int currentAmount = GameState.sharedState.currentEconomy.getValueForType(thisType);
        int marketValue = currentAmount * _config._maxMarketValue;

        currentAmountOfEconomy.text = string.Format("{0}x", currentAmount);
        currentSaleAmount.text = string.Format("{0}", marketValue);

        purchaseButton.interactable = marketValue > 0;
    }

    public void Sell()
    {
        Economy.EconomyType thisType = Economy.getTypeForConfig(_config);

        int currentAmount = GameState.sharedState.currentEconomy.getValueForType(thisType);
        int marketValue = currentAmount * _config._maxMarketValue;
        //TODO: this should be refactored...

        Economy economy = new Economy();
        economy.AddForEconomyType(thisType, currentAmount);
        economy.AddForEconomyType(Economy.EconomyType.GOLD, -marketValue);

        GameState.sharedState.Purchase(economy);

        _parent.RefreshAllOffers();
    }

    public void Setup(MarketPopupView parent, EconomyDBRow config )
    {
        _config = config;
        _parent = parent;

        Refresh();
    }
}
