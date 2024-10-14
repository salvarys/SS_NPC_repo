using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Begger;
    private INPC m_Shopowner;

    public void SpawnVillagers()
    {
        m_Begger = m_Factory.GetNPC(NPCType.Begger);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

        m_Begger.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
    }
}
