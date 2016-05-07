using UnityEngine;
using System.Collections;
using Assets;
using TMPro;
using UnityEngine.UI;

public class FactoryView : MonoBehaviour {

    public Factory factory;

    public TextMeshProUGUI factoryName;

    public Slider singleProgressBar;
    public Slider totalProgressBar;

    public UnityEngine.UI.Button collectButton;

    public GameObject haltedContainer;

    // Use this for initialization
    void Start () {
	}

    public void Setup(Factory f)
    {
        factory = f;
        factoryName.text = f.config.name;
    }

    public void OpenUpgradePopup()
    {
        FactoryUpgradePopupView popup = RootViewManager.sharedManager.PurchaseUpgradePopup;
        popup.Setup(factory);
        RootViewManager.sharedManager.PushView(popup.gameObject); //TODO: Add Listeners to the core factory to hear for updates
    }

    public void Collect()
    {
        GameState.sharedState.CollectFromFactory(factory);
    }

    public void Restart()
    {
        factory.Restart();
    }
	
	// Update is called once per frame
	void Update () {
        if (factory != null)
        {
            singleProgressBar.value = factory.progressToNextUnit();
            totalProgressBar.value = factory.progressToCapProfit();

            if (factory.progressToCapProfit() > 0f)
            {
                collectButton.gameObject.SetActive(true);
            }
            else
            {
                collectButton.gameObject.SetActive(false);
            }

            if (factory.status == Factory.FactoryStatus.WORKING)
            {
                haltedContainer.SetActive(false);
            }
            else
            {
                haltedContainer.SetActive(true);
            }
        }
	}
}
