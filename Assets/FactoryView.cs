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

    public Animator anim;
    public static string kFlipAnimationTrigger = "Flip";

    public GameObject haltedContainer;

    public GameObject normalView;
    public GameObject upgradeView;

    public void FlipViews()
    {
        if (normalView.active)
        {
            normalView.SetActive(false);
            upgradeView.SetActive(true);
        } else
        {
            normalView.SetActive(true);
            upgradeView.SetActive(false);
        }
    }

    public void UpgradeSpeed()
    {
        factory.UpgradeProductionSpeed();
    }

    public void UpgradeCapacity()
    {
        factory.UpgradeCapacity();
    }

    public void UpgradeProduction()
    {
        factory.UpgradeProductionOutput();
    }

    // Use this for initialization
    void Start () {
        anim = this.gameObject.GetComponent<Animator>();
	}

    public void SetFactory(Factory f)
    {
        factory = f;
        factoryName.text = f.config.name;
    }

    public void Collect()
    {
        GameState.sharedState.CollectFromFactory(factory);
    }

    public void GoToUpgrade()
    {
        anim.SetTrigger(kFlipAnimationTrigger);
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
