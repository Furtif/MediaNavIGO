using MediaNavIGO.Enums;

namespace MediaNavIGO.Models
{
    [Serializable]
    public class ItemSetting
    {
        public string Name { get; set; }
        public string RealName { get; set; }
        public string FullPath { get; set; }
        public FolderType FolderType { get; set; }
        public bool Update { get; set; }
        public bool InUSB { get; set; }
        public bool Ready { get; set; }
        //public string MD5 { get; set; }

        public ItemSetting(string realname, FolderType foldertype, string name, string fullpath, bool update, bool inusb, bool ready)//, string md5)
        {
            RealName = realname;
            FolderType = foldertype;
            Name = name;
            FullPath = fullpath;
            Update = update;
            InUSB = inusb;
            Ready = ready;
            //MD5 = md5;
        }
    }
}
