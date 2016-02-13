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
        currentEconomy = new Economy();
        currentEconomy.food = 20;
        factories = new System.Collections.Generic.Stack<Factory>();
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Factory f in factories)
        {
            f.tick(Time.deltaTime);
        }
	}

    public bool CanPurchaseFactory (Factory f)
    {
        return currentEconomy.canPurchase(f.factoryBuildCost);
    }

    public void PurchaseFactory(Factory f)
    {
        if (CanPurchaseFactory(f))
        {
            currentEconomy.purchase(f.factoryBuildCost);
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
