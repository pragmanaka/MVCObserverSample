using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCObserverSample
{
    public partial class FMDec : Form
    {
        public FMDec(DataMgr data)
        {
            InitializeComponent();
            m_Data = data;
            m_ViewSub = new ViewSub(lblValue, m_Data);
            m_Data.Attach(m_ViewSub);
            m_Data.Init();
        }

        DataMgr m_Data;
        ViewSub m_ViewSub;

        private void btnDec_Click(object sender, EventArgs e)
        {
            m_Data.Dec();
        }

        private void FMDec_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Data.Detach(m_ViewSub);
        }
    }
}
