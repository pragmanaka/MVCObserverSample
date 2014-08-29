using System;
using NUnit.Framework;
using MVCObserverSample;

namespace testMVCObserverSample
{
    [TestFixture] 
    public class testDataMgr
    {
        DataMgr m_DataMgr;

        [SetUp] public void Init()
        {
            m_DataMgr = new DataMgr();
        }

        [Test] public void Inc()
        {
            Assert.AreEqual(0, m_DataMgr.GetValue());
            m_DataMgr.Inc();
            Assert.AreEqual(1, m_DataMgr.GetValue());
            m_DataMgr.Inc();
            m_DataMgr.Inc();
            Assert.AreEqual(3, m_DataMgr.GetValue());
        }

        [Test]
        public void Dec()
        {
            Assert.AreEqual(0, m_DataMgr.GetValue());
            m_DataMgr.Dec();
            Assert.AreEqual(-1, m_DataMgr.GetValue());
            m_DataMgr.Dec();
            m_DataMgr.Dec();
            Assert.AreEqual(-3, m_DataMgr.GetValue());
        }

    }
}
