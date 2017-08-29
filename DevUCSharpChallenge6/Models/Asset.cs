using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevUCSharpChallenge6.Models
{
    public class Asset
    {
        private double _actsOfSubterfuge;

        public double ActsOfSubterfuge
        {
            get { return _actsOfSubterfuge; }
            set { _actsOfSubterfuge = value; }
        }

        private double _electionsRigged;

        public double ElectionsRigged
        {
            get { return _electionsRigged; }
            set { _electionsRigged = value; }
        }

        private string _assetName;

        public string AssetName
        {
            get { return _assetName; }
            set { _assetName = value; }
        }
        
    }

}