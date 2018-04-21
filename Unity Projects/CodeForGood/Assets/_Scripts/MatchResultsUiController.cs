using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchResultsUiController : MonoBehaviour
{
    public static MatchResultsUiController Instance
    {
        get { return m_instance; }
    }

    public BestBuddyUiInfo[] m_userUiInfos;
    public UILabel m_percentMatch;

    private static MatchResultsUiController m_instance;

    private void Awake()
    {
        if (m_instance != null && m_instance != this)
            Destroy(this.gameObject);
        else
            m_instance = this;
    }

    private void Start()
    {
        OnRecieveData();
    }

    public void OnRecieveData()
    {
        List<BestBuddyUserData> testDatas = new List<BestBuddyUserData>();
        m_percentMatch.text = "95% Match";

        BestBuddyUserData testDataA = new BestBuddyUserData('V', 'M', "Bobby", "I'm looking to be a friend with someone who loves ice cream and baseball", 25);
        BestBuddyUserData testDataB = new BestBuddyUserData('B', 'M', "Eric", "I like to eat lots of ice cream and play baseball", 2);
        testDatas.Add(testDataA);

        for (int i = 0; i < m_userUiInfos.Length; i++)
        {
            if (m_userUiInfos[i].m_userType == BestBuddyUiInfo.UserType.Buddy)
            {
                m_userUiInfos[i].PopulateUiWithInfo(testDataB);
                break;
            }
            else
            {
                m_userUiInfos[i].PopulateUiWithInfo(testDataA);
                break;
            }
        }
    }
}
