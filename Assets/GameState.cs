using UnityEngine;
using System.Collections;
using Assets;

public class GameState : MonoBehaviour {

    //Singleton
    public static GameState sharedState = null;

    public Economy currentEconomy;
    public System.Collections.Generic.Stack<Factory> factories;

    //Listeners, should update this with Listeners
    public FactoryViewManager factoryManager;

	// Use this for initialization
	void Start () {

        sharedState = this;
        Config c = new Config();

        // starting economy
        currentEconomy = new Economy(c.initialEconomy);

        // factories to start with
        factories = new System.Collections.Generic.Stack<Factory>();
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Factory f in factories)
        {
            f.tick(Time.deltaTime);
        }
	}

    public int numberOfFactoryTypeOwned(string factoryID)
    {
        int i = 0;
        foreach (Factory f in factories)
        {
            if (string.Equals(f.config.factoryID,factoryID))
            {
                ++i;
            }
        }
        return i;
    }

    public Economy costForFactoryType(FactoryConfig factoryType)
    {
        return factoryType.baseBuildCost.applyGrowthCurve(numberOfFactoryTypeOwned(factoryType.factoryID));
    }

    public bool CanPurchaseFactory (FactoryConfig f)
    {
        return numberOfFactoryTypeOwned(f.factoryID) < f.maxOfThisType && currentEconomy.canPurchase(costForFactoryType(f));
    }

    public void PurchaseFactory(FactoryConfig f)
    {
        if (CanPurchaseFactory(f))
        {
            currentEconomy.purchase(costForFactoryType(f));
            Factory nFactory = new Factory(f);
            factories.Push(nFactory);
            factoryManager.AddFactory(nFactory);
        }
    }

    public void CollectFromFactory( Factory f )
    {
        currentEconomy += f.currentProfit;
        f.currentProfit = new Economy();
    }
}
