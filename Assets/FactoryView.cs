using UnityEngine;
using System.Collections;
using Assets;
using TMPro;

public class FactoryView : MonoBehaviour {

    public Factory factory;

    public TextMeshProUGUI factoryName;

    public UnityEngine.UI.Image singleProgressBar;
    public UnityEngine.UI.Image totalProgressBar;

    public UnityEngine.UI.Button collectButton;

    public GameObject haltedContainer;

    // Use this for initialization
    void Start () {
	
	}

    public void SetFactory(Factory f)
    {
        factory = f;
        factoryName.text = f.name;
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
        singleProgressBar.fillAmount = factory.progressToNextUnit();
        totalProgressBar.fillAmount = factory.progressToCapProfit();

        if (factory.progressToCapProfit() > 0f)
        {
            collectButton.gameObject.SetActive(true);
        } else
        {
            collectButton.gameObject.SetActive(false);
        }

        if (factory.status == Factory.FactoryStatus.WORKING)
        {
            haltedContainer.SetActive(false);
        } else
        {
            haltedContainer.SetActive(true);
        }
	}
}
