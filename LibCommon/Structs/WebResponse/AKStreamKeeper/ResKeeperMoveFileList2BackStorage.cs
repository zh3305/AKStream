using System;
using System.Collections.Generic;

namespace LibCommon.Structs.WebResponse.AKStreamKeeper;

[Serializable]
public class ResKeeperMoveFileList2BackStorage
{
    
        private List<string>? _pathList = new List<string>();

        public List<string>? PathList
        {
            get => _pathList;
            set => _pathList = value;
        }
    
}