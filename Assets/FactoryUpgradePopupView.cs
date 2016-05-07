using UnityEngine;
using System.Collections;
using Assets;
using TMPro;
using UnityEngine.UI;

public class FactoryUpgradePopupView : MonoBehaviour {

    private Factory currentFactory;

    public TextMeshProUGUI factoryName;
    public TextMeshProUGUI factoryDescription;

    public TextMeshProUGUI production;
    public TextMeshProUGUI capacity;
    public TextMeshProUGUI unitspermin;

    public Button btnUpgradeProduction;
    public Button btnUpgradeCapacity;
    public Button btnUpgradeSpeed;

    public TextMeshProUGUI costUpgradeProduction;
    public TextMeshProUGUI costUpgradeCapacity;
    public TextMeshProUGUI costUpgradeSpeed;

    public void UpdateContents() // refreshes the contents of the screen (use after upgrading, purchasing, opening)
    {
        factoryName.text = currentFactory.config.name;
        factoryDescription.text = currentFactory.config.description;

        production.text = currentFactory.unitProfit.toReadableText();
        capacity.text = currentFactory.cappedProfit.toReadableText();
        unitspermin.text = string.Format("{0} per min", currentFactory.unitsPerMinute);

        costUpgradeProduction.text = string.Format("{0}", currentFactory.CostToUpgradeProductionOutput().gold);
        costUpgradeCapacity.text = string.Format("{0}", currentFactory.CostToUpgradeCapacity().gold);
        costUpgradeSpeed.text = string.Format("{0}", currentFactory.CostToUpgradeProductionSpeed().gold);

        btnUpgradeCapacity.interactable = currentFactory.CanUpgradeCapacity();
        btnUpgradeProduction.interactable = currentFactory.CanUpgradeProductionQuantity();
        btnUpgradeSpeed.interactable = currentFactory.CanUpgradeProductionSpeed();
    }

    public void Close()
    {
        RootViewManager.sharedManager.CloseCurrent();
    }

    public void Setup (Factory f)
    {
        currentFactory = f;
        UpdateContents();
    }

    public void OnUpgradeProduction()
    {
        currentFactory.UpgradeProductionOutput();
        UpdateContents();
    }

    public void OnUpgradeCapacity()
    {
        currentFactory.UpgradeCapacity();
        UpdateContents();
    }

    public void OnUpgradeSpeed()
    {
        currentFactory.UpgradeProductionSpeed();
        UpdateContents();
    }

    public void OnPopUpOpen()
    {
    }

    public void OnPopUpClosed()
    {
    }
}
