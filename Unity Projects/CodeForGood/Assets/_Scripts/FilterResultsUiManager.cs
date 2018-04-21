using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterResultsUiManager : MonoBehaviour
{
    public FilterButtonUiInfo m_userProfileButtonPrefab;
    public Transform prefabTrans;

    public void SpawnUserProfileButtons(List<BestBuddyUserData> inputUserDatas)
    {
        for (int i = 0; i < inputUserDatas.Count; i++)
        {
            FilterButtonUiInfo createdButton = GameObject.Instantiate<FilterButtonUiInfo>(m_userProfileButtonPrefab, prefabTrans);
            createdButton.transform.localPosition = new Vector3(0, -createdButton.m_background.height/2 - (i * createdButton.m_background.height), 0);
            createdButton.PopulateUiWithInfo(inputUserDatas[i]);
        }
    }
}
