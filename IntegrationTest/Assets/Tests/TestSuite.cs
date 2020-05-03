using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator TestSuiteCoroutine()
        {
            yield return SceneManager.LoadSceneAsync("SampleScene",LoadSceneMode.Additive);
            GameObject agent = GameObject.FindGameObjectWithTag("agent");
            Assert.IsNotNull(agent);
            yield return new WaitForSeconds(0.2f);
            Vector3 initialPos = agent.transform.position;
            yield return new WaitForSeconds(10.0f);
            Assert.AreNotEqual(initialPos, agent.transform.position);
            Object.Destroy(agent);
            yield return SceneManager.UnloadSceneAsync("SampleScene");
        }

    }
}
