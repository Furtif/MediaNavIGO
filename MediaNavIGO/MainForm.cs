using MediaNavIGO.Enums;
using MediaNavIGO.Models;
using MediaNavIGO.Utils;
using System.Diagnostics;
using BrightIdeasSoftware;
using System.Security.Cryptography;
using System.Text;

namespace MediaNavIGO
{
    public partial class MainForm : Form
    {
        private readonly List<ItemSetting> listUSB = new();
        private readonly List<ItemSetting> listLOCAL = new();
        private readonly List<ItemSetting> listReady = new();
        private Dictionary<string, string> deviceInfos = new();
        private Color origusbtextback;
        private Color origusbtextfore;
        //filters of emuns FolderType
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_MAP = new() { ".fbl", ".fda", ".fpa", ".ftr", ".fjv", ".hnr", ".fsp", ".fjw" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_POI = new() { ".poi" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_GLOBAL = new() { ".zip" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_LANG = new() { ".zip" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_SPEEDCAM = new() { ".spc" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_TMC = new() { ".tmc" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_VOICE = new() { ".zip" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_USERDATA = new() { ".zip" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_BUILDING = new() { ".3dl", ".3dc" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT_PHONEME = new() { ".ph" };
        private readonly List<string> FILTER_OF_FOLDER_LICENSE = new() { ".lic", ".lyc", ".nng" };
        private readonly List<string> FILTER_OF_FOLDER_CONTENT = new() { ".pinfo" };
        private readonly List<string> FILTER_OF_FOLDER_NAVI_ROOT = new() { "nngnavi", "nngnavi.exe", ".zip" };
        private readonly List<string> FILTER_OF_FOLDER_UX = new() { ".zip" };
        // ALL loaded in init's.
        private readonly List<string> ALL_FILTERS = new();
        //
        private Config config = new();
        private bool IsMNV3 = false;
        private bool IsCreationMode = false;
        private readonly string configfile = "MediaNavIGO.json";
        //private byte[] allUsbBytes = Array.Empty<byte>();

        public MainForm()
        {
            InitializeComponent();
            fastObjectListViewUSB.BackColor = Color.FromArgb(0, 0, 0);
            fastObjectListViewUSB.ForeColor = Color.LightGray;
            fastObjectListViewLocal.BackColor = Color.FromArgb(0, 0, 0);
            fastObjectListViewLocal.ForeColor = Color.LightGray;
            fastObjectListViewDevice.BackColor = Color.FromArgb(0, 0, 0);
            fastObjectListViewDevice.ForeColor = Color.LightGray;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.Text = this.Text + " - v" + Application.ProductVersion;
            //set all filters..
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_MAP);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_POI);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_GLOBAL);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_LANG);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_SPEEDCAM);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_TMC);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_VOICE);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_USERDATA);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_BUILDING);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT_PHONEME);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_LICENSE);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_CONTENT);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_NAVI_ROOT);
            ALL_FILTERS.AddRange(FILTER_OF_FOLDER_UX);
            //
            origusbtextback = textBoxUSB.BackColor;
            origusbtextfore = textBoxUSB.ForeColor;
            deviceInfos.Add("[?]_init_mode", @"select folders first...");
            fastObjectListViewDevice.SetObjects(deviceInfos);
            LoadConfig();
            UpdateStatus();
        }

        private void SetUSBFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config.USBPath = null;
            LoadUSBFolder();
        }

        private void SetLocalFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config.LOCALPath = null;
            LoadLocalolder();
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageUSB)
            {
                fastObjectListViewUSB.SetObjects(listUSB);
                fastObjectListViewUSB.SelectedIndex = -1;
            }
            else if (tabControlMain.SelectedTab == tabPageLocal)
            {
                fastObjectListViewLocal.SetObjects(listLOCAL);
                fastObjectListViewLocal.SelectedIndex = -1;
            }
            else if (tabControlMain.SelectedTab == tabPageConfig)
            {
                fastObjectListViewDevice.SetObjects(deviceInfos);
                fastObjectListViewDevice.SelectedIndex = -1;
            }
            UpdateStatus();
        }

        private void FastObjectListViewUSB_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.Model is not ItemSetting item)
            {
                return;
            }
            Color color = GetItemColor(item.FolderType);
            if (e.Column == olvColumnUSBFolderType)
            {
                e.SubItem.ForeColor = color;
            }
            else if (e.Column == olvColumnUSBName)
            {
                e.SubItem.ForeColor = color;
            }
        }

        private void FastObjectListViewLocal_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.Model is not ItemSetting item)
            {
                return;
            }
            Color color = GetItemColor(item.FolderType);
            if (item.Update)
            {
                e.SubItem.ForeColor = Color.Cyan;
                e.SubItem.BackColor = Color.Blue;
            }
            else if (item.InUSB)
            {
                e.SubItem.ForeColor = Color.Cyan;
            }
            else if (e.Column == olvColumnLocalFolderType)
            {
                e.SubItem.ForeColor = color;
            }
            else if (e.Column == olvColumnLocalName)
            {
                e.SubItem.ForeColor = color;
            }
            else if (e.Column == olvColumnLocalUsbName)
            {
                e.SubItem.ForeColor = color;
            }
            else if (e.Column == olvColumnLocalInUSB)
            {
                e.SubItem.ForeColor = Color.Red;
            }
            else if (e.Column == olvColumnLocalUpdate)
            {
                e.SubItem.ForeColor = Color.Red;
            }
        }

        private void ButtonSelectUSBFolder_Click(object sender, EventArgs e)
        {
            config.USBPath = null;
            LoadUSBFolder();
            if (config.LOCALPath != null)
                LoadLocalolder();
        }

        private void ButtonSelectLocalFolder_Click(object sender, EventArgs e)
        {
            config.LOCALPath = null;
            LoadLocalolder();
        }

        private void ButtonStartUpdate_Click(object sender, EventArgs e)
        {
           if (buttonStartUpdate.Text == "Success [Close]")
           {
                //MessageBox.Show("Demo Test -> [OK]\nNo data changed, contact the author.\n\nClose.", "Close!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            buttonStartUpdate.Enabled = false;
            buttonSelectLocalFolder.Enabled = false;
            buttonSelectUSBFolder.Enabled = false;
            checkBoxOnlyExists.Enabled = false;
            buttonStartUpdate.Text = "Wait ...";
            buttonStartUpdate.BackColor = Color.Yellow;
            var mylist = listLOCAL.FindAll(x => x.Update && !x.Ready);
            if (mylist?.Count == 0)
                return;
            progressBarUpdate.Maximum = mylist.Count;
            toolStripProgressBarUpdate.Maximum = mylist.Count;
            foreach (var i in mylist)
            {
                if (i.InUSB)
                {
                    var md5 = GenerateMD5(File.ReadAllBytes(i.FullPath));
                    var c = listUSB.Find(x => x.RealName.ToLower() == i.RealName.ToLower());
                    if (c != null)
                    {
                        try
                        {
                            bool upt = false;
                            long oldsize = 0L;
                            foreach (var s in File.ReadAllLines(c.FullPath))
                            {
                                if (s.Contains("md5"))
                                {
                                    if (s.Split("=")[1].Trim() != md5)
                                        upt = true;
                                }
                                if (s.Contains("size"))
                                {
                                    if (long.TryParse(s.Split("=")[1].Replace("\"", null).Trim(), out long y))
                                    {
                                        oldsize = y;
                                    }
                                }
                            }
                            if (upt)
                            {
                                File.Copy(i.FullPath, c.FullPath.Replace(".stm", null), true);
                                if (!IsCreationMode) // ignore *.stm and *.md5 files if in creation mode.
                                {
                                    var ini = listUSB.Find(i => i.FullPath.ToLower().EndsWith(@"\device_status.ini"));
                                    if (ini != null)
                                    {
                                        string nd = null;
                                        var ct = "purpose=\"copy\"" + Environment.NewLine;
                                        foreach (var l in File.ReadAllLines(ini.FullPath).OrderBy(o => o))
                                        {
                                            var r = l.Replace(" ", null).Trim() + Environment.NewLine;
                                            if (!l.Split("=")[1].Contains("\""))
                                            {
                                                r = r.Replace(l.Split("=")[1], "\"" + l.Split("=")[1] + "\"");
                                            }
                                            if (l.Contains("freesize"))
                                            {
                                                if (long.TryParse(l.Split("=")[1].Replace("\"", null).Trim(), out long y))
                                                {
                                                    long lw = new FileInfo(c.FullPath.Replace(".stm", null)).Length;
                                                    long rs = lw - oldsize;
                                                    if (lw < oldsize)
                                                    {
                                                        rs = oldsize - lw;
                                                    }
                                                    r = r.Replace(y.ToString(), (y - rs).ToString());
                                                }
                                            }
                                            nd += r;
                                        }
                                        File.WriteAllBytes(ini.FullPath, Encoding.ASCII.GetBytes(nd)); // update freesize
                                        File.WriteAllBytes(c.FullPath, Encoding.ASCII.GetBytes(ct)); // create .stm
                                        File.WriteAllBytes(c.FullPath.Replace(".stm", null) + ".md5", Encoding.ASCII.GetBytes(md5)); // create .md5
                                    }
                                }
                            }
                        }
                        catch (UnauthorizedAccessException)// ex)
                        {
                            // MessageBox.Show(ex.Message,)
                        }
                    }
                }
                else if (!config.OnlyPresentInUsb)
                {
                    var p = config.USBPath;
                    switch (i.FolderType)
                    {
                        case FolderType.ROOT:
                            //p += @"\";
                            break;
                        case FolderType.NAVI_ROOT:
                            p += @"\navisync";
                            break;
                        case FolderType.LICENSE:
                            p += @"\navisync\license\";
                            break;
                        case FolderType.UX:
                            p += @"\navisync\ux\";
                            break;
                        case FolderType.CONTENT:
                            p += @"\navisync\content\";
                            break;
                        case FolderType.GLOBAL_CFG:
                            p += @"\navisync\content\global_cfg\";
                            break;
                        case FolderType.MAP:
                            p += @"\navisync\content\map\";
                            break;
                        case FolderType.POI:
                            p += @"\navisync\content\poi\";
                            break;
                        case FolderType.SPEEDCAM:
                            p += @"\navisync\content\speedcam\";
                            break;
                        case FolderType.BUILDING:
                            p += @"\navisync\content\building\";
                            break;
                        case FolderType.PHONEME:
                            p += @"\navisync\content\phoneme\";
                            break;
                        case FolderType.TMC:
                            p += @"\navisync\content\tmc\";
                            break;
                        case FolderType.VOICE:
                            p += @"\navisync\content\voice\";
                            break;
                        case FolderType.LANG:
                            p += @"\navisync\content\lang\";
                            break;
                        case FolderType.USERDATA:
                            p += @"\navisync\content\userdata\";
                            break;
                        case FolderType.SAVE:
                            p += @"\navisync\save\";
                            break;
                    }
                    if (!Directory.Exists(p))
                    {
                        Directory.CreateDirectory(p);
                    }
                    string file = p + i.RealName;
                    File.Copy(i.FullPath, file, true);
                    if (!IsCreationMode) // ignore *.stm and *.md5 files if in creation mode.
                    {
                        var ini = listUSB.Find(i => i.FullPath.ToLower().EndsWith(@"\device_status.ini"));
                        if (ini != null)
                        {
                            string nd = null;
                            var md5 = GenerateMD5(File.ReadAllBytes(file));
                            var ct = "purpose=\"copy\"" + Environment.NewLine;
                            foreach (var l in File.ReadAllLines(ini.FullPath).OrderBy(o => o))
                            {
                                var r = l.Replace(" ", null).Trim() + Environment.NewLine;
                                if (!l.Split("=")[1].Contains("\""))
                                {
                                    r = r.Replace(l.Split("=")[1], "\"" + l.Split("=")[1] + "\"");
                                }
                                if (l.Contains("freesize"))
                                {
                                    if (long.TryParse(l.Split("=")[1].Replace("\"", null).Trim(), out long y))
                                    {
                                        r = r.Replace(y.ToString(), (y - new FileInfo(file).Length).ToString());
                                    }
                                }
                                nd += r;
                            }
                            File.WriteAllBytes(ini.FullPath, Encoding.ASCII.GetBytes(nd)); // update freesize
                            File.WriteAllBytes(file + ".stm", Encoding.ASCII.GetBytes(ct)); // create .stm
                            File.WriteAllBytes(file + ".md5", Encoding.ASCII.GetBytes(md5)); // create .md5
                        }
                    }
                }
                i.Update = false;
                i.Ready = true;
                i.InUSB = true;
                listReady.Add(i);
                UpdateStatus();
            }
            LoadUSBFolder();
            LoadLocalolder();
            buttonStartUpdate.Enabled = true;
            buttonStartUpdate.Text = "Success [Close]";
            buttonStartUpdate.BackColor = Color.Lime;
            buttonSelectLocalFolder.Enabled = true;
            buttonSelectUSBFolder.Enabled = true;
            checkBoxOnlyExists.Enabled = true;
            UpdateStatus();
        }

        private void FastObjectListViewLocal_DoubleClick(object sender, EventArgs e)
        {
            SetUpdate();
        }

        private void SendToUsbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUpdate();
        }

        private void PictureBoxAbout_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.paypal.me/rocketbot")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void CheckBoxOnlyExists_CheckedChanged(object sender, EventArgs e)
        {
            config.OnlyPresentInUsb = checkBoxOnlyExists.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string data = JsonUtils.ToJson(config, true);
            File.WriteAllText(configfile, data);
        }

        private void UpdateStatus()
        {
            buttonStartUpdate.Enabled = false;
            progressBarUpdate.Enabled = buttonStartUpdate.Enabled;
            toolStripProgressBarUpdate.Enabled = buttonStartUpdate.Enabled;
            toolStripProgressBarUpdate.Visible = buttonStartUpdate.Enabled;
            toolStripProgressBarUpdate.Value = progressBarUpdate.Value;
            int update = listLOCAL.FindAll(x => x.Update && !x.Ready)?.Count ?? 0;
            int ready = listReady.FindAll(x => x.Ready)?.Count ?? 0;
            int inusb = listLOCAL.FindAll(x => x.InUSB)?.Count ?? 0;
            int found = listLOCAL.FindAll(x => x.FullPath.ToLower().Contains(@"\content\"))?.Count ?? 0;
            buttonSelectLocalFolder.BackColor = (listLOCAL.FindAll(x => x.FullPath.ToLower().Contains(@"\content\"))?.Count > 1) ? Color.Lime : Color.Yellow;
            buttonSelectUSBFolder.BackColor = (listUSB.FindAll(x => x.FullPath.ToLower().Contains(@"\content\"))?.Count > 1) ? Color.Lime : Color.Yellow;
            toolStripStatusLabelGlobalFiles.Text = (listLOCAL.Count + listUSB.Count + ready).ToString();
            toolStripStatusLabelNaviSync.Text = (listUSB.Count + ready).ToString();
            toolStripStatusLabelWorkLocal.Text = listLOCAL.Count.ToString();
            toolStripStatusLabelInUSB.Text = inusb.ToString();
            toolStripStatusLabelUpdate.Text = update.ToString();
            toolStripStatusLabelReady.Text = ready.ToString();
            if (ready > 0)
            {
                progressBarUpdate.Value = ready;
                toolStripProgressBarUpdate.Value = ready;
                toolStripStatusLabelReady.Text = ready.ToString();
                buttonStartUpdate.Enabled = true;
                progressBarUpdate.Enabled = true;
                toolStripProgressBarUpdate.Enabled = true;
                toolStripProgressBarUpdate.Visible = true;
            }
            if (update > 0)
            {
                toolStripStatusLabelUpdate.Text = update.ToString();
                buttonStartUpdate.Enabled = true;
                progressBarUpdate.Enabled = true;
                toolStripProgressBarUpdate.Enabled = true;
                toolStripProgressBarUpdate.Visible = true;
            }
            StatusStripStats.Refresh();
        }

        private string GetRealName(string fullpath)
        {
            string name = Path.GetFileName(fullpath);
            string real = name;
            if (name.Contains("."))
            {
                var t = name.Split(".")[0];
                string ext = null;
                if (name.Split(".")[1].StartsWith("Q"))
                    ext = "." + name.Split(".")[2];
                else if (name.Split(".")[1] != null)
                    ext = "." + name.Split(".")[1];
                real = t + ext;
                var r = real.Split(".")[0].Split("_");
                foreach (var i in r)
                {
                    if (int.TryParse(i, out int p))
                    {
                        if (p > 0)
                        {
                            //real = real.Replace(i, null);
                        }
                    }
                }
                real = real.Replace("_HERE_", null).Replace("_.", ".");
                switch (GetFolderType(fullpath))
                {
                    case FolderType.MAP:
                    case FolderType.POI:
                    case FolderType.SPEEDCAM:
                    case FolderType.BUILDING:
                    case FolderType.PHONEME:
                        real = real.Replace("_", null);
                        break;
                }
                if (real.Contains("ext."))
                {
                    if (!real.Contains("_"))
                    {
                        real = real.Replace("ext.", "_ext.");
                    }
                }
                real = real.Replace("Extended.", "_ext.");
                real = real.Replace("Fast.", "Fastest.");
                real = real.Replace("Short.", "Shortest.");
                real = real.Replace("Economical.", "Economic.");
                if (!IsMNV3)
                    real = real.ToLower();
            }
            return real;
        }

        private static Color GetItemColor(FolderType item)
        {
            switch (item)
            {
                case FolderType.MAP:
                    return Color.Green;
                case FolderType.POI:
                    return Color.Tomato;
                case FolderType.GLOBAL_CFG:
                    return Color.Beige;
                case FolderType.LANG:
                    return Color.Yellow;
                case FolderType.SPEEDCAM:
                    return Color.Blue;
                case FolderType.TMC:
                    return Color.Orange;
                case FolderType.VOICE:
                    return Color.LightGreen;
                case FolderType.USERDATA:
                    return Color.RosyBrown;
                case FolderType.BUILDING:
                    return Color.Magenta;
                case FolderType.PHONEME:
                    return Color.Yellow;
                case FolderType.LICENSE:
                    return Color.RebeccaPurple;
                case FolderType.UX:
                    return Color.Aqua;
                case FolderType.CONTENT:
                    return Color.Teal;
                case FolderType.SAVE:
                    return Color.Gray;
                case FolderType.NAVI_ROOT:
                    return Color.Red;
                case FolderType.ROOT:
                    return Color.LimeGreen;
                default:
                    return Color.Red;
            }
        }

        private static FolderType GetFolderType(string item)
        {
            if (item.ToLower().Contains(@"\content\map\"))
                return FolderType.MAP;
            else if (item.ToLower().Contains(@"\content\poi\"))
                return FolderType.POI;
            else if (item.ToLower().Contains(@"\content\global_cfg\"))
                return FolderType.GLOBAL_CFG;
            else if (item.ToLower().Contains(@"\content\lang\"))
                return FolderType.LANG;
            else if (item.ToLower().Contains(@"\content\speedcam\"))
                return FolderType.SPEEDCAM;
            else if (item.ToLower().Contains(@"\content\tmc\"))
                return FolderType.TMC;
            else if (item.ToLower().Contains(@"\content\voice\"))
                return FolderType.VOICE;
            else if (item.ToLower().Contains(@"\content\userdata\"))
                return FolderType.USERDATA;
            else if (item.ToLower().Contains(@"\content\building\"))
                return FolderType.BUILDING;
            else if (item.ToLower().Contains(@"\content\phoneme\"))
                return FolderType.PHONEME;
            else if (item.ToLower().Contains(@"\license\"))
                return FolderType.LICENSE;
            else if (item.ToLower().Contains(@"\ux\"))
                return FolderType.UX;
            else if (item.ToLower().Contains(@"\content\"))
                return FolderType.CONTENT;
            else if (item.ToLower().Contains(@"\save\"))
                return FolderType.SAVE;
            else if (item.ToLower().Contains(@"\navisync"))
                return FolderType.NAVI_ROOT;
            else if (item.ToLower().Contains(@":\"))
                return FolderType.ROOT;
            else
                return FolderType.NONE;
        }

        private bool IsValideFile(string fullpath)
        {
            foreach (var i in ALL_FILTERS)
            {
                if (fullpath.EndsWith(i))
                {
                    return true;
                }
            }
            return false;
        }

        private void LoadConfig()
        {
            if (File.Exists(configfile))
            {
                string data = File.ReadAllText(configfile);
                config = JsonUtils.FromJson<Config>(data);
            }
            if (config.USBPath != null && Directory.Exists(config.USBPath)) //Ignore for create mode && File.Exists(config.USBPath + @"\device_status.ini"))
                LoadUSBFolder();
            if (config.LOCALPath != null && Directory.Exists(config.LOCALPath))
                LoadLocalolder();
            checkBoxOnlyExists.Checked = config.OnlyPresentInUsb;
        }

        private static string GenerateMD5(byte[] content)
        {
            var md5 = MD5.Create();
            // Convert the byte array to hexadecimal string
            byte[] hashBytes = md5.ComputeHash(content);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void SetUpdate()
        {
            if (fastObjectListViewLocal.SelectedObjects.Count == 0 || !fastObjectListViewLocal.SelectedObjects.Cast<ItemSetting>().Any())
                return;
            foreach (var t in fastObjectListViewLocal.SelectedObjects.Cast<ItemSetting>())
            {
                if (!t.InUSB && config.OnlyPresentInUsb)
                {
                    MessageBox.Show("Please disable [Update only present into NaviSync folder] option for force inject this item.", "Ignore!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (listReady.Contains(t))
                {
                    MessageBox.Show("This item is already updated.", "Ignore!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                t.Update = !t.Update;
                UpdateStatus();
            }
            fastObjectListViewLocal.SelectObjects(listLOCAL);
            fastObjectListViewLocal.SelectedIndex = -1;
        }

        private void LoadUSBFolder()
        {
            try
            {
                //GetHasList();
                listUSB.Clear();
                textBoxUSB.Text = null;
                buttonGenMicomInis.Enabled = false;
                textBoxUSB.BackColor = origusbtextback;
                textBoxUSB.ForeColor = origusbtextfore;

                if (Directory.Exists(config.USBPath))
                {
                    IEnumerable<string> enumerable = Directory.EnumerateFiles(config.USBPath, "*.*", SearchOption.AllDirectories);
                    List<ItemSetting> files = new();
                    foreach (var item in enumerable)
                    {
                        if (item.EndsWith(".lyc"))
                        {
                            if (!enumerable.Where(x => x == item + ".md5").Any())
                            {
                                //MessageBox.Show(item + " this mis md5");
                                //File.WriteAllText(item + ".md5", GenerateMD5(File.ReadAllBytes(item)));
                                //var mismd5 = new ItemSetting(Path.GetFileName(item).Trim(), GetFolderType(item), Path.GetFileName(item), item, false, false, false);
                                //files.Add(mismd5);

                            }
                            if (!enumerable.Where(x => x == item + ".stm").Any())
                            {
                                //MessageBox.Show(item + " this mis stm");
                                //File.WriteAllText(item + ".stm", "purpose=\"copy\"");
                                //var missmt = new ItemSetting(Path.GetFileName(item).Trim(), GetFolderType(item), Path.GetFileName(item), item, false, false, false);
                                //files.Add(missmt);
                            }
                        }

                        if (item.Contains(@"\.") || item.ToLower().EndsWith(@"\wpsettings.dat") || item.ToLower().EndsWith(@"\indexervolumeguid"))
                            continue;
                        var _item = new ItemSetting(Path.GetFileName(item).Replace(".stm", null).Trim(), GetFolderType(item), Path.GetFileName(item), item, false, false, false);
                        files.Add(_item);
                    }
                    listUSB.AddRange(files.OrderBy(x => x.FolderType));
                    textBoxUSB.Text = config.USBPath;
                    fastObjectListViewUSB.SetObjects(listUSB);
                }
                else
                {
                    if (FolderBrowserDialogBoth.ShowDialog() == DialogResult.OK)
                    {
                        config.USBPath = FolderBrowserDialogBoth.SelectedPath;
                        IEnumerable<string> enumerable = Directory.EnumerateFiles(config.USBPath, "*.*", SearchOption.AllDirectories);
                        List<ItemSetting> files = new();
                        foreach (var item in enumerable)
                        {
                            if (item.Contains(@"\.") || item.ToLower().EndsWith(@"\wpsettings.dat") || item.ToLower().EndsWith(@"\indexervolumeguid"))
                                continue;
                            var _item = new ItemSetting(Path.GetFileName(item).Replace(".stm", null).Trim(), GetFolderType(item), Path.GetFileName(item), item, false, false, false);
                            files.Add(_item);
                        }
                        listUSB.AddRange(files.OrderBy(x => x.FolderType));
                        textBoxUSB.Text = config.USBPath;
                        fastObjectListViewUSB.SetObjects(listUSB);
                    }
                    else
                    {
                        deviceInfos.Clear();
                        deviceInfos.Add("[?]_init_mode", @"select folders first...");
                        fastObjectListViewDevice.SetObjects(deviceInfos);
                        return;
                    }
                }
                deviceInfos.Clear();
                string ini = string.Empty;
                foreach (var item in listUSB)
                {
                    if (item.FullPath.ToLower().EndsWith(@"\device_status.ini"))
                    {
                        ini = item.FullPath;
                    }
                }
                if (File.Exists(ini))
                {
                    IsMNV3 = false;
                    IsCreationMode = false;
                    long freesize = 0L;
                    foreach (var l in File.ReadAllLines(ini))
                    {
                        if (l.Contains('='))
                        {
                            var _1 = l.Split("=")[0].Trim();
                            var _2 = l.Split("=")[1].Trim();
                            if (long.TryParse(_2.Replace("\"", null), out long p))
                            {
                                if (_1 == "freesize")
                                {
                                    freesize = p;
                                    _2 = SizeUtils.ToSize(p, SizeUtils.SizeUnits.MB) + " " + SizeUtils.SizeUnits.MB.ToString();
                                }
                                if (_1 == "totalsize")
                                {
                                    _2 = SizeUtils.ToSize(p, SizeUtils.SizeUnits.MB) + " " + SizeUtils.SizeUnits.MB.ToString();
                                    deviceInfos.Add("usedsize", SizeUtils.ToSize(p - freesize, SizeUtils.SizeUnits.MB) + " " + SizeUtils.SizeUnits.MB.ToString());
                                }
                            }
                            deviceInfos.Add(_1, _2);
                            if (_2.Contains('_'))
                                _2 = _2.Split( "_", StringSplitOptions.TrimEntries)[0];
                            if (int.TryParse(_2.Replace("\"", null).Replace(".", null), out int y) && _1.Equals("os_version"))
                            {
                                if (y >= 100 && y <= 410)
                                    deviceInfos.Add("device_version", "Media Nav");
                                else if (y == 912)
                                    deviceInfos.Add("device_version", "Media Nav"); // Evolution late 2016"); // according toolbox name
                                else if (y >= 913 && y <= 10128)
                                    deviceInfos.Add("device_version", "Media Nav Evolution");
                                else if (y >= 10128)
                                {
                                    IsMNV3 = true;
                                    deviceInfos.Add("device_version", "Media Nav Evolution late 2018");
                                }
                                else
                                {
                                    IsMNV3 = true;
                                    deviceInfos.Add("device_version", "Media Nav Evolution late 202x");
                                }
                            }
                        }
                    }

                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    foreach (DriveInfo d in allDrives)
                    {
                        if (d.IsReady == true && d.DriveType == DriveType.Removable && config.USBPath.EndsWith(d.Name))
                        {
                            //Console Mode:
                            //Console.WriteLine("Drive {0}", d.Name);
                            //Console.WriteLine("  Drive type: {0}", d.DriveType);
                            //Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                            //Console.WriteLine("  File system: {0}", d.DriveFormat);
                            //Console.WriteLine(
                            //    "  Available space to current user:{0, 15} bytes",
                            //    d.AvailableFreeSpace);
                            //Console.WriteLine(
                            //    "  Total available space:          {0, 15} bytes",
                            //    d.TotalFreeSpace);
                            //Console.WriteLine(
                            //    "  Total size of drive:            {0, 15} bytes ",
                            //    d.TotalSize);
                            //MessageboxInfos:
                            //var t = File.ReadAllText(item.FullPath);
                            //var i = d.Name;                      
                            //MessageBox.Show(string.Format("Drive info {0}\nEncrypted: {1}\nDecrypt: {2}", i, t, Decrypt(t)));
                            buttonGenMicomInis.Enabled = true;
                            textBoxUSB.BackColor = Color.Blue;
                            textBoxUSB.ForeColor = Color.White;
                            textBoxUSB.Text = string.Format("[{0}, {1}, {2}, Usable Size: {3}]", d.Name, d.DriveType, d.VolumeLabel, SizeUtils.ToSize(freesize, SizeUtils.SizeUnits.MB) + " " + SizeUtils.SizeUnits.MB.ToString());
                            break;
                        }
                    }

                    foreach (var item in listUSB)
                    {
                        if (item.FullPath.ToLower().EndsWith(@"\brand.txt"))
                        {
                            deviceInfos.Add("brand", File.ReadAllText(item.FullPath).Trim());
                            break;
                        }
                    }
                    foreach (var item in listUSB)
                    {
                        if (item.FullPath.ToLower().EndsWith(@"\igo_version_a.sav"))
                        {
                            deviceInfos.Add("igo_version", File.ReadAllText(item.FullPath).Trim());
                            break;
                        }
                    }
                    deviceInfos.Add("android_auto", IsMNV3.ToString());
                    deviceInfos.Add("carplay", IsMNV3.ToString());
                }
                else
                {
                    deviceInfos.Add("mode", "create");
                    IsCreationMode = true;
                }
                //deviceInfos = new Dictionary<string, string>(deviceInfos.OrderBy(o => o.Key));
                fastObjectListViewDevice.SetObjects(deviceInfos);
                UpdateStatus();
            }
            catch (UnauthorizedAccessException ex)
            {
                listUSB.Clear();
                textBoxUSB.BackColor = Color.Red;
                textBoxUSB.ForeColor = Color.Yellow;
                textBoxUSB.Text = ex.Message;
                deviceInfos.Clear();
                deviceInfos.Add("[?]_init_mode", @"select folders first...");
                fastObjectListViewDevice.SetObjects(deviceInfos);
                return;
            }
        }

        private void LoadLocalolder()
        {
            var old = listLOCAL;
            listLOCAL.Clear();
            textBoxLocal.Text = null;
            if (Directory.Exists(config.LOCALPath))
            {
                IEnumerable<string> enumerable = Directory.EnumerateFiles(config.LOCALPath, "*.*", SearchOption.AllDirectories);
                List<ItemSetting> files = new();
                foreach (var item in enumerable)
                {
                    if (item.Contains(@"\."))
                        continue;
                    if (!IsValideFile(item))
                    {
                        continue;
                    }
                    var name = Path.GetFileName(item);
                    var real = GetRealName(item);
                    var ready = listReady.Find(x => x.Ready) != null;
                    bool inusb = listUSB.Find(x => x.RealName.ToLower() == real.Trim().ToLower()) != null;
                    var _item = new ItemSetting(real, GetFolderType(item), name, item, false, inusb, ready);
                    files.Add(_item);
                }
                listLOCAL.AddRange(files.OrderBy(x => x.FolderType));
            }
            else
            {
                if (FolderBrowserDialogBoth.ShowDialog() == DialogResult.OK)
                {
                    config.LOCALPath = FolderBrowserDialogBoth.SelectedPath;
                    var enumerable = Directory.EnumerateFiles(config.LOCALPath, "*.*", SearchOption.AllDirectories);
                    List<ItemSetting> files = new();
                    foreach (var item in enumerable)
                    {
                        if (!IsValideFile(item))
                        {
                            continue;
                        }
                        var name = Path.GetFileName(item);
                        var real = GetRealName(item);
                        var ready = listReady.Find(x => x.Ready) != null;
                        bool inusb = listUSB.Find(x => x.RealName.ToLower() == real.Trim().ToLower()) != null;
                        var _item = new ItemSetting(real, GetFolderType(item), name, item, false, inusb, ready);
                        files.Add(_item);
                    }
                    listLOCAL.AddRange(files.OrderBy(x => x.FolderType));
                }
            }
            textBoxLocal.Text = config.LOCALPath;
            fastObjectListViewLocal.SetObjects(listLOCAL);
            UpdateStatus();
        }

        private void ButtonGenMicomInis_Click(object sender, EventArgs e)
        {
            if (config.USBPath.EndsWith(@":\"))
            {
                File.WriteAllText(config.USBPath + "mcmtest_activate.ini", null);
                File.WriteAllText(config.USBPath + "mcmtest_activate_4medianav.ini", null);
                MessageBox.Show("Created files for micom test both versions MediaNav1,2,3:\n" + config.USBPath + "mcmtest_activate.ini\n" + config.USBPath + "mcmtest_activate_4medianav.ini", "Micom enable mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUSBFolder();
            }
        }


        /*
        public static string Decrypt(string cipherText)
        {
            var data = Encoding.UTF8.GetBytes(cipherText);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                var keys = md5.ComputeHash(Encoding.UTF8.GetBytes(cipherText));
                using (var tripDes = new TripleDESCryptoServiceProvider { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var transform = tripDes.CreateEncryptor();
                    var results = transform.TransformFinalBlock(data, 0, data.Length);
                    //return Convert.ToBase64String(results, 0, results.Length);
                   return Encoding.UTF8.GetString(results);
                }
            }
        }
        */
    }
}
