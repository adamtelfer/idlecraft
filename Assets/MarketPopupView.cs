using UnityEngine;
using System.Collections;
using Assets;
using Google2u;

public class MarketPopupView : MonoBehaviour {

    public TradeOfferCell tradeOfferCellTemplate;
    public Transform ListOfOffers;

    public void RefreshAllOffers()
    {
        for (int childIndex = 0; childIndex < ListOfOffers.childCount; childIndex++)
        {
            GameObject g = ListOfOffers.GetChild(childIndex).gameObject;
            TradeOfferCell cell = g.GetComponent<TradeOfferCell>();
            cell.Refresh();
        }
    }

    public void OnPopUpOpen()
    {
        Debug.Log("OnPopUpOpen");
        if (ListOfOffers.childCount <= 0)
        {
            foreach (EconomyDBRow row in EconomyDB.Instance.Rows)
            {
                if (Economy.getTypeForConfig(row) != Economy.EconomyType.GOLD)
                {
                    GameObject g = Instantiate(tradeOfferCellTemplate.gameObject);
                    g.transform.SetParent(ListOfOffers.transform);
                    g.transform.localScale = new Vector3(1f, 1f, 1f);

                    TradeOfferCell cell = g.GetComponent<TradeOfferCell>();
                    cell.Setup(this, row);
                }
            }
        }

        RefreshAllOffers();
    }

    public void OnPopUpClosed()
    {
        
    }

    public void CloseMarket()
    {
        RootViewManager.sharedManager.CloseCurrent();
    }

}
