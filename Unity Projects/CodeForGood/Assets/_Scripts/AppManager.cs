using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AppManager : MonoBehaviour
{
    public static AppManager Instance
    {
        get { return m_instance; }
    }

    public AppState CurrentState
    {
        get { return m_currentState; }
        set
        {
            m_currentState = value;
            m_currentState.OnEnterState();
        }
    }

    //TEMP PUBLIC
    public string m_serverIp;
    public InitialState m_initialState;
    public NormalState m_normalState;
    public FetchUserIdState m_fetchUserIdState;

    private static AppManager m_instance;
    private AppState m_currentState;

    private void Awake()
    {
        if (m_instance != null && m_instance != this)
            Destroy(m_instance.gameObject);
        else
            m_instance = this;

        m_initialState = new InitialState();
        m_normalState = new NormalState();
        m_fetchUserIdState = new FetchUserIdState();
    }

    private void Start()
    {
        CurrentState = m_initialState;
    }
}
